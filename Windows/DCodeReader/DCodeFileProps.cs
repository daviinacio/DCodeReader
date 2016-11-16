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

        private DCodeFile file;

        public DCodeFileProps(DCodeFile file) {
            InitializeComponent();
            this.file = file;

            if (file.getStatusKey() == DCodeFile.ALRIGHT) {
                // Init components
                TitleEdit.Text = file.getTitle();
                EncodeTypeEdit.Text = file.getEncodeType();
                ContentEdit.Text = file.getText();
            }
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
    }
}
