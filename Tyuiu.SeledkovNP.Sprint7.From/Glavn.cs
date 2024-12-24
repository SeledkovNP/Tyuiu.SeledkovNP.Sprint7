
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
            // ������ ���� Info
            Info formAbout = new Info();
            formAbout.ShowDialog();
        }

        private void Button_save_Click(object sender, EventArgs e)
        {
            // ������ ���� Saev_menu
            Saev_menu formAbout = new Saev_menu();
            formAbout.ShowDialog();
        }


        private void textBox_SNP_TextChanged(object sender, EventArgs e)
        {
            // ����� ����� ���������� ��������� ������ � textBox_SNP
            MessageBox.Show("���������� textBox_SNP ����������.");
        }

        /*  private void Open_Click_1(object sender, EventArgs e)
          {
              try
              {
                  // �������� ����������� ���� ������ �����
                  OpenFileDialog openFileDialog = new OpenFileDialog();
                  openFileDialog.Filter = "CSV ����� (*.csv)|*.csv|��� ����� (*.*)|*.*";
                  openFileDialog.Title = "�������� CSV ����";

                  // ��������, ������ �� ������������ ����
                  if (openFileDialog.ShowDialog() == DialogResult.OK)
                  {
                      // ��������� ���� � ���������� �����
                      string filePath = openFileDialog.FileName;

                      // �������� ���������� StreamReader ��� ������ ����� CSV
                      using (StreamReader reader = new StreamReader(filePath))
                      {
                          // ����������� ������ ����� � ��������������
                          string headers = reader.ReadLine(); // ������ ������ ������ ��� ���������� ��������
                          if (!string.IsNullOrEmpty(headers))
                          {
                              string[] headersArray = headers.Split(','); // ���������� ������ ������ �� ���������

                              int rowCount = 0; // ���������� �����

                              // ������������� ������ ��� �����������
                              string[,] data = new string[0, headersArray.Length]; // ������ ������ ��� ������

                              // ������ ���������� ����� � ���������� �������
                              while (!reader.EndOfStream)
                              {
                                  string rowData = reader.ReadLine(); // ������ ������� ������
                                  if (!string.IsNullOrEmpty(rowData))
                                  {
                                      string[] rowDataArray = rowData.Split(','); // ���������� ������� ������

                                      rowCount++; // ���������� ���������� �����

                                      // ���������� ������� ������� �� ������
                                      for (int i = 0; i < rowDataArray.Length; i++)
                                      {
                                          data[rowCount, i] = rowDataArray[i].Trim(); // Trim ������� ������ �������
                                      }
                                  }
                              }

                              // ������� textBox_SNP � ���������� ������
                              textBox_SNP.Text = "";

                              // ����� ������ � textBox_SNP
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
                              MessageBox.Show("������ ������ ����� ����� ��� �����������.");
                          }
                      }
                  }
              }
              catch (Exception ex)
              {
                  MessageBox.Show("������ ��� ������ CSV �����: " + ex.Message);

              }
          }*/




        //--------------------------------------------------------------------------------
        //       ����� �����                 OpenFile    ---    OpenFiles
        //--------------------------------------------------------------------------------

        private void Open_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "CSV ����� (*.csv)|*.csv|��� ����� (*.*)|*.*";
                openFileDialog.Title = "�������� ���� ��� ��������";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        string[,] arrayValues = ds.LoadFromFileData(filePath);

                        System.Data.DataTable dataTable = new System.Data.DataTable();

                        dataTable.Columns.Add("����� "); // ��� ������� ����� ���������
                        dataTable.Columns.Add("��� ");
                        dataTable.Columns.Add("����� ");
                        dataTable.Columns.Add("��������� ");
                        dataTable.Columns.Add("��� ");
                        dataTable.Columns.Add("������� ");
                        dataTable.Columns.Add("������� ");
                        dataTable.Columns.Add("��������� ");



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
                        MessageBox.Show("������: " + ex.Message);
                    }
                    catch (FormatException ex)
                    {
                        MessageBox.Show("������ �������: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("��������� ������: " + ex.Message);
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

            // ����� ������� ����������� ����� ������ ��������
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
            // ������� ����� ������ ��� ������ ������
            if (string.IsNullOrEmpty(textPois.Text) && textPois.Focused == false)
            {

                string Perin = textPois.Text;
                return;
            }

            // �������� ����� ������ ��� ��������� ������
            Poisk_Click(sender, e);
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
