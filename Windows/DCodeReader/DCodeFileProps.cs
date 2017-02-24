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

    public partial class DCodeFileProps : Form {

        private System.Windows.Forms.Timer backTast;
        private DCodeFile file;

        private void InitTheme() {
            this.BackColor = Styles.getTheme().getBackGround();
            this.ForeColor = Styles.getTheme().getForeGround();
            //Props_Cancel.BackColor = this.BackColor + Color.FromArgb(0x222);
        }

        public DCodeFileProps(DCodeFile file) {
            InitializeComponent();
            this.file = file;

            if (file.getStatusKey() == DCodeFile.ALRIGHT) {
                // Init components
                TitleEdit.Text = file.getTitle();
                EncodeTypeEdit.Text = file.getEncodeType();
                ContentEdit.Text = file.getText();
            }
            //InitTheme();
        }

        private void DCodeFileProps_Load(object sender, EventArgs e) {
            this.backTast = new System.Windows.Forms.Timer();
            this.backTast.Tick += new EventHandler(this.backTasking);
            this.backTast.Interval = 100;
            this.backTast.Start();
        }

        private void DCodeFileProps_FormClosing(object sender, FormClosingEventArgs e) {
            this.backTast.Stop();
        }

        private void Props_OK_Click(object sender, EventArgs e) {
            file.setTitle(TitleEdit.Text);
            file.setEncodeType(EncodeTypeEdit.Text);
            file.setText(ContentEdit.Text);
            this.Close();
        }

        private void Props_Cancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void backTasking(object sender, EventArgs e) {
            bool titleError = TitleEdit.Text.IndexOf('_') > -1;

            Props_OK.Enabled = !titleError;
        }
    }
}
