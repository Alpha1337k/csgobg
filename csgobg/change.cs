using Accord.Video.FFMPEG;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Phantom_s_CSBG_Converter
{
	public struct Data
	{
		public string CsDir { get; set; }
		public bool IsCsDir { get; set; }
		public string SrcPath { get; set; }
		public bool ReplacePossible { get; set; }

		public string Replace { get { return null; } set
			{
				ReplaceFile = value;
				ReplaceOld = ReplaceFile.Insert(ReplaceFile.Length - 5, "_old");
			} }
		public string ReplaceOld { get; set; }
		public string ReplaceFile { get; set; }

		public bool Audio { get; set; }
		public bool IsPhoto()
		{
			if (SrcPath == null)
				return false;
			string ext = Path.GetExtension(SrcPath).ToLower();
			switch (ext)
			{
				case ".jpg": return true;
				case ".tiff": return true;
				case ".gif": return true;
				case ".png": return true;
				case ".exif": return true;
				case ".bmp": return true;
				default: return false;
			}
		}
	}
	class Change
	{

		static void ConvertVid(string file, Data data)	// creates bat file containing all the data to make 
		{
			string TextToRun;
			if (data.Audio == true)
				TextToRun = "cd ffmpeg\\bin \nffmpeg -i " + Path.GetFileName(file) + " -c:v libvpx -qmin 0 -qmax 10 -crf 5 -b:v 2M -c:a libvorbis output.webm";
			else
				TextToRun = "cd ffmpeg\\bin \nffmpeg -i " + Path.GetFileName(file) + " -an -c:v libvpx -qmin 0 -qmax 10 -crf 5 -b:v 2M -c:a libvorbis output.webm";

			string filename = @"ffmpeg\bin\boot.bat";
			File.WriteAllText(filename, TextToRun);
			var proc = System.Diagnostics.Process.Start(filename);

			proc.WaitForExit();
		}
		static void CreateVideo(Data data)		// Creates an AVI video containing 20 frames of the image
		{
			Bitmap image = (Bitmap)Image.FromFile(data.SrcPath);
			string path = Directory.GetCurrentDirectory() + @"\ffmpeg\bin\temp.avi";

			VideoFileWriter writer = new VideoFileWriter();

			writer.Open(path, image.Width, image.Height, 1, VideoCodec.Raw, 2147483647);
			for (var i = 0; i < 20; i++)
			{
				writer.WriteVideoFrame(image);
				Console.WriteLine(i);
			}
			writer.Flush();
			writer.Close();
		}

		static void ReplaceVideo(Data data)
		{
			if (!File.Exists(data.CsDir + '\\' + data.ReplaceOld) && data.ReplacePossible == true &&
				 File.Exists(data.CsDir + '\\' + data.ReplaceFile))
				File.Move(data.CsDir + '\\' + data.ReplaceFile, data.CsDir + '\\' + data.ReplaceOld);
			if (File.Exists(data.CsDir + '\\' + data.ReplaceFile))
				File.Delete(data.CsDir + '\\' + data.ReplaceFile);
			File.Move(Directory.GetCurrentDirectory() + @"\ffmpeg\bin\output.webm", data.CsDir + '\\' + data.ReplaceFile);
			File.Delete(Directory.GetCurrentDirectory() + @"\ffmpeg\bin\output.webm");
		}
		
		static void Cleanup()
		{
			string path = Directory.GetCurrentDirectory() + @"\ffmpeg\bin\temp.avi";
			if (File.Exists(path))
				File.Delete(path);
			path = Directory.GetCurrentDirectory() + @"\ffmpeg\bin\output.webm";
			if (File.Exists(path))
				File.Delete(path);

		}

		static public void SetBG(Data data)
		{
			//Convert photo to video
			if (data.SrcPath == null)
				return;
			if (data.IsPhoto())
			{
				CreateVideo(data);
				ConvertVid("temp.avi", data);
			}
			else
			{
				if (File.Exists(Directory.GetCurrentDirectory() + @"\ffmpeg\bin\" + Path.GetFileName(data.SrcPath)))
					File.Delete(Directory.GetCurrentDirectory() + @"\ffmpeg\bin\" + Path.GetFileName(data.SrcPath));
				File.Copy(data.SrcPath, Directory.GetCurrentDirectory() + @"\ffmpeg\bin\" + Path.GetFileName(data.SrcPath));
				ConvertVid(data.SrcPath, data);
				File.Delete(Directory.GetCurrentDirectory() + @"\ffmpeg\bin" + Path.GetFileName(data.SrcPath));
			}
			ReplaceVideo(data);
			Cleanup();
			MessageBox.Show("Done!");
		}
	}
}
