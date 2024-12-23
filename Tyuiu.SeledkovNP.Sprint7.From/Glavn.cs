
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
            // ������ ���� Saev_menu
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
            // ������ ���� Info
            Info formAbout = new Info();
            formAbout.ShowDialog();
        }

        private void LoadExcelFile(string filePath)
        {
            try
            {
                // �������� ���������� Excel ����������
                Excel.Application excelApp = new Excel.Application();

                // �������� ������� �����
                Excel.Workbook workbook = excelApp.Workbooks.Open(filePath);

                // ��������� ������� �����
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

                // ����������� ������ ����� � ��������������
                int rowCount = worksheet.UsedRange.Rows.Count;
                int colCount = worksheet.UsedRange.Columns.Count;

                // ������������� ������ ��� �����������
                string[,] data = new string[rowCount + 1, colCount + 1];

                // ���������� ������� ������� �� �����
                for (int i = 1; i <= rowCount; i++)
                {
                    for (int j = 1; j <= colCount; j++)
                    {
                        data[i, j] = worksheet.Cells[i, j].Value.ToString(); // Value ����������� ����� ��� �����
                    }
                }

                // ������� textBox_SNP � ���������� ������
                textBox_SNP.Text = "";
                for (int i = 1; i <= rowCount; i++)
                {
                    for (int j = 1; j <= colCount; j++)
                    {
                        textBox_SNP.Text += data[i, j] + "\t";
                    }
                    textBox_SNP.Text += Environment.NewLine;
                }

                // �������� ������� ����� � ���������� ������ Excel
                workbook.Close(false);
                excelApp.Quit();
            }
            finally
            {
                // ������������ COM ��������

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
            // ����� ����� ���������� ��������� ������ � textBox_SNP
            MessageBox.Show("���������� textBox_SNP ����������.");
        }


    }
}
