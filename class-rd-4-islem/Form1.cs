using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_rd_4_islem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        İslem islem = new İslem();


        private void btnHesapla_Click(object sender, EventArgs e)
        {
            islem.sayi1 = Convert.ToInt32(txtSayi1.Text);
            islem.sayi2 = Convert.ToInt32(txtSayi2.Text);

            if (rbTopla.Checked)
            {
                lblSonuc.Text = "Toplam" + islem.Topla();
            }
            else if (rbCikar.Checked)
            {
                lblSonuc.Text="Çıkar"+islem.Cikar();
            }
            else if (rbCarp.Checked)
            {
                lblSonuc.Text = "Fark" + islem.Carp();
            }
            else
            {
                lblSonuc.Text = "Bölüm" + islem.Bol();
            }
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            txtSayi1.Clear();
            txtSayi2.Clear();

            if (rbTopla.Checked)
            {
                listBox1.Items.Add("Toplam:"+islem.Topla());
            }
            else if (rbCikar.Checked)
            {
                listBox1.Items.Add("Çıkan:" + islem.Cikar());
            }
            else if (rbCarp.Checked)
            {
                listBox1.Items.Add("Fark:" + islem.Carp());
            }
            else
            {
                listBox1.Items.Add("Bolüm:" + islem.Bol());
            }
        }
    }
}
