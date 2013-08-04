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
                    SendToClipboard(args[0]);
                    break;
            }
            return 0;
        }

        static void SendToClipboard(string filepath)
        {
            //System.Console.WriteLine(filepath);
            try
            {
                Clipboard.SetText(filepath);
            }
            catch (ArgumentNullException e)
            {
                System.IO.TextWriter errorWriter = Console.Error;
                errorWriter.WriteLine("Error: " + e.Message);
            }
        }
    }
}
