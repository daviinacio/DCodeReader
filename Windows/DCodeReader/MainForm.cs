using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Threading;

namespace DCodeReader {

    public partial class MainForm : Form {
        // Static methods
        public static int x, y, width, height;

        //private System.Windows.Threading.DispatcherTimer tempoTimer = new System.Windows.Threading.DispatcherTimer();
        private static DCodePreferences prefs = new DCodePreferences(new DCodeFile(GlobalValues.prefsPath));
        private DCodeFile file;

        // Forms
        private static SettingsForm sett = new SettingsForm(prefs);

        // Static variables
        private static int EMPTY = 100, ALSAVED = 101, NONSAVED = 102;

        // Private variables
        private int programState = EMPTY;

        // Form action
        public MainForm() {
            InitializeComponent();
            OpenFileDialogMain.DefaultExt = GlobalValues.DefaultExt;
            OpenFileDialogMain.Filter = GlobalValues.Filter;
            SaveFileDialogMain.DefaultExt = GlobalValues.DefaultExt;
            SaveFileDialogMain.Filter = GlobalValues.Filter;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            if (programState == EMPTY) {
                Application.Exit();
            } else
            if (programState == ALSAVED) {
                if (MessageBox.Show("Se você clicar em 'sim' o programa será fechado.", "Fechar",
                    MessageBoxButtons.YesNo) == DialogResult.No) {
                    // Cancel the Closing event from closing the form.
                    e.Cancel = true;
                    // Call method to save file...
                }
            } else
            if (programState == NONSAVED) {
                DialogResult m = MessageBox.Show("Suas alterações não estão salvas, deseja salvar-las?", "Fechar", MessageBoxButtons.YesNoCancel);
                if (m == DialogResult.Yes) {
                    if (!saveFile()) { //  Arquivo não salvo
                        MessageBox.Show("Erro ao salvar o arquivo");
                        e.Cancel = true;
                    }
                } else
                if (m == DialogResult.No) {

                } else
                if (m == DialogResult.Cancel) {
                    e.Cancel = true;
                }
            }

        }

        // Component action
        private void Content_TextChanged(object sender, EventArgs e) {
            this.setProgramStatus(NONSAVED);
        }

        // Loaders methods

        private bool saveFile() {
            if (file != null) {
                this.setProgramStatus(ALSAVED);
                file.setText(Content.Text);
                return true;
            } else {
                return saveFileDialog();
            }
            //return false;
        }

        // Methods

        private bool saveFileDialog() {
            SaveFileDialogMain.ShowDialog();
            if (SaveFileDialogMain.FileName != "") {
                file = new DCodeFile(SaveFileDialogMain.FileName);

                if (file.getStatusKey() == DCodeFile.ALRIGHT ||
                    file.getStatusKey() == DCodeFile.EMPTY) {
                    new DCodeFileProps(file).ShowDialog();
                    file.setText(Content.Text);
                    this.setProgramStatus(ALSAVED);
                    return true;
                }
            }
            return false;
        }

        // Menu click

        // Arquivo
        private void Menu_novo_Click(object sender, EventArgs e) {
            this.setProgramStatus(EMPTY);
        }

        private void Manu_abrir_Click(object sender, EventArgs e) {
            OpenFileDialogMain.FileName = "";
            OpenFileDialogMain.ShowDialog();
            if (OpenFileDialogMain.FileName != "") {
                file = new DCodeFile(OpenFileDialogMain.FileName);

                if (file.getStatusKey() == DCodeFile.ALRIGHT) {
                    this.setProgramStatus(ALSAVED);
                    Content.Text = file.getText();
                } else {
                    MessageBox.Show("Arquivo corrompido, ou com versão incompatível do encoder", "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.setProgramStatus(EMPTY);
                    this.Text = GlobalValues.AppName + " - Error Load";
                }
            }
        }

        private void Manu_salvar_Click(object sender, EventArgs e) {
            saveFile();
        }

        private void Menu_salvarComo_Click(object sender, EventArgs e) {
            saveFileDialog();
        }

        private void Manu_apagar_Click(object sender, EventArgs e) {
            if (file != null) {
                if (MessageBox.Show("Esse arquivo será apagado.", "Apagar", 
                    MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    file.delete();
                    this.setProgramStatus(EMPTY);
                    //Menu_novo.Select();
                }
            } else {
                MessageBox.Show("Nenhum arquivo aberto\nClique em arquivo/abrir e selecione um arquivo.", "Apagar");
            }
        }

        private void Manu_detalhes_Click(object sender, EventArgs e) {
            if (file != null) {
                new DCodeFileProps(file).ShowDialog();
            } else {
                MessageBox.Show("Nenhum arquivo aberto\nClique em arquivo/abrir e selecione um arquivo.", "Detalhes");
            }
        }

        private void Menu_Settings_Click(object sender, EventArgs e) {
            sett.ShowDialog();
        }

        private void Menu_exit_Click(object sender, EventArgs e) {
            this.Close();
        }

        // Editar
        private void Menu_undo_Click(object sender, EventArgs e) {
            MessageBox.Show("Undo");
        }

        private void Menu_endo_Click(object sender, EventArgs e) {
            MessageBox.Show("Endo");
        }

        // Ajuda
        private void Menu_help_Click(object sender, EventArgs e) {
            MessageBox.Show("Ajuda");
        }

        private void Menu_sobre_Click(object sender, EventArgs e) {
            MessageBox.Show("Sobre");
        }

        // Getters and Setters

        private void setProgramStatus(int state) {
            this.programState = state;
            if (state == EMPTY) {
                this.Text = GlobalValues.AppName;
                OpenFileDialogMain.FileName = "";
                SaveFileDialogMain.FileName = "";
                Content.Text = "";
                file = null;
            } else
            if (state == ALSAVED) {
                if (file != null) {
                    this.Text = GlobalValues.AppName + " - " + file.getTitle();
                }
            } else
            if (state == NONSAVED) {
                if (file != null) {
                    this.Text = GlobalValues.AppName + " - " + file.getTitle() + "*";
                }
            }
        }

        private bool controlPresses = false;

        private void keyDown(KeyEventArgs e) {
            //MessageBox.Show(e.KeyCode +  "");
            if (e.KeyCode.ToString() == "ControlKey")
                controlPresses = true;
            if(controlPresses)
                MessageBox.Show("Ctrl + " + e.ToString());
        }

        private void keyUp(KeyEventArgs e) {
            if (e.KeyCode.ToString() == "ControlKey")
                controlPresses = false;
            //MessageBox.Show(e.KeyCode + "");
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e) {
            keyDown(e);
        }

        private void Content_KeyDown(object sender, KeyEventArgs e) {
            keyDown(e);
        }

        private void Content_KeyUp(object sender, KeyEventArgs e) {
            keyUp(e);
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e) {
            keyUp(e);
        }

        /*public int getX() {
            return this.Location.X;
        }

        public int getY() {
            return this.Location.Y;
        }

        public int getWidth() {
            return this.Width;
        }

        public int getHeight() {
            return this.Height;
        }*/
    }
}
