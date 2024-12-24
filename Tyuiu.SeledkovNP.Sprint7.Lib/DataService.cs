using tyuiu.cources.programming.interfaces.Sprint77;
namespace Tyuiu.SeledkovNP.Sprint7.Lib
{
    public class DataService
    {
        
        public string[,] OpenFiles(string path)
        {
            int rows;
             int columns;
             string FileData = File.ReadAllText(path);
             FileData = FileData.Replace('\n', '\r');

             string[] lines = FileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
             rows = lines.Length;
             columns = lines[0].Split(';').Length;

             string[,] array = new string[rows, columns];
             int k = 0;
             using (StreamReader sr = new StreamReader(path))
             {
                 string line;
                 while ((line = sr.ReadLine()) != null)
                 {
                     string[] l = line.Split(';');
                     for (int i = 0; i < l.Length; i++)
                     {
                         array[k, i] = l[i].Trim();
                     }
                     k++;
                 }
             }
             return array;

        }

        public string[,] LoadFromFileData(string filepath)
        {
            // Проверка
            if (!File.Exists(filepath))
            {
                throw new FileNotFoundException("Файл не найден.", filepath);
            }


            string[] lines = File.ReadAllLines(filepath);

            int rows = lines.Length;
            int columns = lines[0].Split(',').Length;

            string[,] data = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(',');

                if (values.Length != columns)
                {
                    throw new FormatException("Некорректный формат данных в строке: " + lines[i]);
                }

                for (int j = 0; j < columns; j++)
                {
                    data[i, j] = values[j];
                }
            }

            return data;
        }




    }
}
