using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FileNameToClipboard
{
    class Program
    {
        [STAThread]
        static int Main(string[] args)
        {
            switch (args.Length)
            {
                case 0:
                    System.Console.WriteLine("FileNameToClipboard \"string1\" \"string2\" ...");
                    break;
                default:
                    SendToClipboard(args);
                    break;
            }
            return 0;
        }

        static string[] getFileNames(string[] filePathArray)
        {
            List<string> lst = new List<string>();
            foreach( string filepath in filePathArray ) {
                lst.Add(System.IO.Path.GetFileName(filepath));
            }
            return lst.ToArray();
        }

        static void SendToClipboard(string[] filePathArray)
        {
            string text = "";
            text = string.Join("\n", getFileNames(filePathArray));
      
            //System.Console.WriteLine(text);
            try
            {
                Clipboard.SetText(text);
            }
            catch (ArgumentNullException e)
            {
                System.IO.TextWriter errorWriter = Console.Error;
                errorWriter.WriteLine("Error: " + e.Message);
            }
        }
    }
}
