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
    public partial class frmMoneyTransactions : Form
    {
        public frmMoneyTransactions()
        {
            InitializeComponent();
        }

        private void btnYatir_Click(object sender, EventArgs e)
        {
            if (tbxTutar.Text != null && cbxIslemTuru.Items.ToString() != null)
            {
                StreamWriter streamWriter = new StreamWriter("HesapHareketleri.txt", true);
                streamWriter.WriteLine(tbxMusteriId.Text + ";" + tbxHesapNo.Text + ";" + dtpIslemTarihi.Value.ToShortDateString() + ";" +
                    tbxTutar.Text + ";" + cbxIslemTuru.SelectedItem.ToString());
                streamWriter.Close();
                this.Close();
            }


        }

        private void frmMoneyTransactions_Load(object sender, EventArgs e)
        {
            tbxMusteriId.Text = frmAccountStatement.MusteriId;
            tbxHesapNo.Text = frmAccountStatement.HesapNo;
        }
    }
}
