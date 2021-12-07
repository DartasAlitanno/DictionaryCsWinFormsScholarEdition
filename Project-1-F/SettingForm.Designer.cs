namespace Project_1_F {
    partial class SettingForm {
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
            this.HeadText = new System.Windows.Forms.Label();
            this.MainBackground = new System.Windows.Forms.Panel();
            this.HeadPanel = new System.Windows.Forms.Panel();
            this.CloseBut = new System.Windows.Forms.PictureBox();
            this.MainBackground.SuspendLayout();
            this.HeadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBut)).BeginInit();
            this.SuspendLayout();
            // 
            // HeadText
            // 
            this.HeadText.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadText.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeadText.ForeColor = System.Drawing.Color.DarkOrange;
            this.HeadText.Location = new System.Drawing.Point(0, 0);
            this.HeadText.Name = "HeadText";
            this.HeadText.Size = new System.Drawing.Size(527, 36);
            this.HeadText.TabIndex = 2;
            this.HeadText.Text = "Настройки";
            this.HeadText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HeadText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadText_MouseDown);
            this.HeadText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeadText_MouseMove);
            // 
            // MainBackground
            // 
            this.MainBackground.BackColor = System.Drawing.Color.Azure;
            this.MainBackground.Controls.Add(this.HeadPanel);
            this.MainBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainBackground.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainBackground.Location = new System.Drawing.Point(0, 0);
            this.MainBackground.Name = "MainBackground";
            this.MainBackground.Size = new System.Drawing.Size(527, 342);
            this.MainBackground.TabIndex = 2;
            // 
            // HeadPanel
            // 
            this.HeadPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HeadPanel.Controls.Add(this.CloseBut);
            this.HeadPanel.Controls.Add(this.HeadText);
            this.HeadPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadPanel.Location = new System.Drawing.Point(0, 0);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new System.Drawing.Size(527, 36);
            this.HeadPanel.TabIndex = 3;
            // 
            // CloseBut
            // 
            this.CloseBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBut.Image = global::Project_1_F.Properties.Resources.exitOff1;
            this.CloseBut.Location = new System.Drawing.Point(486, 0);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(41, 36);
            this.CloseBut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBut.TabIndex = 5;
            this.CloseBut.TabStop = false;
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            this.CloseBut.MouseEnter += new System.EventHandler(this.CloseBut_MouseEnter_1);
            this.CloseBut.MouseLeave += new System.EventHandler(this.CloseBut_MouseLeave_1);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 342);
            this.Controls.Add(this.MainBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.MainBackground.ResumeLayout(false);
            this.HeadPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HeadText;
        private System.Windows.Forms.Panel MainBackground;
        private System.Windows.Forms.Panel HeadPanel;
        private System.Windows.Forms.PictureBox CloseBut;
    }
}