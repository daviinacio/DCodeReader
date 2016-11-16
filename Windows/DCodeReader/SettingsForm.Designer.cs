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
            this.AparenciaGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lineNumber
            // 
            this.lineNumber.AutoSize = true;
            this.lineNumber.Location = new System.Drawing.Point(3, 3);
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
            this.AparenciaGroupBox.Controls.Add(this.lineNumber);
            this.AparenciaGroupBox.Location = new System.Drawing.Point(199, 12);
            this.AparenciaGroupBox.Name = "AparenciaGroupBox";
            this.AparenciaGroupBox.Size = new System.Drawing.Size(413, 282);
            this.AparenciaGroupBox.TabIndex = 4;
            this.AparenciaGroupBox.TabStop = false;
            this.AparenciaGroupBox.Text = "Aparência";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.AparenciaGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox lineNumber;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox AparenciaGroupBox;
    }
}