using System.Security.Cryptography.Pkcs;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click_2(object sender, EventArgs e)
        {
            int toplam = 0;
            int son = Convert.ToInt32(textBox2.Text);
            for (int a = 1; a <= son;a++)
            {
                if (a % 2 == 0)
                {
                    toplam = toplam + a;
                }
            }
            sayılar.Items.Add(toplam);
        }



        private void sayılar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
