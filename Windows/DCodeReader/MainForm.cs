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
using System.IO;

namespace DCodeReader {

    public partial class MainForm : Form {
        // Static methods
        public static int x, y, width, height;

        //private System.Windows.Threading.DispatcherTimer tempoTimer = new System.Windows.Threading.DispatcherTimer();
        //private static DCodePreferences prefs = new DCodePreferences(new DCodeFile(GlobalValues.prefsPath));
        private System.Windows.Forms.Timer backTast;
        private DCodeFile file;

        // Forms
        //private static SettingsForm sett = new SettingsForm(prefs);

        // Static variables
        private static int EMPTY = 100, ALSAVED = 101, NONSAVED = 102;

        // Private variables
        private int programState = EMPTY;

        // Theme
        private void InitTheme() {
            int _programState = programState;
            MenuMain.BackColor = Styles.getTheme().getMenuBack();
            MenuMain.ForeColor = Styles.getTheme().getMenuFore();
            Content.BackColor = Styles.getTheme().getBackGround();
            Content.ForeColor = Styles.getTheme().getForeGround();
            lineNumber_panel.BackColor = Styles.getTheme().getBackGround();
            lineNumber_label.ForeColor = Styles.getTheme().getForeGround();
            tableLayoutPanel.BackColor = Styles.getTheme().getLineNumberSeparator();
            this.setProgramStatus(_programState);
        }

        private void InitBorder() {
            int border = Program.prefs.GetInt("Border", 0);
            switch (border) {
                case 0:
                    Control_Menu.Visible = false;
                    this.Padding = new Padding(0);
                    this.FormBorderStyle = FormBorderStyle.Sizable;
                    break;
                case 1:
                    Control_Menu.Visible = true;
                    this.Padding = new Padding(2);
                    this.FormBorderStyle = FormBorderStyle.None;
                    break;
            }
        }

        // Form action
        private void Constructor() {
            InitializeComponent();
            OpenFileDialogMain.DefaultExt = GlobalValues.DefaultExt;
            OpenFileDialogMain.Filter = GlobalValues.Filter;
            SaveFileDialogMain.DefaultExt = GlobalValues.DefaultExt;
            SaveFileDialogMain.Filter = GlobalValues.Filter;
            InitTheme();
            InitBorder();
        }

        public MainForm() {
            Constructor();
        }

        public MainForm(String fileDir) {
            Constructor();
            openFile(fileDir);
        }

        private void MainForm_Load(object sender, EventArgs e) {
            int x = Program.prefs.GetInt("Location.x"), y = Program.prefs.GetInt("Location.y");
            if (x > -1 && y > -1) {
                this.Location = new Point(x, y);
            }

            InitPrefs();

            this.backTast = new System.Windows.Forms.Timer();
            this.backTast.Tick += new EventHandler(this.backTasking);
            this.backTast.Interval = 100;
            this.backTast.Start();
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

        private void InitPrefs() {
            lineNumber_panel.Visible = Program.prefs.GetBool("lineNumber");
            lineNumber_editar_menu.Checked = Program.prefs.GetBool("lineNumber");
        }

        // Component action
        private void Content_TextChanged(object sender, EventArgs e) {
            this.setProgramStatus(NONSAVED);
            this.updateLineNumber = true;
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

        private void openFile() {
            openFile("");
        }

        private void openFile(String fileDir) {
            if (fileDir.Equals("")) {
                OpenFileDialogMain.FileName = "";
                OpenFileDialogMain.ShowDialog();
            } else
                OpenFileDialogMain.FileName = fileDir;
            if (OpenFileDialogMain.FileName != "") {
                file = new DCodeFile(OpenFileDialogMain.FileName);

                if (file.getStatusKey() == DCodeFile.ALRIGHT) {
                    this.setProgramStatus(ALSAVED);
                    Content.Text = file.getText();
                    this.setProgramStatus(ALSAVED);
                } else {
                    MessageBox.Show("Arquivo corrompido, ou com versão incompatível do encoder", "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.setProgramStatus(EMPTY);
                    this.Text = GlobalValues.AppName + " - Error Load";
                }
            }
        }

        // Methods

        private bool saveFileDialog() {
            SaveFileDialogMain.ShowDialog();
            if (SaveFileDialogMain.FileName != "") {
                file = new DCodeFile(SaveFileDialogMain.FileName);
                new DCodeFileProps(file).ShowDialog();
                if (file.getStatusKey() == DCodeFile.ALRIGHT) {
                    file.setText(Content.Text);
                    this.setProgramStatus(ALSAVED);
                    return true;
                } else
                    Menu_novo_Click(null, null);
            }
            return false;
        }

        private bool changeDialogShowing = false;
        private bool updateLineNumber = false;

        private void backTasking(object sender, EventArgs e) {
            if (updateLineNumber) {
                updateLineNumber = false;
                int length = DCode.countNum(Content.Text, '\n') + 1;
                lineNumber_label.Text = "0";
                lineNumber_label.Text += length > 10 ? "0": "";
                lineNumber_label.Text += length > 100 ? "00" : "";
                lineNumber_label.Text += "\n";
                for (int i = 1; i < length; i++) {
                    lineNumber_label.Text += length > 10 && i < 10 ? "0" : "";
                    lineNumber_label.Text += length > 100 && i < 100 ? "00" : "";
                    lineNumber_label.Text += i + "\n";
                    //if (length >= 10 && i < 10)
                    //    lineNumber_label.Text += "0" + i + "\n";
                    //else
                    //    lineNumber_label.Text += i + "\n";
                }
            }
            if (file == null) return;
            if (!file.exists()) return;
            if (programState.Equals(ALSAVED)) {
                if (!file.getText().Equals(Content.Text) && changeDialogShowing == false) {
                    changeDialogShowing = true;
                    if (MessageBox.Show("Outro programa fez alterações nesse arquivo.\nAtualizar editor?", "Arquivo alterado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes) {
                        Content.Text = file.getText();
                        this.setProgramStatus(ALSAVED);
                        changeDialogShowing = false;
                    }
                }
                this.Text = GlobalValues.AppName + " - " + file.getTitle();
            }
        }

        // Menu click

        // Arquivo
        private void Menu_novo_Click(object sender, EventArgs e) {
            this.setProgramStatus(EMPTY);
        }

        private void Manu_abrir_Click(object sender, EventArgs e) {
            openFile();
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
            new SettingsForm().ShowDialog();
            InitPrefs();
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
            //System.Diagnostics.Process.Start(@"D:\\Biblioteca\\Documentos\\Desktop\\C++\\MyServer\\MyServer.exe");
            MessageBox.Show("Sobre");
        }

        // Getters and Setters

        private void setProgramStatus(int state) {
            this.programState = state;
            if (state == EMPTY) {
                OpenFileDialogMain.FileName = "";
                SaveFileDialogMain.FileName = "";
                Content.Text = "";
                file = null;
                this.Text = GlobalValues.AppName;
                this.programState = EMPTY;
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

        private void keyDown(object sender, KeyEventArgs e) {
            if (e.Modifiers == Keys.Control) {
                if (e.KeyCode == Keys.S) {
                    saveFile();
                } else
                if (e.KeyCode == Keys.O) {
                    openFile();
                } else
                if (e.KeyCode == Keys.N) {
                    setProgramStatus(EMPTY);
                } else
                if (e.KeyCode == Keys.L) {
                    Program.prefs.Set("lineNumber", !Program.prefs.GetBool("lineNumber"));
                    InitPrefs();
                }
            } else
            if (e.KeyCode == Keys.F1) {
                Menu_help_Click(sender, e);
            }
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

        private void menu_DropDownClosed(object sender, EventArgs e) {
            ((ToolStripMenuItem) sender).ForeColor = Color.FromArgb(0xffffff);
        }

        private void menu_DropDownOpened(object sender, EventArgs e) {
            ((ToolStripMenuItem) sender).ForeColor = Color.FromArgb(0x000000);
        }

        private void close_control_menu_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void minimize_control_menu_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximize_control_menu_Click(object sender, EventArgs e) {
            if(this.WindowState.Equals(FormWindowState.Normal))
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        // Style Menu

        private void light_theme_style_menu_Click(object sender, EventArgs e) {
            Styles.currentTheme = 0;
            InitTheme();
        }

        private void dark_theme_style_menu_Click(object sender, EventArgs e) {
            Styles.currentTheme = 1;
            InitTheme();
        }

        private void windows_border_style_menu_Click(object sender, EventArgs e) {
            Program.prefs.Set("Border", 0);
            InitBorder();
        }

        private void custom_border_style_menu_Click(object sender, EventArgs e) {
            Program.prefs.Set("Border", 1);
            InitBorder();
        }

        private void lineNumber_editar_menu_Click(object sender, EventArgs e) {
            Program.prefs.Set("lineNumber", lineNumber_editar_menu.Checked);
            InitPrefs();
        }
    }
}
