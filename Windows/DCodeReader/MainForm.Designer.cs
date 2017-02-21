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
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.OpenFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialogMain = new System.Windows.Forms.SaveFileDialog();
            this.Content = new System.Windows.Forms.RichTextBox();
            this.icon_control_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.icon_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Control_Menu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dCodeReaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.close_control_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.minimize_control_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.maximize_control_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMain.SuspendLayout();
            this.Control_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuMain
            // 
            this.MenuMain.BackColor = System.Drawing.Color.MediumAquamarine;
            this.MenuMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gfdfgfgToolStripMenuItem,
            this.fgdgdfgdfgToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.MenuMain.Location = new System.Drawing.Point(2, 27);
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.Size = new System.Drawing.Size(657, 25);
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
            this.gfdfgfgToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.gfdfgfgToolStripMenuItem.Name = "gfdfgfgToolStripMenuItem";
            this.gfdfgfgToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.gfdfgfgToolStripMenuItem.Text = "Arquivo";
            this.gfdfgfgToolStripMenuItem.DropDownClosed += new System.EventHandler(this.menu_DropDownClosed);
            this.gfdfgfgToolStripMenuItem.DropDownOpened += new System.EventHandler(this.menu_DropDownOpened);
            // 
            // Menu_novo
            // 
            this.Menu_novo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_novo.Name = "Menu_novo";
            this.Menu_novo.Size = new System.Drawing.Size(160, 22);
            this.Menu_novo.Text = "Novo";
            this.Menu_novo.Click += new System.EventHandler(this.Menu_novo_Click);
            // 
            // Manu_abrir
            // 
            this.Manu_abrir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manu_abrir.Name = "Manu_abrir";
            this.Manu_abrir.Size = new System.Drawing.Size(160, 22);
            this.Manu_abrir.Text = "Abrir";
            this.Manu_abrir.Click += new System.EventHandler(this.Manu_abrir_Click);
            // 
            // Manu_salvar
            // 
            this.Manu_salvar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manu_salvar.Name = "Manu_salvar";
            this.Manu_salvar.Size = new System.Drawing.Size(160, 22);
            this.Manu_salvar.Text = "Salvar";
            this.Manu_salvar.Click += new System.EventHandler(this.Manu_salvar_Click);
            // 
            // Menu_salvarComo
            // 
            this.Menu_salvarComo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_salvarComo.Name = "Menu_salvarComo";
            this.Menu_salvarComo.Size = new System.Drawing.Size(160, 22);
            this.Menu_salvarComo.Text = "Salvar como";
            this.Menu_salvarComo.Click += new System.EventHandler(this.Menu_salvarComo_Click);
            // 
            // Manu_apagar
            // 
            this.Manu_apagar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manu_apagar.Name = "Manu_apagar";
            this.Manu_apagar.Size = new System.Drawing.Size(160, 22);
            this.Manu_apagar.Text = "Apagar";
            this.Manu_apagar.Click += new System.EventHandler(this.Manu_apagar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // Manu_detalhes
            // 
            this.Manu_detalhes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manu_detalhes.Name = "Manu_detalhes";
            this.Manu_detalhes.Size = new System.Drawing.Size(160, 22);
            this.Manu_detalhes.Text = "Detalhes";
            this.Manu_detalhes.Click += new System.EventHandler(this.Manu_detalhes_Click);
            // 
            // Menu_Settings
            // 
            this.Menu_Settings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Settings.Name = "Menu_Settings";
            this.Menu_Settings.Size = new System.Drawing.Size(160, 22);
            this.Menu_Settings.Text = "Configurações";
            this.Menu_Settings.Click += new System.EventHandler(this.Menu_Settings_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(157, 6);
            // 
            // Menu_exit
            // 
            this.Menu_exit.BackColor = System.Drawing.Color.Salmon;
            this.Menu_exit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_exit.ForeColor = System.Drawing.SystemColors.Window;
            this.Menu_exit.Name = "Menu_exit";
            this.Menu_exit.Size = new System.Drawing.Size(160, 22);
            this.Menu_exit.Text = "Sair";
            this.Menu_exit.Click += new System.EventHandler(this.Menu_exit_Click);
            // 
            // fgdgdfgdfgToolStripMenuItem
            // 
            this.fgdgdfgdfgToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_undo,
            this.Menu_endo});
            this.fgdgdfgdfgToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.fgdgdfgdfgToolStripMenuItem.Name = "fgdgdfgdfgToolStripMenuItem";
            this.fgdgdfgdfgToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.fgdgdfgdfgToolStripMenuItem.Text = "Editar";
            this.fgdgdfgdfgToolStripMenuItem.DropDownClosed += new System.EventHandler(this.menu_DropDownClosed);
            this.fgdgdfgdfgToolStripMenuItem.DropDownOpened += new System.EventHandler(this.menu_DropDownOpened);
            // 
            // Menu_undo
            // 
            this.Menu_undo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_undo.Name = "Menu_undo";
            this.Menu_undo.Size = new System.Drawing.Size(188, 22);
            this.Menu_undo.Text = "Undo [Ctrl+Z]";
            this.Menu_undo.Click += new System.EventHandler(this.Menu_undo_Click);
            // 
            // Menu_endo
            // 
            this.Menu_endo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_endo.Name = "Menu_endo";
            this.Menu_endo.Size = new System.Drawing.Size(188, 22);
            this.Menu_endo.Text = "Endo [Ctrl+Shift+Z]";
            this.Menu_endo.Click += new System.EventHandler(this.Menu_endo_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_help,
            this.toolStripSeparator3,
            this.Menu_sobre});
            this.ajudaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.DropDownClosed += new System.EventHandler(this.menu_DropDownClosed);
            this.ajudaToolStripMenuItem.DropDownOpened += new System.EventHandler(this.menu_DropDownOpened);
            // 
            // Menu_help
            // 
            this.Menu_help.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_help.Name = "Menu_help";
            this.Menu_help.Size = new System.Drawing.Size(134, 22);
            this.Menu_help.Text = "Ajuda [F1]";
            this.Menu_help.Click += new System.EventHandler(this.Menu_help_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(131, 6);
            // 
            // Menu_sobre
            // 
            this.Menu_sobre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_sobre.Name = "Menu_sobre";
            this.Menu_sobre.Size = new System.Drawing.Size(134, 22);
            this.Menu_sobre.Text = "Sobre";
            this.Menu_sobre.Click += new System.EventHandler(this.Menu_sobre_Click);
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.SystemColors.Control;
            this.Content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Content.Location = new System.Drawing.Point(2, 52);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(657, 347);
            this.Content.TabIndex = 2;
            this.Content.Text = "";
            // 
            // icon_control_menu
            // 
            this.icon_control_menu.Name = "icon_control_menu";
            this.icon_control_menu.Size = new System.Drawing.Size(22, 20);
            this.icon_control_menu.Text = " ";
            // 
            // icon_menu
            // 
            this.icon_menu.Name = "icon_menu";
            this.icon_menu.Size = new System.Drawing.Size(22, 20);
            this.icon_menu.Text = " ";
            // 
            // Control_Menu
            // 
            this.Control_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.dCodeReaderToolStripMenuItem,
            this.close_control_menu,
            this.maximize_control_menu,
            this.minimize_control_menu});
            this.Control_Menu.Location = new System.Drawing.Point(2, 2);
            this.Control_Menu.Name = "Control_Menu";
            this.Control_Menu.Padding = new System.Windows.Forms.Padding(0, 2, 2, 2);
            this.Control_Menu.Size = new System.Drawing.Size(657, 25);
            this.Control_Menu.TabIndex = 5;
            this.Control_Menu.Text = "controls";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 21);
            // 
            // dCodeReaderToolStripMenuItem
            // 
            this.dCodeReaderToolStripMenuItem.Name = "dCodeReaderToolStripMenuItem";
            this.dCodeReaderToolStripMenuItem.Size = new System.Drawing.Size(94, 21);
            this.dCodeReaderToolStripMenuItem.Text = "DCode Reader";
            // 
            // close_control_menu
            // 
            this.close_control_menu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.close_control_menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_control_menu.Name = "close_control_menu";
            this.close_control_menu.Size = new System.Drawing.Size(27, 21);
            this.close_control_menu.Text = "x";
            this.close_control_menu.Click += new System.EventHandler(this.close_control_menu_Click);
            // 
            // minimize_control_menu
            // 
            this.minimize_control_menu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.minimize_control_menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_control_menu.Name = "minimize_control_menu";
            this.minimize_control_menu.Size = new System.Drawing.Size(25, 21);
            this.minimize_control_menu.Text = "_";
            this.minimize_control_menu.Click += new System.EventHandler(this.minimize_control_menu_Click);
            // 
            // maximize_control_menu
            // 
            this.maximize_control_menu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.maximize_control_menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximize_control_menu.Image = ((System.Drawing.Image)(resources.GetObject("maximize_control_menu.Image")));
            this.maximize_control_menu.Name = "maximize_control_menu";
            this.maximize_control_menu.Size = new System.Drawing.Size(28, 21);
            this.maximize_control_menu.Click += new System.EventHandler(this.maximize_control_menu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(661, 401);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.MenuMain);
            this.Controls.Add(this.Control_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuMain;
            this.MinimumSize = new System.Drawing.Size(506, 332);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Text = "DCode Reader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.MenuMain.ResumeLayout(false);
            this.MenuMain.PerformLayout();
            this.Control_Menu.ResumeLayout(false);
            this.Control_Menu.PerformLayout();
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogMain;
        private System.Windows.Forms.SaveFileDialog SaveFileDialogMain;
        private System.Windows.Forms.ToolStripMenuItem Menu_novo;
        private System.Windows.Forms.ToolStripMenuItem icon_control_menu;
        private System.Windows.Forms.ToolStripMenuItem icon_menu;
        private System.Windows.Forms.RichTextBox Content;
        private System.Windows.Forms.MenuStrip Control_Menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dCodeReaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem close_control_menu;
        private System.Windows.Forms.ToolStripMenuItem minimize_control_menu;
        private System.Windows.Forms.ToolStripMenuItem maximize_control_menu;
    }
}

