namespace Tyuiu.KorotkovNS.Sprint7.Project.V13.Lib
{
    public class DataService
    {
        public string[,] GetMatrix(string path)
        {
            // Чтение файла 
            string fileData = File.ReadAllText(path);

            // Разделение полученных данных на строки  
            string[] lines = fileData.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            // Количество строк и столбцов  
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length; // Предполагаем, что все строки имеют одинаковое количество столбцов  

            // Сам массив  
            string[,] mas = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    mas[i, j] = values[j].Trim();    
                }
            }

            return mas;
        }
        public double avgSquare(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            double avg = 0;

            for(int i = 0;i < rows;i++)
            {
                avg += matrix[i, 3];
            }
            avg = avg / rows;
            return Math.Round(avg, 3);
        }



    }
}
