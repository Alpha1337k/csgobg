cd C:\Users\Alpha_1337\source\repos\CSBGConverter\ffmpeg\bin
ffmpeg -i temp.avi -c:v libvpx -qmin 0 -qmax 10 -crf 5 -b:v 1M -c:a libvorbis output.webm
