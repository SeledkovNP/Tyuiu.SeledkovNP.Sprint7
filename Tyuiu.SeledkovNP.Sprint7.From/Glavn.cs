
using Microsoft.Office.Interop.Excel;
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
        public Glavn()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            // Открыт меню Saev_menu
            Saev_menu formAbout = new Saev_menu();
            formAbout.ShowDialog();
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

        private void LoadExcelFile(string filePath)
        {
            try
            {
                // Создание экземпляра Excel приложения
                Excel.Application excelApp = new Excel.Application();

                // Открытие рабочей книги
                Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);

                // Получение первого листа
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

                // Определение границ ячеек и форматирование
                int rowCount = worksheet.UsedRange.Rows.Count;
                int colCount = worksheet.UsedRange.Columns.Count;

                // Инициализация строки для отображения
                string[,] data = new string[rowCount + 1, colCount + 1];

                // Заполнение массива данными из ячеек
                for (int i = 1; i <= rowCount; i++)
                {
                    for (int j = 1; j <= colCount; j++)
                    {
                        data[i, j] = worksheet.Cells[i, j].Value.ToString(); // Value неизвестный метод или обект
                    }
                }

                // Очистка textBox_SNP и добавление данных
                textBox_SNP.Text = "";
                for (int i = 1; i <= rowCount; i++)
                {
                    for (int j = 1; j <= colCount; j++)
                    {
                        textBox_SNP.Text += data[i, j] + "\t";
                    }
                    textBox_SNP.Text += Environment.NewLine;
                }

                // Закрытие рабочей книги и завершение работы Excel
                workbook.Close(false);
                excelApp.Quit();
            }
            finally
            {
                // Освобождение COM объектов

                if (worksheet != null)
                {
                    Marshal.ReleaseComObject(worksheet);
                    worksheet = null;
                }
                if (workbook != null)
                {
                    Marshal.ReleaseComObject(workbook);
                    workbook = null;
                }
                if (excelApp != null)
                {
                    Marshal.ReleaseComObject(excelApp);
                    excelApp = null;
                }

            }
        }

        private void textBox_SNP_TextChanged(object sender, EventArgs e)
        {
            // Здесь можно обработать изменения текста в textBox_SNP
            MessageBox.Show("Содержимое textBox_SNP изменилось.");
        }


    }
}
