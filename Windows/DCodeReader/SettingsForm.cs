using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCodeReader {

    public partial class SettingsForm : Form {

        private DCodePreferences prefs;
        private Runnable onSave;

        /*public SettingsForm(DCodePreferences prefs, Runnable onSave) {
            This();
            this.onSave = onSave;
        }*/

        public SettingsForm() {
            This();
        }

        private void This() {
            InitializeComponent();
            this.prefs = Program.prefs;
            initPrefs();
            initComponents();
            if (onSave != null)
                onSave.run();
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            prefs.save();
            this.Hide();
        }

        // Methods
        private void initPrefs() {
            if(!(
                prefs.Add("lineNumber", true)
            )) prefs.save();
        }

        private void initComponents() {
            lineNumber.Checked = prefs.GetBool("lineNumber", true);
        }

        // Componentes action
        private void lineNumber_CheckedChanged(object sender, EventArgs e) {
            prefs.Set("lineNumber", lineNumber.Checked);
        }
    }
}
