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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Guletcb1.Checked && !Guletcb2.Checked && !Guletcb3.Checked)
            {
                MessageBox.Show("Lütfen Devam Etmek İcin Teknenizin Boy secimini Yapiniz!!");
            }

            else if (MYcb1.Checked || MYcb2.Checked || MYcb3.Checked)
            {
                MessageBox.Show("Lütfen Sadece Sectiğiniz Teknenin Boyunu Giriniz");
            }

            else if (Guletcb1.Checked)
            {
                Gulet14 f3 = new Gulet14();
                f3.Show();
                this.Hide();
            }
            else if (Guletcb2.Checked)
            {
                Gulet15 f4 = new Gulet15();
                f4.Show();
                this.Hide();
            }
            else if (Guletcb3.Checked)
            {
                Gulet16 f5 = new Gulet16();
                f5.Show();
                this.Hide();
            }

        }


        private void Guletcb1_CheckedChanged(object sender, EventArgs e)
        {
            if (Guletcb1.Checked)
            {
                
                Guletcb2.Enabled = false;
                Guletcb3.Enabled = false;
            }
            else
            {
                Guletcb2.Enabled = true;
                Guletcb3.Enabled = true;
            }
        }

        private void Guletcb2_CheckedChanged(object sender, EventArgs e)
        {
            if (Guletcb2.Checked)
            {
                
                Guletcb1.Enabled = false;
                Guletcb3.Enabled = false;
            }
            else
            {
                Guletcb1.Enabled = true;
                Guletcb3.Enabled = true;
            }
        }

        private void Guletcb3_CheckedChanged(object sender, EventArgs e)
        {
            if (Guletcb3.Checked)
            {
                
                Guletcb2.Enabled = false;
                Guletcb1.Enabled = false;
            }
            else
            {
                Guletcb2.Enabled = true;
                Guletcb1.Enabled = true;
            }
        }


        private void MYcb1_CheckedChanged(object sender, EventArgs e)
        {
            if (MYcb1.Checked)
            {
                MYcb2.Enabled = false;
                MYcb3.Enabled = false;
            }
            else
            {
                MYcb2.Enabled = true;
                MYcb3.Enabled = true;
            }
        }

        private void MYcb2_CheckedChanged(object sender, EventArgs e)
        {
            if (MYcb2.Checked)
            {
                MYcb1.Enabled = false;
                MYcb3.Enabled = false;
            }
            else
            {
                MYcb1.Enabled = true;
                MYcb3.Enabled = true;
            }
        }

        private void Mycb3_CheckedChanged(object sender, EventArgs e)
        {
            if (MYcb3.Checked)
            {
                MYcb2.Enabled = false;
                MYcb1.Enabled = false;
            }
            else
            {
                MYcb2.Enabled = true;
                MYcb1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!MYcb1.Checked && !MYcb2.Checked && !MYcb3.Checked)
            {
                MessageBox.Show("Lütfen Devam Etmek İcin Teknenizin Boy secimini Yapiniz!!");
            }
            else if(Guletcb1.Checked || Guletcb2.Checked || Guletcb3.Checked)
            {
                MessageBox.Show("Lütfen Sadece Sectiğiniz Teknenin Boyunu Giriniz");
            }
            else if (MYcb1.Checked)
            {
                Motor14 f6 = new Motor14();
                f6.Show();
                this.Hide();
            }
            else if (MYcb2.Checked)
            {
                Motor15 f7 = new Motor15();
                f7.Show();
                this.Hide();
            }
            else if (MYcb3.Checked)
            {
                Motor16 f8 = new Motor16();
                f8.Show();
                this.Hide();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
