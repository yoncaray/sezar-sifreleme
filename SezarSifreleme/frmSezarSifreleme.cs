using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SezarSifreleme
{
    public partial class frmSezarSifreleme : Form
    {
        public frmSezarSifreleme()
        {
            InitializeComponent();
        }

        string alfabe;
        int kaydirmaSayisi;
        int alfabeSayisi;

        private void frmSezarSifreleme_Load(object sender, EventArgs e)
        {
            cmbDil.SelectedIndex = 0;
        }

        private void cmbDil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDil.SelectedIndex == 0)
            {
                lblSonra.Text = lblOnce.Text = "a b c ç d e f g ğ h ı i j k l m n o ö p r s ş t u ü v y z";
                alfabe = "abcçdefgğhıijklmnoöprsştuüvyz";
                alfabeSayisi = 29;
            }
            if (cmbDil.SelectedIndex == 1) 
            {
                lblSonra.Text = lblOnce.Text = "a b c d e f g h i j k l m n o p q r s t u v w x y z";
                alfabe = "abcdefghijklmnopqrstuvwxyz";
                alfabeSayisi = 26;
            }
        }

        private void btnSifrele_Click(object sender, EventArgs e)
        {
            string kaydirma = "";          
            kaydirmaSayisi = int.Parse(txtKaydirmaSayisi.Text);
            for (int i = kaydirmaSayisi; i < alfabeSayisi + kaydirmaSayisi; i++)
                kaydirma += alfabe[i % alfabeSayisi] + " ";
            lblSonra.Text = kaydirma;

            string sifrelenecekMetin, sifrelenmisMetin = "";
            sifrelenecekMetin = txtSifrelenecekMetin.Text;
            for (int i = 0; i < sifrelenecekMetin.Length; i++)
            {
                int sayac = 0;
                for (int j = 0; j < alfabeSayisi; j++)
                {
                    if (sifrelenecekMetin[i] == alfabe[j])
                    {
                        sifrelenmisMetin += alfabe[(j + kaydirmaSayisi) % alfabeSayisi];
                        sayac++;
                    }
                }
                if (sayac == 0) sifrelenmisMetin += " ";
            }
            txtSifrelenmisMetin.Text = sifrelenmisMetin;
        }

        private void txtSifrelenecekMetin_TextChanged(object sender, EventArgs e)
        {
            txtSifrelenecekMetin.Text = txtSifrelenecekMetin.Text.ToLower();
            txtSifrelenecekMetin.SelectionStart = txtSifrelenecekMetin.Text.Length;
        }

        int sayac = 0;
        private void txtSifrelenecekMetin_MouseClick(object sender, MouseEventArgs e)
        {
            if (sayac == 0)
            {
                txtSifrelenecekMetin.Text = "";
                txtSifrelenmisMetin.Text = "";
                txtKaydirmaSayisi.Text = "";
                sayac++;
            }
        }
    }
}
