namespace DCodeReader {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.MenuMain = new System.Windows.Forms.MenuStrip();
            this.gfdfgfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_novo = new System.Windows.Forms.ToolStripMenuItem();
            this.Manu_abrir = new System.Windows.Forms.ToolStripMenuItem();
            this.Manu_salvar = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_salvarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.Manu_apagar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Manu_detalhes = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.fgdgdfgdfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_undo = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_endo = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_help = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_sobre = new System.Windows.Forms.ToolStripMenuItem();
            this.Content = new System.Windows.Forms.RichTextBox();
            this.OpenFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialogMain = new System.Windows.Forms.SaveFileDialog();
            this.MenuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuMain
            // 
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gfdfgfgToolStripMenuItem,
            this.fgdgdfgdfgToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.MenuMain.Location = new System.Drawing.Point(0, 0);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(681, 24);
            this.MenuMain.TabIndex = 1;
            this.MenuMain.Text = "MenuMain";
            // 
            // gfdfgfgToolStripMenuItem
            // 
            this.gfdfgfgToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_novo,
            this.Manu_abrir,
            this.Manu_salvar,
            this.Menu_salvarComo,
            this.Manu_apagar,
            this.toolStripSeparator2,
            this.Manu_detalhes,
            this.Menu_Settings,
            this.toolStripSeparator1,
            this.Menu_exit});
            this.gfdfgfgToolStripMenuItem.Name = "gfdfgfgToolStripMenuItem";
            this.gfdfgfgToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.gfdfgfgToolStripMenuItem.Text = "Arquivo";
            // 
            // Menu_novo
            // 
            this.Menu_novo.Name = "Menu_novo";
            this.Menu_novo.Size = new System.Drawing.Size(151, 22);
            this.Menu_novo.Text = "Novo";
            this.Menu_novo.Click += new System.EventHandler(this.Menu_novo_Click);
            // 
            // Manu_abrir
            // 
            this.Manu_abrir.Name = "Manu_abrir";
            this.Manu_abrir.Size = new System.Drawing.Size(151, 22);
            this.Manu_abrir.Text = "Abrir";
            this.Manu_abrir.Click += new System.EventHandler(this.Manu_abrir_Click);
            // 
            // Manu_salvar
            // 
            this.Manu_salvar.Name = "Manu_salvar";
            this.Manu_salvar.Size = new System.Drawing.Size(151, 22);
            this.Manu_salvar.Text = "Salvar";
            this.Manu_salvar.Click += new System.EventHandler(this.Manu_salvar_Click);
            // 
            // Menu_salvarComo
            // 
            this.Menu_salvarComo.Name = "Menu_salvarComo";
            this.Menu_salvarComo.Size = new System.Drawing.Size(151, 22);
            this.Menu_salvarComo.Text = "Salvar como";
            this.Menu_salvarComo.Click += new System.EventHandler(this.Menu_salvarComo_Click);
            // 
            // Manu_apagar
            // 
            this.Manu_apagar.Name = "Manu_apagar";
            this.Manu_apagar.Size = new System.Drawing.Size(151, 22);
            this.Manu_apagar.Text = "Apagar";
            this.Manu_apagar.Click += new System.EventHandler(this.Manu_apagar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(148, 6);
            // 
            // Manu_detalhes
            // 
            this.Manu_detalhes.Name = "Manu_detalhes";
            this.Manu_detalhes.Size = new System.Drawing.Size(151, 22);
            this.Manu_detalhes.Text = "Detalhes";
            this.Manu_detalhes.Click += new System.EventHandler(this.Manu_detalhes_Click);
            // 
            // Menu_Settings
            // 
            this.Menu_Settings.Name = "Menu_Settings";
            this.Menu_Settings.Size = new System.Drawing.Size(151, 22);
            this.Menu_Settings.Text = "Configurações";
            this.Menu_Settings.Click += new System.EventHandler(this.Menu_Settings_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // Menu_exit
            // 
            this.Menu_exit.Name = "Menu_exit";
            this.Menu_exit.Size = new System.Drawing.Size(151, 22);
            this.Menu_exit.Text = "Sair";
            this.Menu_exit.Click += new System.EventHandler(this.Menu_exit_Click);
            // 
            // fgdgdfgdfgToolStripMenuItem
            // 
            this.fgdgdfgdfgToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_undo,
            this.Menu_endo});
            this.fgdgdfgdfgToolStripMenuItem.Name = "fgdgdfgdfgToolStripMenuItem";
            this.fgdgdfgdfgToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.fgdgdfgdfgToolStripMenuItem.Text = "Editar";
            // 
            // Menu_undo
            // 
            this.Menu_undo.Name = "Menu_undo";
            this.Menu_undo.Size = new System.Drawing.Size(103, 22);
            this.Menu_undo.Text = "Undo";
            this.Menu_undo.Click += new System.EventHandler(this.Menu_undo_Click);
            // 
            // Menu_endo
            // 
            this.Menu_endo.Name = "Menu_endo";
            this.Menu_endo.Size = new System.Drawing.Size(103, 22);
            this.Menu_endo.Text = "Endo";
            this.Menu_endo.Click += new System.EventHandler(this.Menu_endo_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_help,
            this.toolStripSeparator3,
            this.Menu_sobre});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // Menu_help
            // 
            this.Menu_help.Name = "Menu_help";
            this.Menu_help.Size = new System.Drawing.Size(128, 22);
            this.Menu_help.Text = "Ajuda [F1]";
            this.Menu_help.Click += new System.EventHandler(this.Menu_help_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(125, 6);
            // 
            // Menu_sobre
            // 
            this.Menu_sobre.Name = "Menu_sobre";
            this.Menu_sobre.Size = new System.Drawing.Size(128, 22);
            this.Menu_sobre.Text = "Sobre";
            this.Menu_sobre.Click += new System.EventHandler(this.Menu_sobre_Click);
            // 
            // Content
            // 
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Content.Location = new System.Drawing.Point(0, 24);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(681, 416);
            this.Content.TabIndex = 2;
            this.Content.Text = "";
            this.Content.WordWrap = false;
            this.Content.TextChanged += new System.EventHandler(this.Content_TextChanged);
            this.Content.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 440);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.MenuMain);
            this.MainMenuStrip = this.MenuMain;
            this.Name = "MainForm";
            this.Text = "DCode Reader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.MenuMain.ResumeLayout(false);
            this.MenuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuMain;
        private System.Windows.Forms.ToolStripMenuItem gfdfgfgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Manu_abrir;
        private System.Windows.Forms.ToolStripMenuItem fgdgdfgdfgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Manu_salvar;
        private System.Windows.Forms.ToolStripMenuItem Menu_salvarComo;
        private System.Windows.Forms.ToolStripMenuItem Manu_apagar;
        private System.Windows.Forms.ToolStripMenuItem Manu_detalhes;
        private System.Windows.Forms.ToolStripMenuItem Menu_Settings;
        private System.Windows.Forms.ToolStripMenuItem Menu_undo;
        private System.Windows.Forms.ToolStripMenuItem Menu_endo;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_help;
        private System.Windows.Forms.ToolStripMenuItem Menu_sobre;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Menu_exit;
        private System.Windows.Forms.RichTextBox Content;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogMain;
        private System.Windows.Forms.SaveFileDialog SaveFileDialogMain;
        private System.Windows.Forms.ToolStripMenuItem Menu_novo;
    }
}

