using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BankingApplication
{
    public partial class frmNewAccount : Form
    {
        public frmNewAccount()
        {
            InitializeComponent();
        }
        Random random = new Random();
        private void frmNewAccount_Load(object sender, EventArgs e)
        {
            cbxAccountType.SelectedIndex = 0;
            SonIdGetir();
            HesapNoOlustur();
        }

        void SonIdGetir()
        {
            StreamWriter streamWriter = new StreamWriter("Hesaplar.txt", true);
            streamWriter.Close();
            StreamReader streamReader = new StreamReader("Hesaplar.txt");
            string satirOku = streamReader.ReadLine();
            string sonMusteriId = "";

            if (satirOku == null)
            {
                tbxClientId.Text = "1";
            }

            else
            {
                while (satirOku != null)
                {
                    string[] satir = satirOku.Split(';');
                    sonMusteriId = satir[0].ToString();

                    satirOku = streamReader.ReadLine();
                }
                tbxClientId.Text = ((Convert.ToInt32(sonMusteriId) + 1)).ToString();

            }
            streamReader.Close();

        }

        private bool HesapVarMi()
        {
            StreamWriter streamWriter = new StreamWriter("Hesaplar.txt", true);
            streamWriter.Close();
            StreamReader streamReader = new StreamReader("Hesaplar.txt");
            string satirOku = streamReader.ReadLine();
            string sonHesapNo = "";

            if (satirOku == null)
            {
                tbxAccountNumber.Text = "ACC1000";
            }

            else
            {
                tbxAccountNumber.Text = "ACC" + random.Next(1000, 9999);

                while (satirOku != null)
                {
                    string[] satir = satirOku.Split(';');
                    if (tbxAccountNumber.Text == satir[1].ToString())
                    {
                        streamReader.Close();
                        return true;
                    }
                    sonHesapNo = satir[1].ToString();

                    satirOku = streamReader.ReadLine();
                }

            }
            streamReader.Close();

            return false;
        }

        private void HesapNoOlustur()
        {
            do
            {
                HesapVarMi();
            } while (HesapVarMi());
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public void btnOpenAccount_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("Hesaplar.txt", true);
            string MusteriId = tbxClientId.Text;
            string HesapNo = tbxAccountNumber.Text;
            string Ad = tbxName.Text;
            string Soyad = tbxSurname.Text;
            string Tarih = dtpOpeningDate.Value.ToShortDateString();
            long KimlikNo = Convert.ToInt64(tbxIdentificationNumber.Text);
            double Bakiye = Convert.ToDouble(tbxRemainingBalance.Text);
            string HesapTürü = cbxAccountType.SelectedItem.ToString();

            StreamWriter HesapHareketi = new StreamWriter("HesapHareketleri.txt", true);
            HesapHareketi.WriteLine(MusteriId + ';' + HesapNo + ';' + Tarih + ';' + Bakiye + ';' + HesapTürü + "Yatırma İşlemi");
            HesapHareketi.Close();

            streamWriter.WriteLine(MusteriId + ';' + HesapNo + ';' + Ad + ';' + Soyad + ';' + Tarih + ';' + KimlikNo + ';' + Bakiye + ';' + HesapTürü + ';' + "Yatırma İşlemi");
            streamWriter.Close();
            MessageBox.Show("Yeni Hesap Açıldı!");

            Temizle();

            SonIdGetir();

            HesapNoOlustur();
        }

        private void Temizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.ResetText();
                }
            }
        }
    }
}
