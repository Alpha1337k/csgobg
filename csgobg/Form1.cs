using Accord.Video.FFMPEG;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Web.UI.WebControls;


namespace Phantom_s_CSBG_Converter
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();
			FindCsDir();
		}


		//Main

		Data data;

		private void FillDropDown()
		{
			comboBox1.Items.Clear();
			comboBox1.Items.Add("output.webm");
			comboBox1.SelectedIndex = 0;
			if (data.IsCsDir)
				foreach (string f in Directory.GetFiles(data.CsDir))
					if (Path.GetExtension(f) == ".webm")
						comboBox1.Items.Add(Path.GetFileName(f));
		}

		private void FindCsDir()
		{
			string x;
			if (Directory.Exists(x = @"C:\Program Files (x86)\Steam\steamapps\common\Counter-Strike Global Offensive\csgo\panorama\videos"))
			{
				data.CsDir = x;

				Dirlabel.Text = "CSGO Directory : Automatically using version on C drive";
				Dirlabel.ForeColor = Color.Green;
				data.IsCsDir = true;
				data.ReplacePossible = true;
			}
			else
			{
				data.IsCsDir = false;
				Dirlabel.Text = "CSGO Directory : Not set";
				Dirlabel.ForeColor = Color.Red;
				data.ReplacePossible = false;
			}
			FillDropDown();
		}
		private void Button4_Click(object sender, EventArgs e)          // media set
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.InitialDirectory = "c:\\";
				openFileDialog.Filter = "Image And Video Files|*.BMP;*.JPG;*.GIF; *.TIFF; *.MP4; *.AVI; *.WEBM; *.JPG; *.EXIF|All files (*.*)|*.*";
				openFileDialog.FilterIndex = 2;
				openFileDialog.RestoreDirectory = true;

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					data.SrcPath = openFileDialog.FileName;
				}
			}
			MediaLabel.Text = "Media : set";
			MediaLabel.ForeColor = Color.Green;
		}

		private void Button1_Click(object sender, EventArgs e)      // start changing
		{
			if (comboBox1.SelectedItem == null)
			{
				MessageBox.Show("Error! is output file name OK?");
				return;
			}
			data.Replace = comboBox1.SelectedItem.ToString();
			Change.SetBG(data);
		}
		private void Button2_Click(object sender, EventArgs e)      // reset button
		{
			bool HasErrored = false;
			if (!data.IsCsDir)
			{
				MessageBox.Show("Please specify a valid csgo directory first!");
				return;
			}
			foreach (string f in Directory.GetFiles(data.CsDir))
			{
				if (Path.GetExtension(f) == ".webm" && f.Contains("_old.webm"))
				{
					try
					{
						File.Delete(f.Replace("_old", null));
						File.Move(f, f.Replace("_old", null));
					}
					catch (Exception x)
					{
						MessageBox.Show("The converter could not reverse the process. Please use steam to verify file intergity in order to reset the background.\n" + x);
						HasErrored = true;
					}
				}
			}
			if (!HasErrored)
				MessageBox.Show("Files have been reset!");
		}

		private void Button5_Click_1(object sender, EventArgs e)        // csgo dir set
		{
			using (var dialog = new FolderBrowserDialog())
			{
				DialogResult result = dialog.ShowDialog();
				data.CsDir = dialog.SelectedPath;
			}

			// see if video folder exists  
			if (!Directory.Exists(data.CsDir + @"\csgo\panorama\videos"))
			{
				data.ReplacePossible = false;
				Dirlabel.Text = "CSGO Directory : manual move required";
				Dirlabel.ForeColor = Color.Orange;
				data.IsCsDir = false;

			}
			else
			{
				data.ReplacePossible = true;
				data.CsDir += @"\csgo\panorama\videos";
				Dirlabel.Text = "CSGO Directory : set";
				Dirlabel.ForeColor = Color.Green;
				data.IsCsDir = true;
			}
			FillDropDown();
		}

		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			data.Audio = checkBox1.Checked;
		}

		private void Label1_Click(object sender, EventArgs e)
		{

		}

		private void Label2_Click(object sender, EventArgs e)
		{

		}

		private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}



