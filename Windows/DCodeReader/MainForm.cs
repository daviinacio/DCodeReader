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
        private System.Windows.Forms.Timer backTast2;
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
            editor_panel.BackColor = Content.BackColor = Styles.getTheme().getBackGround();
            this.setProgramStatus(_programState);
            updateHighLight = true;
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

        private void UpdateHighLight() {
            if (Program.prefs.GetBool("highLight")) {
                Content.HighlightText("public ", Color.Blue);
                //Content.HighlightText("static ", Color.Blue);
                //Content.HighlightText("void ", Color.Blue);
                Content.HighlightText('[', Color.LawnGreen);
                Content.HighlightText(':', Color.LemonChiffon);
                Content.HighlightText(']', Color.LawnGreen);

                Content.HighlightText('(', Color.Gold);
                Content.HighlightText('/', Color.Orange);
                Content.HighlightText(')', Color.Gold);

                Content.HighlightText('{', Color.Crimson);
                Content.HighlightText('_', Color.Red);
                Content.HighlightText('}', Color.Crimson);

                Content.HighlightText('<', Color.Cyan);
                Content.HighlightText(';', Color.LightSeaGreen);
                Content.HighlightText('>', Color.Cyan);

                Color hexColor = Color.GreenYellow;
                Content.HighlightText("#0", hexColor);
                Content.HighlightText("#1", hexColor);
                Content.HighlightText("#2", hexColor);
                Content.HighlightText("#3", hexColor);
                Content.HighlightText("#4", hexColor);
                Content.HighlightText("#5", hexColor);
                Content.HighlightText("#6", hexColor);
                Content.HighlightText("#7", hexColor);
                Content.HighlightText("#8", hexColor);
                Content.HighlightText("#9", hexColor);
                Content.HighlightText("#a", hexColor);
                Content.HighlightText("#b", hexColor);
                Content.HighlightText("#c", hexColor);
                Content.HighlightText("#d", hexColor);
                Content.HighlightText("#e", hexColor);
                Content.HighlightText("#f", hexColor);
                Content.HighlightText("#A", hexColor);
                Content.HighlightText("#B", hexColor);
                Content.HighlightText("#C", hexColor);
                Content.HighlightText("#D", hexColor);
                Content.HighlightText("#E", hexColor);
                Content.HighlightText("#F", hexColor);
            } else
                if(Content.ForeColor != Styles.getTheme().getForeGround() || true)
                    InitTheme();
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
            //Content.Controls.Add(hScrollBar);
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

            //editor_panel.AutoScroll = true;

            this.backTast = new System.Windows.Forms.Timer();
            this.backTast.Tick += new EventHandler(this.backTasking);
            this.backTast.Interval = 10;
            this.backTast.Start();

            this.backTast2 = new System.Windows.Forms.Timer();
            this.backTast2.Tick += new EventHandler(this.backTasking2);
            this.backTast2.Interval = 100;
            this.backTast2.Start();
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
            highLight_editar_menu.Checked = Program.prefs.GetBool("highLight");
        }

        Keys currentKey = Keys.Clear;

        // Component action
        private void Content_TextChanged(object sender, EventArgs e) {
            //if(!updateHighLight)
                updateHighLight = true;
            //Content.ScrollToCaret();
            this.setProgramStatus(NONSAVED);
            this.updateLineNumber = true;
            this.upadteContentPosition = true;
            //this.updateContentHeight = true;
            //MessageBox.Show("c");
            //int pos = Content.SelectionStart;
            /*if(Content.Text.ToCharArray()[pos - 1].Equals('\n')){
                //MessageBox.Show("Enter");
                //Content.SelectionStart = 0;
                //Content.SelectionStart = pos;
            }*/
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
            this.updateLineNumber = true;
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
        private bool upadteContentPosition = false;
        private bool updateContentHeight = false;

        private void backTasking(object sender, EventArgs e) {
            if (updateLineNumber) {
                updateLineNumber = false;
                String lineText = "";
                int length = DCode.countNum(Content.Text, '\n') + 1;
                for (int i = 0; i < length; i++) {
                    lineText += length >= 10 && (i + 1) < 10 ? "0" : "";
                    lineText += length >= 100 && (i + 1) < 100 ? "0" : "";
                    lineText += length >= 1000 && (i + 1) < 1000 ? "0" : "";
                    lineText += (i + 1) + "\n";
                }
                lineNumber_label.Text = lineText;
            }

            if (upadteContentPosition) {
                upadteContentPosition = false;
                int pos = Content.SelectionStart;
                Content.SelectionStart = 0;
                Content.SelectionStart = pos;
            }

            if (updateContentHeight) {
                updateContentHeight = false;
                //tableLayoutPanel.Height = DCode.countNum(Content.Text, '\n') * 19;
            }
            
        }

        
        private bool updateHighLight = false;

        private void backTasking2(object sender, EventArgs e) {
            //UpdateHighLight();
            if (updateHighLight && Program.prefs.GetBool("highLight")) {
                updateHighLight = false;
                int pos = Content.SelectionStart;
                String text = Content.Text;
                Content.Text = "";
                Content.Text = text;
                Content.SelectionStart = pos;
                UpdateHighLight();
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
            Content.Text = unPackText(Content.Text);
            //MessageBox.Show("Undo");
        }

        private void Menu_endo_Click(object sender, EventArgs e) {
            Content.Text = packText(Content.Text);
            //MessageBox.Show("Endo");
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
            currentKey = e.KeyCode;
            // Ctrl
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
                } else
                if (e.KeyCode == Keys.H) {
                    Program.prefs.Set("highLight", !Program.prefs.GetBool("highLight"));
                    InitPrefs();
                } else
                if (e.KeyCode == Keys.Home) {
                    editor_panel.ScrollToTop();
                } else
                if (e.KeyCode == Keys.End) {
                    editor_panel.ScrollToBottom();
                }
            }
            else // Shift
            if(e.Modifiers == Keys.Shift){
                
            } else
            if (e.KeyCode == Keys.F1) {
                Menu_help_Click(sender, e);
            }
            // Scroll
            else
            if (e.KeyCode == Keys.PageUp) {
                editor_panel.ScrollUp(-(19 * 8));
            }else
            if (e.KeyCode == Keys.PageDown) {
                editor_panel.ScrollDown(19 * 8); 
            } else
            if (e.KeyCode == Keys.Enter) {
                //int pos = Content.SelectionStart;
                //Content.SelectionStart = 0;
                //Content.SelectionStart = pos;
            } else
            if (e.KeyCode == Keys.Tab) {
                //MessageBox.Show("Tab");
                //Content.AppendText("    ");
            }
                // Other keys
            else {
                Content.Focus();
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

        private void highLight_editar_menu_Click(object sender, EventArgs e) {
            Program.prefs.Set("highLight", highLight_editar_menu.Checked);
            InitPrefs();
        }

        //private int editorScroll = 200;

        private void editor_panel_Resize(object sender, EventArgs e) {
            //if(editor_panel.VerticalScroll.Visible)
                //editor_panel.VerticalScroll.Value = editorScroll;
        }

        // Functions

        /*public void ScrollDown(Panel p) {
            Control teste = new Control();
            teste.AutoScrollOffset = new S
            p.ScrollControlIntoView(teste);
            /*using (Control c = new Control() { Parent = p, Dock = DockStyle.Bottom }) {
                p.ScrollControlIntoView(c);
                c.Parent = null;
            }
        }*/

        private void mouseWheel(object sender, System.Windows.Forms.MouseEventArgs e) {
            // Update the drawing based upon the mouse wheel scrolling.

            int numberOfTextLinesToMove = e.Delta * SystemInformation.MouseWheelScrollLines / 120;
            //int numberOfPixelsToMove = numberOfTextLinesToMove;// *fontSize;
            int scroll = 19;

            if (numberOfTextLinesToMove > 0) { // UP
                editor_panel.ScrollUp(-scroll);
            } else
            if (numberOfTextLinesToMove < 0) { // DOWN
                editor_panel.ScrollDown(scroll);
            }

            /*if (numberOfPixelsToMove != 0) {
                System.Drawing.Drawing2D.Matrix translateMatrix = new System.Drawing.Drawing2D.Matrix();
                translateMatrix.Translate(0, numberOfPixelsToMove);
                //mousePath.Transform(translateMatrix);
            }*/
            //panel1.Invalidate();
        }

        private void insertContentText(String text) {
            Content.Text += text;
            updateHighLight = true;
        }

        private void Content_KeyPress(object sender, KeyPressEventArgs e) {
            RichTextBox tb = sender as RichTextBox;
            if (char.IsControl(e.KeyChar))
                e.Handled = true;
            /*if ((e.KeyChar == ',') && (tb.Text.IndexOf(',') > -1))
                e.Handled = true;*/
        }

        private void Content_KeyUp(object sender, KeyEventArgs e) {

        }

        private void data_inserir_menu_Click(object sender, EventArgs e) {
            insertContentText(new Datas().ToString());
        }

        private void hora_inserir_menu_Click(object sender, EventArgs e) {
            //MessageBox.Show("Horas");
            updateHighLight = true;
            //insertContentText(new Horas
        }

        // Content methods

        private String packText(String text) {
            DCode dcode = new DCode(DCode.getMode(text));
            String output = "";
            char [] _in = text.ToCharArray();
            String word = "";
            int opend = 0;

            int x = 0;
            for (int i = 0; i < _in.Length; i++) {

                if (_in [i] == new DCode(DCode.ARRAY).getOpen()) {
                    output += "\n   ";
                } else
                if (_in [i] == new DCode(DCode.ARRAY).getClose()) {

                }

                /*if (_in [i] == dcode.getOpen()) {
                    opend++;
                    if (opend > 1) word = word + _in [i];
                } else
                if (_in [i] == dcode.getSpace()) {
                    if (opend > 1) {
                        word = word + _in [i];
                        continue;
                    }
                    output += word;
                    x++;
                    word = "";
                } else
                if (_in [i] == dcode.getClose()) {
                    if (opend > 1) word = word + _in [i];
                    opend--;
                } else {
                    if (_in [i] == '\r' || opend < 1) continue;
                    word = word + _in [i];
                }*/
            }
            return output;
        }

        private String unPackText(String text) {
            String output = "";

            return output;
        }
    }
}
