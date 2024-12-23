
using System.Formats.Asn1;
using System.Security.Cryptography;
using Tyuiu.SeledkovNP.Sprint7.Lib;

namespace Tyuiu.SeledkovNP.Sprint7.From
{

    public partial class Glavn : Form
    {
        public Glavn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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


        private void Open_Click(object sender, EventArgs e)
        {


        }

        private void Info_Click(object sender, EventArgs e)
        {
            // Открыт меню Info
            Info formAbout = new Info();
            formAbout.ShowDialog();
        }
    }
}
