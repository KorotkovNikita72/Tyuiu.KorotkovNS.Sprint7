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
                    string savePath = saveFileDialogMain_KNS.FileName;

                    // Проверка существования файла и его удаление, если требуется  
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
                            // Проверка на null значение ячейки  
                            string cellValue = dataGridViewOutPut_KNS.Rows[i].Cells[j].Value?.ToString() ?? string.Empty;

                            // Замена кавычек внутри значения на две кавычки для CSV  
                            cellValue = cellValue.Replace("\"", "\"\"");

                            // Оборачиваем значение в кавычки  
                            strBuilder.Append($"\"{cellValue}\"");

                            // Добавляем разделитель только если это не последний элемент в строке  
                            if (j != columns - 1)
                            {
                                strBuilder.Append(","); // Разделяем значения запятой  
                            }
                        }
                        strBuilder.AppendLine(); // Конец строки  
                    }

                    // Запись данных в файл с кодировкой UTF-8  
                    File.WriteAllText(savePath, strBuilder.ToString(), Encoding.UTF8);

                    MessageBox.Show("Файл успешно сохранен на ваш компьютер", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) // Добавление информации об ошибке  
            {
                MessageBox.Show($"Ошибка: {ex.Message}\nФайл не был сохранен на ваш компьютер", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_KNS_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewOutPut_KNS.RowCount; i++)
            {
                dataGridViewOutPut_KNS.Rows[i].Selected = false; // Сброс выделения строки  
                                                                 // Проверка только в первом столбце (индекс 0)  
                if (dataGridViewOutPut_KNS.Rows[i].Cells[0].Value != null)
                {
                    if (dataGridViewOutPut_KNS.Rows[i].Cells[0].Value.ToString().Contains(textBoxSearch_KNS.Text, StringComparison.OrdinalIgnoreCase)) // Добавил сравнение без учета регистра  
                    {
                        dataGridViewOutPut_KNS.Rows[i].Selected = true; // Выбор строки  
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
            avg = Math.Round(avg, 3);                           //Подсчет среднего значения площади
            textBoxSquare_KNS.Text = avg.ToString();
        }

        private void buttonCalculatePopulation_KNS_Click(object sender, EventArgs e)
        {
            int c = 0;
            int min = int.MaxValue; // Инициализация минимального значения  
            int max = int.MinValue; // Инициализация максимального значения  

            for (int i = 0; i < dataGridViewOutPut_KNS.Rows.Count; i++)
            {
                // Проверка значения на null  
                if (dataGridViewOutPut_KNS.Rows[i].Cells[3].Value != null)
                {
                    int value = Convert.ToInt32(dataGridViewOutPut_KNS.Rows[i].Cells[3].Value);

                    // Суммирование значений  
                    c += value;

                    // Вычисление минимального значения  
                    if (value < min)
                    {
                        min = value;
                    }

                    // Вычисление максимального значения  
                    if (value > max)
                    {
                        max = value;
                    }
                }
            }

            // Форматирование текста для вывода: сумма / минимальное значение / максимальное значение
            textBoxPopulation_KNS.Text = $"{c} / {min} / {max}";
        }

        private void buttonBuildGrafic_KNS_Click(object sender, EventArgs e)
        {

            chartPopulation_KNS.Series["Series"].Points.Clear();
            chartPopulation_KNS.Series["Series2"].Points.Clear();// Очищаем предыдущие точки графика  

            double maxPopulation = double.MinValue; // Изначально наименьшее значение для максимума  
            double minPopulation = double.MaxValue; // Изначально наибольшее значение для минимума  
            string countryWithMax = string.Empty; // Страна с максимальным населением  
            string countryWithMin = string.Empty; // Страна с минимальным населением  

            // Пробежка по всем строкам DataGridView  
            foreach (DataGridViewRow row in dataGridViewOutPut_KNS.Rows)
            {
                // Проверка, что строка не является новой строкой и ячейки не null  
                if (!row.IsNewRow && row.Cells[0].Value != null && row.Cells[3].Value != null)
                {
                    string country = row.Cells[0].Value.ToString(); // Название страны  

                    // Преобразование значения на оси Y (население) с обработкой исключений  
                    if (double.TryParse(row.Cells[3].Value.ToString(), out double population))
                    {
                        // Находим максимальное и минимальное значения  
                        if (population > maxPopulation)
                        {
                            maxPopulation = population;
                            countryWithMax = country; // Обновляем страну с максимальным населением  
                        }
                        if (population < minPopulation)
                        {
                            minPopulation = population;
                            countryWithMin = country; // Обновляем страну с минимальным населением  
                        }
                    }
                }
            }

            // Добавление точки с максимальным населением  
            if (!string.IsNullOrEmpty(countryWithMax) && maxPopulation != double.MinValue)
            {
                chartPopulation_KNS.Series["Series"].Points.AddXY(countryWithMax + " (Max)", maxPopulation);
            }

            // Добавление точки с минимальным населением  
            if (!string.IsNullOrEmpty(countryWithMin) && minPopulation != double.MaxValue)
            {
                chartPopulation_KNS.Series["Series2"].Points.AddXY(countryWithMin + " (Min)", minPopulation);
            }

        }


    }
}
