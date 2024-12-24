namespace Tyuiu.KorotkovNS.Sprint7.Project.V13
{
    partial class FormManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManage));
            textBoxManage_KNS = new TextBox();
            SuspendLayout();
            // 
            // textBoxManage_KNS
            // 
            textBoxManage_KNS.Location = new Point(12, 12);
            textBoxManage_KNS.Multiline = true;
            textBoxManage_KNS.Name = "textBoxManage_KNS";
            textBoxManage_KNS.ReadOnly = true;
            textBoxManage_KNS.ScrollBars = ScrollBars.Vertical;
            textBoxManage_KNS.Size = new Size(776, 426);
            textBoxManage_KNS.TabIndex = 0;
            textBoxManage_KNS.Text = resources.GetString("textBoxManage_KNS.Text");
            // 
            // FormManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxManage_KNS);
            Name = "FormManage";
            Text = "Руководство пользователя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxManage_KNS;
    }
}