using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace FullPathToClipboard
{
    class Program
    {
        [STAThread]
        static int Main(string[] args)
        {
            switch (args.Length)
            {
                case 0:
                    System.Console.WriteLine("FullPathToClipboard \"string1\" \"string2\" ...");
                    break;
                default:
                    SendToClipboard(args);
                    break;
            }
            return 0;
        }

        static void SendToClipboard(string[] filePathArray)
        {
            string text = "";
            text = string.Join("\n", filePathArray);

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
