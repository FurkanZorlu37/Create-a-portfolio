using System;
namespace _0._002_sanırım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Form2Name = txt_Name.Text;
            VeriTasiyici.TasinacakVeri = txt_Name.Text;
            Form2 yeniForm = new Form2();
            yeniForm.Show();
        }
    }
}
