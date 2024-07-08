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
    public partial class Motor15 : Form
    {

        public Motor15()
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

            

            if (baslangic > bitis)
            {
                MessageBox.Show("Baslangic tarihiniz bitis tarihinizden sonra olamaz");
            }

            while (baslangic <= bitis)
            {
                if(baslangic.Month == 4 )
                {
                    
                    baslangic=baslangic.AddDays(1);
                    toplam_ücret = toplam_ücret + 900;
                    
                }
                 else if (baslangic.Month == 5)
                {
                    
                    baslangic = baslangic.AddDays(1);
                    toplam_ücret = toplam_ücret + 1000;
                    
                }
                else if (baslangic.Month == 6)
                {
                    
                    baslangic = baslangic.AddDays(1);
                    toplam_ücret = toplam_ücret + 1100;
                    
                }
                else if (baslangic.Month == 7)
                {
                    
                    baslangic = baslangic.AddDays(1);
                    toplam_ücret = toplam_ücret + 1200;
                    
                }
                else if (baslangic.Month == 8)
                {
                    
                    baslangic = baslangic.AddDays(1);
                    toplam_ücret = toplam_ücret + 1200;
                    
                }
                else if (baslangic.Month == 9)
                {
                    
                    baslangic = baslangic.AddDays(1);
                    toplam_ücret = toplam_ücret + 1100;
                    
                }
                else if (baslangic.Month == 10)
                {
                    
                    baslangic = baslangic.AddDays(1);
                    toplam_ücret = toplam_ücret + 1000;
                    
                }
                else
                {
                    MessageBox.Show("Lütfen Nisan ve Ekim arasında bir tarih seciniz");
                }

            }
            MessageBox.Show("toplam ücretiniz"+ " " + toplam_ücret +" "+ "TLdir");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
