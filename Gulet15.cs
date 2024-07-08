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
    public partial class Gulet15 : Form
    {

        public Gulet15()
        {
            InitializeComponent();
            DateTime baslangic = DateTime.Now;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime baslangic = dateTimePicker1.Value;
            DateTime bitis = dateTimePicker2.Value;
            int toplam_ücret = 0;

            //MessageBox.Show(baslangic.ToString("dd M yyyy"));

            if (baslangic > bitis)
            {
                MessageBox.Show("Baslangic tarihiniz bitis tarihinizden sonra olamaz");
            }

            while (baslangic <= bitis)
            {
                if (baslangic.Month == 4)
                {
                    
                    baslangic = baslangic.AddDays(1);
                    toplam_ücret = toplam_ücret + 5000;
                    
                }
                else if (baslangic.Month == 5)
                {
                    
                    baslangic = baslangic.AddDays(1);
                    toplam_ücret = toplam_ücret + 21000;
                    
                }
                else if (baslangic.Month == 6)
                {
                    
                    baslangic = baslangic.AddDays(1);
                    toplam_ücret = toplam_ücret + 22500;
                    
                }
                else if (baslangic.Month == 7)
                {
                    
                    baslangic = baslangic.AddDays(1);
                    toplam_ücret = toplam_ücret + 22500;
                    MessageBox.Show(toplam_ücret.ToString());
                }
                else if (baslangic.Month == 8)
                {
                    
                    baslangic = baslangic.AddDays(1);
                    toplam_ücret = toplam_ücret + 27000;
                    
                }
                else if (baslangic.Month == 9)
                {
                    
                    baslangic = baslangic.AddDays(1);
                    toplam_ücret = toplam_ücret + 22500;
                    
                }
                else if (baslangic.Month == 10)
                {
                    
                    baslangic = baslangic.AddDays(1);
                    toplam_ücret = toplam_ücret + 21000;
                    
                }
                else
                {
                    MessageBox.Show("Lütfen Nisan ve Ekim arasında bir tarih seciniz");
                }

            }
            MessageBox.Show("toplam ücretiniz" + " " + toplam_ücret + " " + "TLdir");
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
