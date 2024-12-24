
using Microsoft.Office.Interop.Excel;
using System.Data;
using System.Formats.Asn1;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using Tyuiu.SeledkovNP.Sprint7.Lib;
using Excel = Microsoft.Office.Interop.Excel;

namespace Tyuiu.SeledkovNP.Sprint7.From
{

    public partial class Glavn : Form
    {
        DataService ds = new DataService();
        private int rows;
        private int columns;
        private SaveFileDialog saveFileDialogExport;
        private OpenFileDialog openFileDialogImport;
        public Glavn()
        {
            InitializeComponent();
        }


        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Glavn_Load(object sender, EventArgs e)
        {

        }

        private void Info_Click(object sender, EventArgs e)
        {
            // Открыт меню Info
            Info formAbout = new Info();
            formAbout.ShowDialog();
        }

        private void Button_save_Click(object sender, EventArgs e)
        {
            // Открыт меню Saev_menu
            Saev_menu formAbout = new Saev_menu();
            formAbout.ShowDialog();
        }


        private void textBox_SNP_TextChanged(object sender, EventArgs e)
        {
            // Здесь можно обработать изменения текста в textBox_SNP
            MessageBox.Show("Содержимое textBox_SNP изменилось.");
        }

        /*  private void Open_Click_1(object sender, EventArgs e)
          {
              try
              {
                  // Открытие диалогового окна выбора файла
                  OpenFileDialog openFileDialog = new OpenFileDialog();
                  openFileDialog.Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";
                  openFileDialog.Title = "Выберите CSV файл";

                  // Проверка, выбрал ли пользователь файл
                  if (openFileDialog.ShowDialog() == DialogResult.OK)
                  {
                      // Получение пути к выбранному файлу
                      string filePath = openFileDialog.FileName;

                      // Создание экземпляра StreamReader для чтения файла CSV
                      using (StreamReader reader = new StreamReader(filePath))
                      {
                          // Определение границ ячеек и форматирование
                          string headers = reader.ReadLine(); // Чтение первой строки как заголовков столбцов
                          if (!string.IsNullOrEmpty(headers))
                          {
                              string[] headersArray = headers.Split(','); // Разделение первой строки на заголовки

                              int rowCount = 0; // Количество строк

                              // Инициализация строки для отображения
                              string[,] data = new string[0, headersArray.Length]; // Пустой массив для начала

                              // Чтение оставшихся строк и заполнение массива
                              while (!reader.EndOfStream)
                              {
                                  string rowData = reader.ReadLine(); // Чтение текущей строки
                                  if (!string.IsNullOrEmpty(rowData))
                                  {
                                      string[] rowDataArray = rowData.Split(','); // Разделение текущей строки

                                      rowCount++; // Увеличение количества строк

                                      // Заполнение массива данными из строки
                                      for (int i = 0; i < rowDataArray.Length; i++)
                                      {
                                          data[rowCount, i] = rowDataArray[i].Trim(); // Trim удаляет лишние пробелы
                                      }
                                  }
                              }

                              // Очистка textBox_SNP и добавление данных
                              textBox_SNP.Text = "";

                              // Вывод данных в textBox_SNP
                              for (int i = 1; i <= rowCount; i++)
                              {
                                  for (int j = 0; j < headersArray.Length; j++)
                                  {
                                      textBox_SNP.Text += data[i, j] + "\t";
                                  }
                                  textBox_SNP.Text += Environment.NewLine;
                              }
                          }
                          else
                          {
                              MessageBox.Show("Первая строка файла пуста или некорректна.");
                          }
                      }
                  }
              }
              catch (Exception ex)
              {
                  MessageBox.Show("Ошибка при чтении CSV файла: " + ex.Message);

              }
          }*/




        //--------------------------------------------------------------------------------
        //       КОПИЯ КОПИИ                 OpenFile    ---    OpenFiles
        //--------------------------------------------------------------------------------

        private void Open_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "CSV файлы (*.csv)|*.csv|Все файлы (*.*)|*.*";
                openFileDialog.Title = "Выберите файл для загрузки";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        string[,] arrayValues = ds.LoadFromFileData(filePath);

                        System.Data.DataTable dataTable = new System.Data.DataTable();

                        dataTable.Columns.Add("Номер "); // Имя столбца можно настроить
                        dataTable.Columns.Add("ФИО ");
                        dataTable.Columns.Add("Адрес ");
                        dataTable.Columns.Add("Должность ");
                        dataTable.Columns.Add("КОД ");
                        dataTable.Columns.Add("Предмет ");
                        dataTable.Columns.Add("Кафедра ");
                        dataTable.Columns.Add("Аудитория ");



                        for (int i = 0; i < arrayValues.GetLength(0); i++)
                        {
                            DataRow row = dataTable.NewRow();
                            for (int j = 0; j < arrayValues.GetLength(1); j++)
                            {
                                row[j] = arrayValues[i, j];
                            }
                            dataTable.Rows.Add(row);
                        }
                        dataGridViewMainGrid.DataSource = dataTable;
                    }
                    catch (FileNotFoundException ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("Ошибка формата: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Произошла ошибка: " + ex.Message);
                    }
                }
            }
            button_save_SN.Enabled = true;

        }

        private void dataGridViewMainGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Poisk_Click(object sender, EventArgs e)
        {
            string searchValue = textPois.Text;

            // Метод который обозначаеть Поиск Строку столбцом
            foreach (DataGridViewRow row in dataGridViewMainGrid.Rows)
            {
                bool found = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(searchValue))
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        private void textPois_TextChanged(object sender, EventArgs e)
        {
            // Очищаем текст поиска при потере фокуса
            if (string.IsNullOrEmpty(textPois.Text) && textPois.Focused == false)
            {

                string Perin = textPois.Text;
                return;
            }

            // Вызываем метод поиска при изменении текста
            Poisk_Click(sender, e);
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
