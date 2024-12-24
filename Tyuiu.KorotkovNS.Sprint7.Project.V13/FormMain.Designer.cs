namespace Tyuiu.KorotkovNS.Sprint7.Project.V13
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxPanelManagement_KNS = new GroupBox();
            groupBoxInfo_KNS = new GroupBox();
            buttonManage_KNS = new Button();
            buttonInformation_KNS = new Button();
            groupBoxPopulation_KNS = new GroupBox();
            textBoxPopulation_KNS = new TextBox();
            buttonBuildGrafic_KNS = new Button();
            buttonCalculatePopulation_KNS = new Button();
            groupBoxSquare_KNS = new GroupBox();
            textBoxSquare_KNS = new TextBox();
            buttonCalculateSquare_KNS = new Button();
            groupBoxSearch_KNS = new GroupBox();
            textBoxSearch_KNS = new TextBox();
            buttonSearch_KNS = new Button();
            groupBoxButton_KNS = new GroupBox();
            buttonSaveFile_KNS = new Button();
            buttonOpenFile_KNS = new Button();
            buttonInfo_KNS = new Button();
            groupBoxGrafic_KNS = new GroupBox();
            chartPopulation_KNS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxOutPut_KNS = new GroupBox();
            dataGridViewOutPut_KNS = new DataGridView();
            openFileDialogMain_KNS = new OpenFileDialog();
            saveFileDialogMain_KNS = new SaveFileDialog();
            toolTipMain_KNS = new ToolTip(components);
            buttonManagement_KNS = new Button();
            groupBoxPanelManagement_KNS.SuspendLayout();
            groupBoxInfo_KNS.SuspendLayout();
            groupBoxPopulation_KNS.SuspendLayout();
            groupBoxSquare_KNS.SuspendLayout();
            groupBoxSearch_KNS.SuspendLayout();
            groupBoxButton_KNS.SuspendLayout();
            groupBoxGrafic_KNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartPopulation_KNS).BeginInit();
            groupBoxOutPut_KNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_KNS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxPanelManagement_KNS
            // 
            groupBoxPanelManagement_KNS.Controls.Add(groupBoxInfo_KNS);
            groupBoxPanelManagement_KNS.Controls.Add(groupBoxPopulation_KNS);
            groupBoxPanelManagement_KNS.Controls.Add(groupBoxSquare_KNS);
            groupBoxPanelManagement_KNS.Controls.Add(groupBoxSearch_KNS);
            groupBoxPanelManagement_KNS.Controls.Add(groupBoxButton_KNS);
            groupBoxPanelManagement_KNS.Location = new Point(12, 12);
            groupBoxPanelManagement_KNS.Name = "groupBoxPanelManagement_KNS";
            groupBoxPanelManagement_KNS.Size = new Size(431, 649);
            groupBoxPanelManagement_KNS.TabIndex = 0;
            groupBoxPanelManagement_KNS.TabStop = false;
            groupBoxPanelManagement_KNS.Text = "Панель управления";
            // 
            // groupBoxInfo_KNS
            // 
            groupBoxInfo_KNS.Controls.Add(buttonManage_KNS);
            groupBoxInfo_KNS.Controls.Add(buttonInformation_KNS);
            groupBoxInfo_KNS.Location = new Point(6, 508);
            groupBoxInfo_KNS.Name = "groupBoxInfo_KNS";
            groupBoxInfo_KNS.Size = new Size(419, 117);
            groupBoxInfo_KNS.TabIndex = 1;
            groupBoxInfo_KNS.TabStop = false;
            groupBoxInfo_KNS.Text = "Информация";
            // 
            // buttonManage_KNS
            // 
            buttonManage_KNS.Location = new Point(224, 37);
            buttonManage_KNS.Name = "buttonManage_KNS";
            buttonManage_KNS.Size = new Size(142, 47);
            buttonManage_KNS.TabIndex = 0;
            buttonManage_KNS.Text = "?";
            buttonManage_KNS.UseVisualStyleBackColor = true;
            buttonManage_KNS.Click += buttonManage_KNS_Click;
            // 
            // buttonInformation_KNS
            // 
            buttonInformation_KNS.Location = new Point(57, 37);
            buttonInformation_KNS.Name = "buttonInformation_KNS";
            buttonInformation_KNS.Size = new Size(142, 47);
            buttonInformation_KNS.TabIndex = 0;
            buttonInformation_KNS.Text = "info";
            buttonInformation_KNS.UseVisualStyleBackColor = true;
            buttonInformation_KNS.Click += buttonInformation_KNS_Click;
            // 
            // groupBoxPopulation_KNS
            // 
            groupBoxPopulation_KNS.Controls.Add(textBoxPopulation_KNS);
            groupBoxPopulation_KNS.Controls.Add(buttonBuildGrafic_KNS);
            groupBoxPopulation_KNS.Controls.Add(buttonCalculatePopulation_KNS);
            groupBoxPopulation_KNS.Location = new Point(6, 385);
            groupBoxPopulation_KNS.Name = "groupBoxPopulation_KNS";
            groupBoxPopulation_KNS.Size = new Size(419, 117);
            groupBoxPopulation_KNS.TabIndex = 1;
            groupBoxPopulation_KNS.TabStop = false;
            groupBoxPopulation_KNS.Text = "Население (Общее количество/min/max)";
            // 
            // textBoxPopulation_KNS
            // 
            textBoxPopulation_KNS.Location = new Point(0, 74);
            textBoxPopulation_KNS.Multiline = true;
            textBoxPopulation_KNS.Name = "textBoxPopulation_KNS";
            textBoxPopulation_KNS.Size = new Size(419, 42);
            textBoxPopulation_KNS.TabIndex = 1;
            // 
            // buttonBuildGrafic_KNS
            // 
            buttonBuildGrafic_KNS.Location = new Point(277, 21);
            buttonBuildGrafic_KNS.Name = "buttonBuildGrafic_KNS";
            buttonBuildGrafic_KNS.Size = new Size(142, 47);
            buttonBuildGrafic_KNS.TabIndex = 0;
            buttonBuildGrafic_KNS.Text = "На графике";
            buttonBuildGrafic_KNS.UseVisualStyleBackColor = true;
            buttonBuildGrafic_KNS.Click += buttonBuildGrafic_KNS_Click;
            // 
            // buttonCalculatePopulation_KNS
            // 
            buttonCalculatePopulation_KNS.Location = new Point(129, 21);
            buttonCalculatePopulation_KNS.Name = "buttonCalculatePopulation_KNS";
            buttonCalculatePopulation_KNS.Size = new Size(142, 47);
            buttonCalculatePopulation_KNS.TabIndex = 0;
            buttonCalculatePopulation_KNS.Text = "Рассчитать";
            buttonCalculatePopulation_KNS.UseVisualStyleBackColor = true;
            buttonCalculatePopulation_KNS.Click += buttonCalculatePopulation_KNS_Click;
            // 
            // groupBoxSquare_KNS
            // 
            groupBoxSquare_KNS.Controls.Add(textBoxSquare_KNS);
            groupBoxSquare_KNS.Controls.Add(buttonCalculateSquare_KNS);
            groupBoxSquare_KNS.Location = new Point(6, 262);
            groupBoxSquare_KNS.Name = "groupBoxSquare_KNS";
            groupBoxSquare_KNS.Size = new Size(419, 117);
            groupBoxSquare_KNS.TabIndex = 1;
            groupBoxSquare_KNS.TabStop = false;
            groupBoxSquare_KNS.Text = "Средняя площадь всех территорий";
            // 
            // textBoxSquare_KNS
            // 
            textBoxSquare_KNS.Location = new Point(0, 74);
            textBoxSquare_KNS.Multiline = true;
            textBoxSquare_KNS.Name = "textBoxSquare_KNS";
            textBoxSquare_KNS.Size = new Size(419, 42);
            textBoxSquare_KNS.TabIndex = 1;
            // 
            // buttonCalculateSquare_KNS
            // 
            buttonCalculateSquare_KNS.Location = new Point(277, 11);
            buttonCalculateSquare_KNS.Name = "buttonCalculateSquare_KNS";
            buttonCalculateSquare_KNS.Size = new Size(142, 47);
            buttonCalculateSquare_KNS.TabIndex = 0;
            buttonCalculateSquare_KNS.Text = "Рассчитать";
            buttonCalculateSquare_KNS.UseVisualStyleBackColor = true;
            buttonCalculateSquare_KNS.Click += buttonCalculateSquare_KNS_Click;
            // 
            // groupBoxSearch_KNS
            // 
            groupBoxSearch_KNS.Controls.Add(textBoxSearch_KNS);
            groupBoxSearch_KNS.Controls.Add(buttonSearch_KNS);
            groupBoxSearch_KNS.Location = new Point(6, 139);
            groupBoxSearch_KNS.Name = "groupBoxSearch_KNS";
            groupBoxSearch_KNS.Size = new Size(419, 117);
            groupBoxSearch_KNS.TabIndex = 1;
            groupBoxSearch_KNS.TabStop = false;
            groupBoxSearch_KNS.Text = "Поиск страны в таблице";
            // 
            // textBoxSearch_KNS
            // 
            textBoxSearch_KNS.Location = new Point(0, 74);
            textBoxSearch_KNS.Multiline = true;
            textBoxSearch_KNS.Name = "textBoxSearch_KNS";
            textBoxSearch_KNS.Size = new Size(419, 42);
            textBoxSearch_KNS.TabIndex = 1;
            // 
            // buttonSearch_KNS
            // 
            buttonSearch_KNS.Location = new Point(277, 11);
            buttonSearch_KNS.Name = "buttonSearch_KNS";
            buttonSearch_KNS.Size = new Size(142, 47);
            buttonSearch_KNS.TabIndex = 0;
            buttonSearch_KNS.Text = "Поиск";
            buttonSearch_KNS.UseVisualStyleBackColor = true;
            buttonSearch_KNS.Click += buttonSearch_KNS_Click;
            // 
            // groupBoxButton_KNS
            // 
            groupBoxButton_KNS.Controls.Add(buttonSaveFile_KNS);
            groupBoxButton_KNS.Controls.Add(buttonOpenFile_KNS);
            groupBoxButton_KNS.Location = new Point(6, 26);
            groupBoxButton_KNS.Name = "groupBoxButton_KNS";
            groupBoxButton_KNS.Size = new Size(419, 107);
            groupBoxButton_KNS.TabIndex = 0;
            groupBoxButton_KNS.TabStop = false;
            groupBoxButton_KNS.Text = "Кнопки";
            // 
            // buttonSaveFile_KNS
            // 
            buttonSaveFile_KNS.Location = new Point(253, 26);
            buttonSaveFile_KNS.Name = "buttonSaveFile_KNS";
            buttonSaveFile_KNS.Size = new Size(160, 65);
            buttonSaveFile_KNS.TabIndex = 0;
            buttonSaveFile_KNS.Text = "Сохранить";
            buttonSaveFile_KNS.UseVisualStyleBackColor = true;
            buttonSaveFile_KNS.Click += buttonSaveFile_KNS_Click;
            // 
            // buttonOpenFile_KNS
            // 
            buttonOpenFile_KNS.Location = new Point(6, 26);
            buttonOpenFile_KNS.Name = "buttonOpenFile_KNS";
            buttonOpenFile_KNS.Size = new Size(160, 65);
            buttonOpenFile_KNS.TabIndex = 0;
            buttonOpenFile_KNS.Text = "Открыть";
            buttonOpenFile_KNS.UseVisualStyleBackColor = true;
            buttonOpenFile_KNS.Click += buttonOpenFile_KNS_Click;
            // 
            // buttonInfo_KNS
            // 
            buttonInfo_KNS.Location = new Point(108, 26);
            buttonInfo_KNS.Name = "buttonInfo_KNS";
            buttonInfo_KNS.Size = new Size(95, 85);
            buttonInfo_KNS.TabIndex = 0;
            buttonInfo_KNS.Text = "info";
            buttonInfo_KNS.UseVisualStyleBackColor = true;
            // 
            // groupBoxGrafic_KNS
            // 
            groupBoxGrafic_KNS.Controls.Add(chartPopulation_KNS);
            groupBoxGrafic_KNS.Location = new Point(453, 12);
            groupBoxGrafic_KNS.Name = "groupBoxGrafic_KNS";
            groupBoxGrafic_KNS.Size = new Size(797, 308);
            groupBoxGrafic_KNS.TabIndex = 1;
            groupBoxGrafic_KNS.TabStop = false;
            groupBoxGrafic_KNS.Text = "График";
            // 
            // chartPopulation_KNS
            // 
            chartArea1.Name = "ChartArea1";
            chartPopulation_KNS.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend";
            chartPopulation_KNS.Legends.Add(legend1);
            chartPopulation_KNS.Location = new Point(0, 26);
            chartPopulation_KNS.Name = "chartPopulation_KNS";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend";
            series1.Name = "Series";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend";
            series2.Name = "Series2";
            chartPopulation_KNS.Series.Add(series1);
            chartPopulation_KNS.Series.Add(series2);
            chartPopulation_KNS.Size = new Size(797, 282);
            chartPopulation_KNS.TabIndex = 0;
            // 
            // groupBoxOutPut_KNS
            // 
            groupBoxOutPut_KNS.Controls.Add(dataGridViewOutPut_KNS);
            groupBoxOutPut_KNS.Location = new Point(453, 326);
            groupBoxOutPut_KNS.Name = "groupBoxOutPut_KNS";
            groupBoxOutPut_KNS.Size = new Size(797, 335);
            groupBoxOutPut_KNS.TabIndex = 2;
            groupBoxOutPut_KNS.TabStop = false;
            groupBoxOutPut_KNS.Text = "Вывод данных";
            // 
            // dataGridViewOutPut_KNS
            // 
            dataGridViewOutPut_KNS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewOutPut_KNS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewOutPut_KNS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPut_KNS.Location = new Point(0, 26);
            dataGridViewOutPut_KNS.Name = "dataGridViewOutPut_KNS";
            dataGridViewOutPut_KNS.RowHeadersWidth = 51;
            dataGridViewOutPut_KNS.Size = new Size(797, 309);
            dataGridViewOutPut_KNS.TabIndex = 0;
            
            // 
            // openFileDialogMain_KNS
            // 
            openFileDialogMain_KNS.FileName = "openFileDialog1";
            // 
            // buttonManagement_KNS
            // 
            buttonManagement_KNS.Location = new Point(209, 26);
            buttonManagement_KNS.Name = "buttonManagement_KNS";
            buttonManagement_KNS.Size = new Size(95, 85);
            buttonManagement_KNS.TabIndex = 0;
            buttonManagement_KNS.Text = "?";
            buttonManagement_KNS.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(groupBoxOutPut_KNS);
            Controls.Add(groupBoxGrafic_KNS);
            Controls.Add(groupBoxPanelManagement_KNS);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 7 | Проект | Вариант 13 | Коротков Н.С.";
            groupBoxPanelManagement_KNS.ResumeLayout(false);
            groupBoxInfo_KNS.ResumeLayout(false);
            groupBoxPopulation_KNS.ResumeLayout(false);
            groupBoxPopulation_KNS.PerformLayout();
            groupBoxSquare_KNS.ResumeLayout(false);
            groupBoxSquare_KNS.PerformLayout();
            groupBoxSearch_KNS.ResumeLayout(false);
            groupBoxSearch_KNS.PerformLayout();
            groupBoxButton_KNS.ResumeLayout(false);
            groupBoxGrafic_KNS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartPopulation_KNS).EndInit();
            groupBoxOutPut_KNS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_KNS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPanelManagement_KNS;
        private GroupBox groupBoxGrafic_KNS;
        private GroupBox groupBoxOutPut_KNS;
        private GroupBox groupBoxButton_KNS;
        private Button buttonSaveFile_KNS;
        private Button buttonOpenFile_KNS;
        private GroupBox groupBoxSearch_KNS;
        private TextBox textBoxSearch_KNS;
        private Button buttonSearch_KNS;
        private GroupBox groupBoxSquare_KNS;
        private TextBox textBoxSquare_KNS;
        private Button buttonCalculateSquare_KNS;
        private GroupBox groupBoxPopulation_KNS;
        private TextBox textBoxPopulation_KNS;
        private Button buttonCalculatePopulation_KNS;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button buttonInfo_KNS;
        private Button buttonBuildGrafic_KNS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPopulation_KNS;
        private DataGridView dataGridViewOutPut_KNS;
        private OpenFileDialog openFileDialogMain_KNS;
        private SaveFileDialog saveFileDialogMain_KNS;
        private ToolTip toolTipMain_KNS;
        private Button buttonManagement_KNS;
        private GroupBox groupBoxInfo_KNS;
        private Button buttonManage_KNS;
        private Button buttonInformation_KNS;
    }
}
