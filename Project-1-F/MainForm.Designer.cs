namespace Project_1_F {
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
            this.MainBackground = new System.Windows.Forms.Panel();
            this.DeleteWordBut = new System.Windows.Forms.PictureBox();
            this.SearchIcon = new System.Windows.Forms.PictureBox();
            this.CenterText = new System.Windows.Forms.RichTextBox();
            this.WordInputText = new System.Windows.Forms.Label();
            this.DictionariTypeText = new System.Windows.Forms.Label();
            this.WordTextInputBox = new System.Windows.Forms.TextBox();
            this.SelecterBoxDic = new System.Windows.Forms.ComboBox();
            this.HeadPanel = new System.Windows.Forms.Panel();
            this.CloseBut = new System.Windows.Forms.PictureBox();
            this.SettingBut = new System.Windows.Forms.PictureBox();
            this.HeadText = new System.Windows.Forms.Label();
            this.MainBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteWordBut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).BeginInit();
            this.HeadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingBut)).BeginInit();
            this.SuspendLayout();
            // 
            // MainBackground
            // 
            this.MainBackground.BackColor = System.Drawing.Color.Azure;
            this.MainBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainBackground.Controls.Add(this.DeleteWordBut);
            this.MainBackground.Controls.Add(this.SearchIcon);
            this.MainBackground.Controls.Add(this.CenterText);
            this.MainBackground.Controls.Add(this.WordInputText);
            this.MainBackground.Controls.Add(this.DictionariTypeText);
            this.MainBackground.Controls.Add(this.WordTextInputBox);
            this.MainBackground.Controls.Add(this.SelecterBoxDic);
            this.MainBackground.Controls.Add(this.HeadPanel);
            this.MainBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainBackground.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainBackground.Location = new System.Drawing.Point(0, 0);
            this.MainBackground.Name = "MainBackground";
            this.MainBackground.Size = new System.Drawing.Size(484, 461);
            this.MainBackground.TabIndex = 1;
            // 
            // DeleteWordBut
            // 
            this.DeleteWordBut.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteWordBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteWordBut.Image = global::Project_1_F.Properties.Resources.deleteOff;
            this.DeleteWordBut.Location = new System.Drawing.Point(440, 422);
            this.DeleteWordBut.Name = "DeleteWordBut";
            this.DeleteWordBut.Size = new System.Drawing.Size(31, 26);
            this.DeleteWordBut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeleteWordBut.TabIndex = 11;
            this.DeleteWordBut.TabStop = false;
            this.DeleteWordBut.Click += new System.EventHandler(this.DeleteWordBut_Click);
            this.DeleteWordBut.MouseEnter += new System.EventHandler(this.DeleteWordBut_MouseEnter);
            this.DeleteWordBut.MouseLeave += new System.EventHandler(this.DeleteWordBut_MouseLeave);
            // 
            // SearchIcon
            // 
            this.SearchIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchIcon.Image = global::Project_1_F.Properties.Resources.searchIconOff;
            this.SearchIcon.Location = new System.Drawing.Point(440, 88);
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.Size = new System.Drawing.Size(32, 26);
            this.SearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchIcon.TabIndex = 10;
            this.SearchIcon.TabStop = false;
            this.SearchIcon.Click += new System.EventHandler(this.SearchIcon_Click);
            this.SearchIcon.MouseEnter += new System.EventHandler(this.SearchIcon_MouseEnter);
            this.SearchIcon.MouseLeave += new System.EventHandler(this.SearchIcon_MouseLeave);
            // 
            // CenterText
            // 
            this.CenterText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CenterText.Location = new System.Drawing.Point(16, 120);
            this.CenterText.Name = "CenterText";
            this.CenterText.ReadOnly = true;
            this.CenterText.Size = new System.Drawing.Size(456, 329);
            this.CenterText.TabIndex = 9;
            this.CenterText.Text = "";
            // 
            // WordInputText
            // 
            this.WordInputText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WordInputText.Font = new System.Drawing.Font("Arial", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordInputText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.WordInputText.Location = new System.Drawing.Point(12, 74);
            this.WordInputText.Name = "WordInputText";
            this.WordInputText.Size = new System.Drawing.Size(159, 42);
            this.WordInputText.TabIndex = 8;
            this.WordInputText.Text = "Введите слово:";
            this.WordInputText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DictionariTypeText
            // 
            this.DictionariTypeText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DictionariTypeText.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DictionariTypeText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DictionariTypeText.Location = new System.Drawing.Point(12, 41);
            this.DictionariTypeText.Margin = new System.Windows.Forms.Padding(0);
            this.DictionariTypeText.Name = "DictionariTypeText";
            this.DictionariTypeText.Size = new System.Drawing.Size(159, 33);
            this.DictionariTypeText.TabIndex = 5;
            this.DictionariTypeText.Text = "Выберите словарь:";
            this.DictionariTypeText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WordTextInputBox
            // 
            this.WordTextInputBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WordTextInputBox.Location = new System.Drawing.Point(174, 88);
            this.WordTextInputBox.Name = "WordTextInputBox";
            this.WordTextInputBox.Size = new System.Drawing.Size(259, 26);
            this.WordTextInputBox.TabIndex = 7;
            this.WordTextInputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WordTextInputBox_KeyDown);
            // 
            // SelecterBoxDic
            // 
            this.SelecterBoxDic.BackColor = System.Drawing.SystemColors.Menu;
            this.SelecterBoxDic.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelecterBoxDic.FormattingEnabled = true;
            this.SelecterBoxDic.Location = new System.Drawing.Point(174, 42);
            this.SelecterBoxDic.Name = "SelecterBoxDic";
            this.SelecterBoxDic.Size = new System.Drawing.Size(298, 32);
            this.SelecterBoxDic.TabIndex = 4;
            this.SelecterBoxDic.Text = "Выберите словарь";
            this.SelecterBoxDic.SelectedIndexChanged += new System.EventHandler(this.SelecterBoxDic_SelectedIndexChanged);
            // 
            // HeadPanel
            // 
            this.HeadPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HeadPanel.Controls.Add(this.CloseBut);
            this.HeadPanel.Controls.Add(this.SettingBut);
            this.HeadPanel.Controls.Add(this.HeadText);
            this.HeadPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadPanel.Location = new System.Drawing.Point(0, 0);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new System.Drawing.Size(484, 36);
            this.HeadPanel.TabIndex = 3;
            // 
            // CloseBut
            // 
            this.CloseBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBut.Image = global::Project_1_F.Properties.Resources.exitOff1;
            this.CloseBut.Location = new System.Drawing.Point(443, 0);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(41, 36);
            this.CloseBut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBut.TabIndex = 5;
            this.CloseBut.TabStop = false;
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            this.CloseBut.MouseEnter += new System.EventHandler(this.CloseBut_MouseEnter_1);
            this.CloseBut.MouseLeave += new System.EventHandler(this.CloseBut_MouseLeave_1);
            // 
            // SettingBut
            // 
            this.SettingBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingBut.Image = global::Project_1_F.Properties.Resources.settingOff;
            this.SettingBut.Location = new System.Drawing.Point(400, 0);
            this.SettingBut.Name = "SettingBut";
            this.SettingBut.Size = new System.Drawing.Size(37, 36);
            this.SettingBut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SettingBut.TabIndex = 4;
            this.SettingBut.TabStop = false;
            this.SettingBut.Click += new System.EventHandler(this.SettingBut_Click);
            this.SettingBut.MouseEnter += new System.EventHandler(this.SettingBut_MouseEnter);
            this.SettingBut.MouseLeave += new System.EventHandler(this.SettingBut_MouseLeave);
            // 
            // HeadText
            // 
            this.HeadText.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadText.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeadText.ForeColor = System.Drawing.Color.DarkOrange;
            this.HeadText.Location = new System.Drawing.Point(0, 0);
            this.HeadText.Name = "HeadText";
            this.HeadText.Size = new System.Drawing.Size(484, 36);
            this.HeadText.TabIndex = 2;
            this.HeadText.Text = "Словарь";
            this.HeadText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HeadText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadText_MouseDown);
            this.HeadText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeadText_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.MainBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.MainBackground.ResumeLayout(false);
            this.MainBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteWordBut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).EndInit();
            this.HeadPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingBut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainBackground;
        private System.Windows.Forms.Panel HeadPanel;
        private System.Windows.Forms.Label HeadText;
        private System.Windows.Forms.ComboBox SelecterBoxDic;
        private System.Windows.Forms.TextBox WordTextInputBox;
        private System.Windows.Forms.Label DictionariTypeText;
        private System.Windows.Forms.Label WordInputText;
        public System.Windows.Forms.RichTextBox CenterText;
        private System.Windows.Forms.PictureBox SearchIcon;
        private System.Windows.Forms.PictureBox SettingBut;
        private System.Windows.Forms.PictureBox CloseBut;
        private System.Windows.Forms.PictureBox DeleteWordBut;
    }
}