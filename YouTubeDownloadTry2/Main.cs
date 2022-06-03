using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace YouTubeDownload
{
    class YoutubeDL
    {

        static void Main(string[] args)
        {
            var _text = Clipboard.GetText();
            Console.WriteLine(_text);
            Console.WriteLine("Calling youtube-dl...");
            if (_text.Contains("http://") || _text.Contains("https://"))
                try
                {
                    Process.Start("youtube-dl", "-f 140 --output %(title)s.%(ext)s " + _text);
                }
                catch (Exception ex) { Console.WriteLine("Could Not Grab Title Name will be normal\n {0}", ex.Message); Process.Start("youtube-dl", "-f 140 " + _text); }
            else
            {
                Console.WriteLine("Text did not Contain a youtube link");
                Console.ReadLine();
            }
        }
    }
}
