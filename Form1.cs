using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YapisalTekneOdev
{
    public partial class Form1 : Form
    {
        private string ad;
        private string soyad;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hosgeldin"+" "+ad+" "+soyad+" "+"lütfen tekne kiralamak için secimlerinizi yapiniz");
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start("excel.exe","Bilgilendirme");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ad = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            soyad = textBox2.Text;
        }
    }
}
