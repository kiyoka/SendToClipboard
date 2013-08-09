using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SendToClipboard
{
    class Program
    {
        [STAThread]
        static int Main(string[] args)
        {
            switch (args.Length)
            {
                case 0:
                    System.Console.WriteLine("SendToClipboard \"string\"");
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
            foreach( string filepath in filePathArray ) {
                text += filepath + "\n";
            }
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
