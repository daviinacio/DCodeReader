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
    }
}
