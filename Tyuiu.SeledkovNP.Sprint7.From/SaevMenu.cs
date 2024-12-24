using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.SeledkovNP.Sprint7.From
{
    public partial class Saev_menu : Form
    {
        public Saev_menu()
        {
            InitializeComponent();
        }

        private void Saev_menu_Load(object sender, EventArgs e)
        {

        }

        private void Closed_Click(object sender, EventArgs e)
        {
            // Создаем новый экземпляр класса Random
            Random random = new Random();

            // Генерируем случайные координаты x и y в пределах клиентской области формы
            int x = random.Next(this.ClientSize.Width);
            int y = random.Next(this.ClientSize.Height);

            // Перемещаем кнопку в случайное место
            Button button = (Button)sender;
            button.Location = new Point(x, y);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            // Сохранение

            saveFileDialog_SNP.FileName = "OutPutFileProjectV3.csv";
            saveFileDialog_SNP.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_SNP.ShowDialog();

                string path = saveFileDialog_SNP.FileName;

                FileInfo fileInfo = new FileInfo(path);
                bool exists = fileInfo.Exists;
                if (exists)
                {
                    File.Delete(path);
                }
            




        }
    }
}
