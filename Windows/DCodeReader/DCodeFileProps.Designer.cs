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
            this.back_tayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox.SuspendLayout();
            this.back_tayoutPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(6, 16);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(47, 15);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Título:";
            // 
            // EncodeTypeLabel
            // 
            this.EncodeTypeLabel.AutoSize = true;
            this.EncodeTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncodeTypeLabel.Location = new System.Drawing.Point(6, 63);
            this.EncodeTypeLabel.Name = "EncodeTypeLabel";
            this.EncodeTypeLabel.Size = new System.Drawing.Size(89, 15);
            this.EncodeTypeLabel.TabIndex = 1;
            this.EncodeTypeLabel.Text = "Encode type:";
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentLabel.Location = new System.Drawing.Point(6, 110);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(60, 15);
            this.ContentLabel.TabIndex = 2;
            this.ContentLabel.Text = "Content:";
            // 
            // ContentEdit
            // 
            this.ContentEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContentEdit.Enabled = false;
            this.ContentEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentEdit.Location = new System.Drawing.Point(9, 128);
            this.ContentEdit.Multiline = true;
            this.ContentEdit.Name = "ContentEdit";
            this.ContentEdit.Size = new System.Drawing.Size(273, 69);
            this.ContentEdit.TabIndex = 5;
            // 
            // EncodeTypeEdit
            // 
            this.EncodeTypeEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EncodeTypeEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncodeTypeEdit.Location = new System.Drawing.Point(9, 81);
            this.EncodeTypeEdit.Name = "EncodeTypeEdit";
            this.EncodeTypeEdit.Size = new System.Drawing.Size(273, 26);
            this.EncodeTypeEdit.TabIndex = 2;
            // 
            // TitleEdit
            // 
            this.TitleEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleEdit.Location = new System.Drawing.Point(9, 34);
            this.TitleEdit.Name = "TitleEdit";
            this.TitleEdit.Size = new System.Drawing.Size(273, 26);
            this.TitleEdit.TabIndex = 1;
            // 
            // Props_Cancel
            // 
            this.Props_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.Props_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Props_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Props_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Props_Cancel.Location = new System.Drawing.Point(104, 3);
            this.Props_Cancel.Name = "Props_Cancel";
            this.Props_Cancel.Size = new System.Drawing.Size(94, 30);
            this.Props_Cancel.TabIndex = 4;
            this.Props_Cancel.Text = "Cancelar";
            this.Props_Cancel.UseVisualStyleBackColor = false;
            this.Props_Cancel.Click += new System.EventHandler(this.Props_Cancel_Click);
            // 
            // Props_OK
            // 
            this.Props_OK.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Props_OK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Props_OK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Props_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Props_OK.ForeColor = System.Drawing.SystemColors.Window;
            this.Props_OK.Location = new System.Drawing.Point(204, 3);
            this.Props_OK.Name = "Props_OK";
            this.Props_OK.Size = new System.Drawing.Size(87, 30);
            this.Props_OK.TabIndex = 3;
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
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(8, 8);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(288, 203);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Propriedades";
            // 
            // back_tayoutPanel
            // 
            this.back_tayoutPanel.ColumnCount = 1;
            this.back_tayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.back_tayoutPanel.Controls.Add(this.groupBox, 0, 0);
            this.back_tayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.back_tayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.back_tayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.back_tayoutPanel.Name = "back_tayoutPanel";
            this.back_tayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.back_tayoutPanel.RowCount = 2;
            this.back_tayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.back_tayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.back_tayoutPanel.Size = new System.Drawing.Size(304, 255);
            this.back_tayoutPanel.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel2.Controls.Add(this.Props_Cancel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Props_OK, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 214);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(294, 36);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // DCodeFileProps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(304, 255);
            this.Controls.Add(this.back_tayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DCodeFileProps";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalhes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DCodeFileProps_FormClosing);
            this.Load += new System.EventHandler(this.DCodeFileProps_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.back_tayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel back_tayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}