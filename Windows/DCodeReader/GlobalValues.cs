using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;

namespace DCodeReader {
    public static class GlobalValues {
        //public static String localPath = System.Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
        //public static String localPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
        //public static String localPath = "C:\\Users\\Davi\\Documents\\GitHub\\DCodeReader\\Windows\\DCodeReader\\bin\\Debug";
        public static String localPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
        //public static String prefsPath = "C:/Users/Davi/Documents/GitHub/DCodeReader/Prefs/prefs.DCode";
        public static String prefsPath = Path.Combine(localPath , "prefs.DCode");

        public static String DefaultExt = ".DCode";
        //public static String Filter = "DCode file (*.DCode)|*.DCode|Text file (*.txt)|*.txt";
        public static String Filter = "DCode file (*.DCode)|*.DCode;*.Dcode;*.dCode;*.dcode|Text file (*.txt)|*.txt";

        public static String AppName = "DCode Reader";

        // Static methods

        //x = this.Location.X;
        //y = this.Location.Y;
        //width = this.Width;
        //height = this.Height;

        /*public static int getNewWindowX(int Width){
            return MainForm.x + ((MainForm.width / 2) - (Width / 2));
        }

        public static int getNewWindowY(int Height) {
            return MainForm.y + ((MainForm.height / 2) - (Height / 2));
        }*/
    }
}
