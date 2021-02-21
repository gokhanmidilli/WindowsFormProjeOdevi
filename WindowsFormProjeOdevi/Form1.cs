using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormProjeOdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ASAL SAYI BULMA

            int sayi, sonuc = 0;

            sayi = Convert.ToInt32(textBox1.Text);

            if (sayi == 1 || sayi == 0)
            {
                textBox2.Text = "SAYI ASAL DEĞİLDİR";

            }
            else
            {
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0) 
                    {
                        sonuc++;
                        break; 
                    }


                }

                if (sonuc != 0)
                {
                    textBox2.Text = "SAYI ASAL DEĞİLDİR";
                }

                else
                {
                    textBox2.Text = "SAYI ASALDIR";
                }

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // KAREKÖK HESAPLAMA

            double sayi, karakok;

            sayi = Convert.ToDouble(textBox1.Text);

            karakok = Math.Sqrt(sayi);

            textBox2.Text = karakok.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //FAKTÖRİYEL HESAPLAMA

            double sayi, faktoriyel = 1;

         
            sayi = Convert.ToDouble(textBox1.Text);

            if (sayi <= 1 && sayi != 0)
            {
                textBox2.Text = "Geçerli Bir sayı Giriniz";
            }
            else
            {
                for (int i = 1; i < sayi; i++)
                {
                    faktoriyel += faktoriyel * i;
                }
                textBox2.Text = faktoriyel.ToString();
            }

        }
    }
}
