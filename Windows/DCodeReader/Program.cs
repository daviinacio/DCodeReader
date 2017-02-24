using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCodeReader {
    static class Program {
        public static DCodePreferences prefs;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string [] args) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mainForm;

            String settingsFolder = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\DaviApps\\DCode Reader\\settings\\");

            // Initialize prefs
            prefs = new DCodePreferences(new DCodeFile(settingsFolder + "settings.DCode"));
            prefs.Add("Theme", 0);
            prefs.Add("Border", 0);
            prefs.Add("Location.x", -1);
            prefs.Add("Location.y", -1);
            prefs.Add("lineNumber", true);

            Styles.currentTheme = prefs.GetInt("Theme", 0);

            mainForm = new MainForm();
            if (args.Length >= 1) {
                FileInfo file = new FileInfo(args [0]);
                if (file.Exists){
                    if (new DCodeFile(file.ToString()).getStatusKey().Equals(DCodeFile.ALRIGHT)) {
                        mainForm = new MainForm(file.ToString());
                    } else {
                        DialogResult m = MessageBox.Show("Arquivo corrompido, ou com versão incompatível do encoder.\nContinuar?", "Fatal error", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        if (m == DialogResult.No)
                            return;
                    }
                    //MessageBox.Show(file.ToString());
                }
            }
            Application.Run(mainForm);

            prefs.Set("Theme", Styles.currentTheme);
            prefs.Set("Location.x", mainForm.Location.X);
            prefs.Set("Location.y", mainForm.Location.Y);
            prefs.save();
        }
    }
}
