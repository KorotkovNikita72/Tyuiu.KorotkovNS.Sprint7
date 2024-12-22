using System.Data;
using System.Text;
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
                    // Читаем первую строку для получения заголовков  
                    string headerLine = reader.ReadLine();
                    if (headerLine != null)
                    {
                        string[] headers = headerLine.Split(';'); // Предполагаем, что разделитель - точка с запятой  
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
                MessageBox.Show($"Ошибка при чтении файла: {ex.Message}");
            }

            return dataTable; // Возвращаем заполненный DataTable  
        }

        private void buttonOpenFile_KNS_Click(object sender, EventArgs e)
        {
            dataGridViewOutPut_KNS.DataSource = ReadCSVFile(@"C:\DataSprint7\Россия.csv");
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
                saveFileDialogMain_KNS.FileName = "Россия.csv";
                saveFileDialogMain_KNS.InitialDirectory = @"C:\DataSprint7\New";
                if (saveFileDialogMain_KNS.ShowDialog() == DialogResult.OK)
                {
                    string savepatch = saveFileDialogMain_KNS.FileName;

                    if (File.Exists(savepatch)) File.Delete(savepatch);

                    int rows = dataGridViewOutPut_KNS.RowCount;
                    int columns = dataGridViewOutPut_KNS.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(dataGridViewOutPut_KNS.Rows[i].Cells[j].Value);

                            if (j != columns - 1) strBuilder.Append(",");
                        }
                        strBuilder.AppendLine();
                    }
                    File.WriteAllText(savepatch, strBuilder.ToString(), Encoding.GetEncoding(1251));
                    MessageBox.Show("Файл успешно сохранен на ваш компьютер", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Файл не был сохранен на ваш компьютер", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_KNS_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewOutPut_KNS.RowCount; i++)
            {
                dataGridViewOutPut_KNS.Rows[i].Selected = false;
                for (int j = 0; j < dataGridViewOutPut_KNS.ColumnCount; j++)
                    if (dataGridViewOutPut_KNS.Rows[i].Cells[j].Value != null)
                        if (dataGridViewOutPut_KNS.Rows[i].Cells[j].Value.ToString().Contains(textBoxSearch_KNS.Text))
                        {
                            dataGridViewOutPut_KNS.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void buttonCalculateSquare_KNS_Click(object sender, EventArgs e)
        {
            int c = 0;
            for (int i = 0; i < dataGridViewOutPut_KNS.ColumnCount; i++)
            {
                c += Convert.ToInt32(dataGridViewOutPut_KNS.Rows[i].Cells[2].Value);
            }


            int rows = dataGridViewOutPut_KNS.RowCount - 1;
            double avg = c / rows;
            avg = Math.Round(avg, 3);                           //Подсчет среднего значения площади
            textBoxSquare_KNS.Text = c.ToString();
        }

        private void buttonCalculatePopulation_KNS_Click(object sender, EventArgs e)
        {
            int c = 0;
            for (int i = 0; i < dataGridViewOutPut_KNS.Rows.Count; i++)
            {
                c += Convert.ToInt32(dataGridViewOutPut_KNS.Rows[i].Cells[3].Value);
            }
            textBoxPopulation_KNS.Text = c.ToString();
        }

        private void buttonBuildGrafic_KNS_Click(object sender, EventArgs e)
        {
            chartPopulation_KNS.Series[0].Points.Clear();

            foreach (DataGridViewRow row in dataGridViewOutPut_KNS.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    string xValue = row.Cells[0].Value.ToString();
                    double yValue = Convert.ToDouble(row.Cells[3].Value);

                    chartPopulation_KNS.Series["Legend"].Points.AddXY(xValue, yValue);
                }
            }
        }
    }
}
