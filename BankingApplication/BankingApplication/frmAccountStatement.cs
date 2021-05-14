using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication
{
    public partial class frmAccountStatement : Form
    {
        public frmAccountStatement()
        {
            InitializeComponent();
        }

        private void frmAccountStatement_Load(object sender, EventArgs e)
        {

        }

        public static string MusteriId = "";
        public static string HesapNo = "";

        private void HesapHareketleri_Goster()
        {
            int sayac = 0;
            lvAccountStatement.Items.Clear();
            StreamReader hesapOku = new StreamReader("Hesaplar.txt");
            string satirOku = hesapOku.ReadLine();
            while (satirOku != null)
            {
                string[] okunan = satirOku.Split(';');
                if (tbxAccountNumberStatement.Text == okunan[1].ToString())
                {
                    lvAccountStatement.Items.Add(okunan[0]);
                    lvAccountStatement.Items[sayac].SubItems.Add(okunan[1]);
                    lvAccountStatement.Items[sayac].SubItems.Add(okunan[4]);
                    lvAccountStatement.Items[sayac].SubItems.Add(okunan[6]);
                    lvAccountStatement.Items[sayac].SubItems.Add(okunan[8]);
                    lvAccountStatement.Items[sayac].SubItems.Add(okunan[7]);

                    sayac++;
                }
                satirOku = hesapOku.ReadLine();


            }
            hesapOku.Close();
        }

        private void Toplamları_Goster()
        {
            int cekilenToplam = 0;
            int yatirilanToplam = 0;
            int bakiye = 0;
            for (int i = 0; i < lvAccountStatement.Items.Count; i++)
            {
                if (lvAccountStatement.Items[i].SubItems[4].Text == "Yatırma İşlemi")
                {
                    yatirilanToplam += Convert.ToInt32(lvAccountStatement.Items[i].SubItems[3].Text);
                }
                else if (lvAccountStatement.Items[i].SubItems[4].Text == "Çekme İşlemi")
                {
                    yatirilanToplam += Convert.ToInt32(lvAccountStatement.Items[i].SubItems[3].Text);
                }

                bakiye = yatirilanToplam - cekilenToplam;

            }
            tbxWithdrawnMoney.Text = cekilenToplam.ToString();
            tbxMoneyDeposited.Text = yatirilanToplam.ToString();
            tbxRemainder.Text = bakiye.ToString();
        }

        private void btnSearchAccount_Click(object sender, EventArgs e)
        {
            HesapHareketleri_Goster();
            Toplamları_Goster();

            StreamReader hesapOku = new StreamReader("Hesaplar.txt");
            string satirOku = hesapOku.ReadLine();
            while (satirOku != null)
            {
                string[] okunan = satirOku.Split(';');
                if (tbxAccountNumberStatement.Text == okunan[1].ToString())
                {
                    tbxNameStatement.Text = okunan[2];
                    tbxSurnameStatement.Text = okunan[3];
                    tbxIdentificationNumberStatement.Text = okunan[5];
                    tbxAccountTypeStatement.Text = okunan[7];
                }
                satirOku = hesapOku.ReadLine();
            }
        }

        private void btnDepositMoney_Click(object sender, EventArgs e)
        {
            MusteriId = lvAccountStatement.Items[0].SubItems[0].Text;
            HesapNo = lvAccountStatement.Items[0].SubItems[1].Text;

            frmMoneyTransactions paraIslemleri = new frmMoneyTransactions();
            paraIslemleri.ShowDialog();
            HesapHareketleri_Goster();
            Toplamları_Goster();
        }
    }
}
