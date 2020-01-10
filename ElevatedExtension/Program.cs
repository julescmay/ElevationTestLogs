using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ElevatedExtension {
    class Program {

        static void Main (string [] args) {
            if (args.Length >2) {
                if (args[2]=="/admin") {
                    string aliasPath = Environment.GetFolderPath (Environment.SpecialFolder.LocalApplicationData) + @"\microsoft\windowsapps\ElevatedExtension.exe";
                    ProcessStartInfo info = new ProcessStartInfo ( );
                    info.Verb="runas";
                    info.UseShellExecute=true;
                    info.FileName=aliasPath;
                    try {
                        Process.Start (info);
                    } catch (Exception e) {
                        System.Windows.Forms.MessageBox.Show (e.Message, "Something went wrong");
                    }
                    return;
                }
            }
            AutoResetEvent areWeDone = new AutoResetEvent (false);
            areWeDone.WaitOne (10000);
        }

    }
}
