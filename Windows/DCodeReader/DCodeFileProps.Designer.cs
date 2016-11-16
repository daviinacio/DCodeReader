namespace DCodeReader {
    partial class DCodeFileProps {
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.EncodeTypeLabel = new System.Windows.Forms.Label();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.ContentEdit = new System.Windows.Forms.TextBox();
            this.EncodeTypeEdit = new System.Windows.Forms.TextBox();
            this.TitleEdit = new System.Windows.Forms.TextBox();
            this.Props_Cancel = new System.Windows.Forms.Button();
            this.Props_OK = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(6, 25);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(38, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Título:";
            // 
            // EncodeTypeLabel
            // 
            this.EncodeTypeLabel.AutoSize = true;
            this.EncodeTypeLabel.Location = new System.Drawing.Point(6, 73);
            this.EncodeTypeLabel.Name = "EncodeTypeLabel";
            this.EncodeTypeLabel.Size = new System.Drawing.Size(70, 13);
            this.EncodeTypeLabel.TabIndex = 1;
            this.EncodeTypeLabel.Text = "Encode type:";
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.Location = new System.Drawing.Point(6, 121);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(47, 13);
            this.ContentLabel.TabIndex = 2;
            this.ContentLabel.Text = "Content:";
            // 
            // ContentEdit
            // 
            this.ContentEdit.Enabled = false;
            this.ContentEdit.Location = new System.Drawing.Point(9, 137);
            this.ContentEdit.Name = "ContentEdit";
            this.ContentEdit.Size = new System.Drawing.Size(229, 20);
            this.ContentEdit.TabIndex = 3;
            // 
            // EncodeTypeEdit
            // 
            this.EncodeTypeEdit.Location = new System.Drawing.Point(9, 89);
            this.EncodeTypeEdit.Name = "EncodeTypeEdit";
            this.EncodeTypeEdit.Size = new System.Drawing.Size(229, 20);
            this.EncodeTypeEdit.TabIndex = 4;
            // 
            // TitleEdit
            // 
            this.TitleEdit.Location = new System.Drawing.Point(9, 41);
            this.TitleEdit.Name = "TitleEdit";
            this.TitleEdit.Size = new System.Drawing.Size(229, 20);
            this.TitleEdit.TabIndex = 5;
            // 
            // Props_Cancel
            // 
            this.Props_Cancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Props_Cancel.Location = new System.Drawing.Point(138, 191);
            this.Props_Cancel.Name = "Props_Cancel";
            this.Props_Cancel.Size = new System.Drawing.Size(118, 29);
            this.Props_Cancel.TabIndex = 7;
            this.Props_Cancel.Text = "Cancelar";
            this.Props_Cancel.UseVisualStyleBackColor = false;
            this.Props_Cancel.Click += new System.EventHandler(this.Props_Cancel_Click);
            // 
            // Props_OK
            // 
            this.Props_OK.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Props_OK.Location = new System.Drawing.Point(12, 191);
            this.Props_OK.Name = "Props_OK";
            this.Props_OK.Size = new System.Drawing.Size(120, 29);
            this.Props_OK.TabIndex = 6;
            this.Props_OK.Text = "Salvar";
            this.Props_OK.UseVisualStyleBackColor = false;
            this.Props_OK.Click += new System.EventHandler(this.Props_OK_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.ContentEdit);
            this.groupBox.Controls.Add(this.TitleEdit);
            this.groupBox.Controls.Add(this.ContentLabel);
            this.groupBox.Controls.Add(this.EncodeTypeEdit);
            this.groupBox.Controls.Add(this.TitleLabel);
            this.groupBox.Controls.Add(this.EncodeTypeLabel);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(244, 168);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Propriedades";
            // 
            // DCodeFileProps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(268, 232);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.Props_Cancel);
            this.Controls.Add(this.Props_OK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DCodeFileProps";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DCodeFileProps";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label EncodeTypeLabel;
        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.TextBox ContentEdit;
        private System.Windows.Forms.TextBox EncodeTypeEdit;
        private System.Windows.Forms.TextBox TitleEdit;
        private System.Windows.Forms.Button Props_Cancel;
        private System.Windows.Forms.Button Props_OK;
        private System.Windows.Forms.GroupBox groupBox;
    }
}