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

namespace DCodeReader {

    public partial class MainForm : Form {

        DCodePreferences prefs;

        // Static variables
        private static int EMPTY = 100, ALSAVED = 101, NONSAVED = 102;

        // Private variables
        private int programState = EMPTY;

        // Form action
        public MainForm() {
            InitializeComponent();
            prefs = new DCodePreferences(new DCodeFile(GlobalValues.prefsPath));
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            //finish();
        }

        // Component action
        private void Content_TextChanged(object sender, EventArgs e) {

        }

        // Methods

        public void SaveAs() {
            /*Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();

            // Set filter for file extension and default file extension 
            dlg.DefaultExt = ".DCode";
            dlg.Filter = "DCode file (*.DCode)|*.DCode|Text file (*.txt)|*.txt";


            // Display OpenFileDialog by calling ShowDialog method 
            Nullable<bool> result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result == true) {
                // Open document 
                string filename = dlg.FileName;
                Local.Text = filename;
                Save();
            }
            //setFileContent(new DCode().criptografar(Texto.Text, int.Parse(Code.Text)), Local.Text);
            //Open();*/
        }

        private void finish() {
            if (programState == EMPTY) {
                this.Close();
            } else
            if (programState == ALSAVED) {

            } else
            if (programState == NONSAVED) {

            }
        }

        // Menu click

        // Arquivo
        private void Manu_abrir_Click(object sender, EventArgs e) {
            MessageBox.Show("Abrir");
        }

        private void Manu_salvar_Click(object sender, EventArgs e) {
            MessageBox.Show("Salvar");
        }

        private void Menu_salvarComo_Click(object sender, EventArgs e) {
            MessageBox.Show("Salvar como");
        }

        private void Manu_apagar_Click(object sender, EventArgs e) {
            MessageBox.Show("Apagar");
        }

        private void Manu_detalhes_Click(object sender, EventArgs e) {
            MessageBox.Show("Detalhes");
        }

        private void Menu_Settings_Click(object sender, EventArgs e) {
            MessageBox.Show("Configurações");
        }

        private void Menu_exit_Click(object sender, EventArgs e) {
            finish();
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

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            finish();
        }

    }
}
