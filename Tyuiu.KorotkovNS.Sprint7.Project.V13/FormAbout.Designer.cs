namespace Tyuiu.KorotkovNS.Sprint7.Project.V13
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            buttonOk_KNS = new Button();
            textBoxInfo_KNS = new TextBox();
            pictureBoxAvatar_KNS = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KNS).BeginInit();
            SuspendLayout();
            // 
            // buttonOk_KNS
            // 
            buttonOk_KNS.Location = new Point(578, 215);
            buttonOk_KNS.Name = "buttonOk_KNS";
            buttonOk_KNS.Size = new Size(117, 39);
            buttonOk_KNS.TabIndex = 8;
            buttonOk_KNS.Text = "ОК";
            buttonOk_KNS.UseVisualStyleBackColor = true;
            buttonOk_KNS.Click += buttonOk_KNS_Click;
            // 
            // textBoxInfo_KNS
            // 
            textBoxInfo_KNS.Location = new Point(239, 12);
            textBoxInfo_KNS.Multiline = true;
            textBoxInfo_KNS.Name = "textBoxInfo_KNS";
            textBoxInfo_KNS.ReadOnly = true;
            textBoxInfo_KNS.Size = new Size(456, 197);
            textBoxInfo_KNS.TabIndex = 7;
            textBoxInfo_KNS.Text = resources.GetString("textBoxInfo_KNS.Text");
            // 
            // pictureBoxAvatar_KNS
            // 
            pictureBoxAvatar_KNS.Image = Properties.Resources.dwdwdwdwd;
            pictureBoxAvatar_KNS.Location = new Point(12, 12);
            pictureBoxAvatar_KNS.Name = "pictureBoxAvatar_KNS";
            pictureBoxAvatar_KNS.Size = new Size(184, 242);
            pictureBoxAvatar_KNS.TabIndex = 6;
            pictureBoxAvatar_KNS.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 266);
            Controls.Add(buttonOk_KNS);
            Controls.Add(textBoxInfo_KNS);
            Controls.Add(pictureBoxAvatar_KNS);
            MaximizeBox = false;
            MaximumSize = new Size(725, 313);
            MinimumSize = new Size(725, 313);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            Load += FormAbout_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KNS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOk_KNS;
        private TextBox textBoxInfo_KNS;
        private PictureBox pictureBoxAvatar_KNS;
    }
}