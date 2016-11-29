namespace DCodeReader {
    partial class SettingsForm {
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
            this.lineNumber = new System.Windows.Forms.CheckBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.AparenciaGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ColorThemeLabel = new System.Windows.Forms.Label();
            this.AparenciaGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lineNumber
            // 
            this.lineNumber.AutoSize = true;
            this.lineNumber.Location = new System.Drawing.Point(6, 35);
            this.lineNumber.Name = "lineNumber";
            this.lineNumber.Size = new System.Drawing.Size(129, 17);
            this.lineNumber.TabIndex = 0;
            this.lineNumber.Text = "Exibir número da linha";
            this.lineNumber.UseVisualStyleBackColor = true;
            this.lineNumber.CheckedChanged += new System.EventHandler(this.lineNumber_CheckedChanged);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(181, 282);
            this.treeView1.TabIndex = 2;
            // 
            // AparenciaGroupBox
            // 
            this.AparenciaGroupBox.Controls.Add(this.panel1);
            this.AparenciaGroupBox.Location = new System.Drawing.Point(199, 12);
            this.AparenciaGroupBox.Name = "AparenciaGroupBox";
            this.AparenciaGroupBox.Size = new System.Drawing.Size(413, 138);
            this.AparenciaGroupBox.TabIndex = 4;
            this.AparenciaGroupBox.TabStop = false;
            this.AparenciaGroupBox.Text = "Aparência";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lineNumber);
            this.panel1.Controls.Add(this.ColorThemeLabel);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 113);
            this.panel1.TabIndex = 0;
            // 
            // ColorThemeLabel
            // 
            this.ColorThemeLabel.AutoSize = true;
            this.ColorThemeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorThemeLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ColorThemeLabel.Location = new System.Drawing.Point(3, 0);
            this.ColorThemeLabel.Name = "ColorThemeLabel";
            this.ColorThemeLabel.Size = new System.Drawing.Size(74, 13);
            this.ColorThemeLabel.TabIndex = 0;
            this.ColorThemeLabel.Text = "ColorTheme";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(624, 306);
            this.Controls.Add(this.AparenciaGroupBox);
            this.Controls.Add(this.treeView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configurações";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.AparenciaGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox lineNumber;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox AparenciaGroupBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ColorThemeLabel;
    }
}