using System.Data;
using System.Text;
using System.Windows.Forms;
using Tyuiu.KorotkovNS.Sprint7.Project.V13.Lib;
namespace Tyuiu.KorotkovNS.Sprint7.Project.V13
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }
        private DataTable ReadCSVFile(string path)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    // ������ ������ ������ ��� ��������� ����������  
                    string headerLine = reader.ReadLine();
                    if (headerLine != null)
                    {
                        string[] headers = headerLine.Split(';'); // ������������, ��� ����������� - ����� � �������  
                        foreach (string header in headers)
                        {
                            dataTable.Columns.Add(header);
                        }

                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            string[] fields = line.Split(';');
                            dataTable.Rows.Add(fields);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� ������ �����: {ex.Message}");
            }

            return dataTable; // ���������� ����������� DataTable  
        }

        private void buttonOpenFile_KNS_Click(object sender, EventArgs e)
        {
            dataGridViewOutPut_KNS.DataSource = ReadCSVFile(@"C:\DataSprint7\������.csv");
            dataGridViewOutPut_KNS.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void buttonInformation_KNS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();

        }

        private void buttonManage_KNS_Click(object sender, EventArgs e)
        {
            FormManage formManage = new FormManage();
            formManage.ShowDialog();
        }

        private void buttonSaveFile_KNS_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogMain_KNS.FileName = "������.csv";
                saveFileDialogMain_KNS.InitialDirectory = @"C:\DataSprint7\New";

                if (saveFileDialogMain_KNS.ShowDialog() == DialogResult.OK)
                {
                    string savePath = saveFileDialogMain_KNS.FileName;

                    // �������� ������������� ����� � ��� ��������, ���� ���������  
                    if (File.Exists(savePath))
                    {
                        File.Delete(savePath);
                    }

                    int rows = dataGridViewOutPut_KNS.RowCount;
                    int columns = dataGridViewOutPut_KNS.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            // �������� �� null �������� ������  
                            string cellValue = dataGridViewOutPut_KNS.Rows[i].Cells[j].Value?.ToString() ?? string.Empty;

                            // ������ ������� ������ �������� �� ��� ������� ��� CSV  
                            cellValue = cellValue.Replace("\"", "\"\"");

                            // ����������� �������� � �������  
                            strBuilder.Append($"\"{cellValue}\"");

                            // ��������� ����������� ������ ���� ��� �� ��������� ������� � ������  
                            if (j != columns - 1)
                            {
                                strBuilder.Append(","); // ��������� �������� �������  
                            }
                        }
                        strBuilder.AppendLine(); // ����� ������  
                    }

                    // ������ ������ � ���� � ���������� UTF-8  
                    File.WriteAllText(savePath, strBuilder.ToString(), Encoding.UTF8);

                    MessageBox.Show("���� ������� �������� �� ��� ���������", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) // ���������� ���������� �� ������  
            {
                MessageBox.Show($"������: {ex.Message}\n���� �� ��� �������� �� ��� ���������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_KNS_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewOutPut_KNS.RowCount; i++)
            {
                dataGridViewOutPut_KNS.Rows[i].Selected = false; // ����� ��������� ������  
                                                                 // �������� ������ � ������ ������� (������ 0)  
                if (dataGridViewOutPut_KNS.Rows[i].Cells[0].Value != null)
                {
                    if (dataGridViewOutPut_KNS.Rows[i].Cells[0].Value.ToString().Contains(textBoxSearch_KNS.Text, StringComparison.OrdinalIgnoreCase)) // ������� ��������� ��� ����� ��������  
                    {
                        dataGridViewOutPut_KNS.Rows[i].Selected = true; // ����� ������  
                    }
                }
            }
        }

        private void buttonCalculateSquare_KNS_Click(object sender, EventArgs e)
        {
            int c = 0;
            for (int i = 0; i < dataGridViewOutPut_KNS.Rows.Count; i++)
            {
                c += Convert.ToInt32(dataGridViewOutPut_KNS.Rows[i].Cells[2].Value);
            }


            int rows = dataGridViewOutPut_KNS.Rows.Count - 1;
            double avg = c / rows;
            avg = Math.Round(avg, 3);                           //������� �������� �������� �������
            textBoxSquare_KNS.Text = avg.ToString();
        }

        private void buttonCalculatePopulation_KNS_Click(object sender, EventArgs e)
        {
            int c = 0;
            int min = int.MaxValue; // ������������� ������������ ��������  
            int max = int.MinValue; // ������������� ������������� ��������  

            for (int i = 0; i < dataGridViewOutPut_KNS.Rows.Count; i++)
            {
                // �������� �������� �� null  
                if (dataGridViewOutPut_KNS.Rows[i].Cells[3].Value != null)
                {
                    int value = Convert.ToInt32(dataGridViewOutPut_KNS.Rows[i].Cells[3].Value);

                    // ������������ ��������  
                    c += value;

                    // ���������� ������������ ��������  
                    if (value < min)
                    {
                        min = value;
                    }

                    // ���������� ������������� ��������  
                    if (value > max)
                    {
                        max = value;
                    }
                }
            }

            // �������������� ������ ��� ������: ����� / ����������� �������� / ������������ ��������
            textBoxPopulation_KNS.Text = $"{c} / {min} / {max}";
        }

        private void buttonBuildGrafic_KNS_Click(object sender, EventArgs e)
        {

            chartPopulation_KNS.Series["Series"].Points.Clear();
            chartPopulation_KNS.Series["Series2"].Points.Clear();// ������� ���������� ����� �������  

            double maxPopulation = double.MinValue; // ���������� ���������� �������� ��� ���������  
            double minPopulation = double.MaxValue; // ���������� ���������� �������� ��� ��������  
            string countryWithMax = string.Empty; // ������ � ������������ ����������  
            string countryWithMin = string.Empty; // ������ � ����������� ����������  

            // �������� �� ���� ������� DataGridView  
            foreach (DataGridViewRow row in dataGridViewOutPut_KNS.Rows)
            {
                // ��������, ��� ������ �� �������� ����� ������� � ������ �� null  
                if (!row.IsNewRow && row.Cells[0].Value != null && row.Cells[3].Value != null)
                {
                    string country = row.Cells[0].Value.ToString(); // �������� ������  

                    // �������������� �������� �� ��� Y (���������) � ���������� ����������  
                    if (double.TryParse(row.Cells[3].Value.ToString(), out double population))
                    {
                        // ������� ������������ � ����������� ��������  
                        if (population > maxPopulation)
                        {
                            maxPopulation = population;
                            countryWithMax = country; // ��������� ������ � ������������ ����������  
                        }
                        if (population < minPopulation)
                        {
                            minPopulation = population;
                            countryWithMin = country; // ��������� ������ � ����������� ����������  
                        }
                    }
                }
            }

            // ���������� ����� � ������������ ����������  
            if (!string.IsNullOrEmpty(countryWithMax) && maxPopulation != double.MinValue)
            {
                chartPopulation_KNS.Series["Series"].Points.AddXY(countryWithMax + " (Max)", maxPopulation);
            }

            // ���������� ����� � ����������� ����������  
            if (!string.IsNullOrEmpty(countryWithMin) && minPopulation != double.MaxValue)
            {
                chartPopulation_KNS.Series["Series2"].Points.AddXY(countryWithMin + " (Min)", minPopulation);
            }

        }


    }
}
