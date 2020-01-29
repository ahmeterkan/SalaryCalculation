using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maashesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (txtNetMaas.Text!="")
            {
                double tahminiBrut = 0;
                double brutMaas = 0;
                maasHesapla mH = new maasHesapla();
                mH.netMaas = Convert.ToDouble(txtNetMaas.Text);
                tahminiBrut = mH.netMaas * 1.5;
                brutMaas = mH.netMaasHesapla(tahminiBrut);
                MessageBox.Show("Brüt Maaş:" + brutMaas.ToString() + " TL");
            }
            else
            {
                MessageBox.Show("Lütfen net maaşı giriniz.");
            }


        }

        private void txtNetMaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
