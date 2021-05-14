using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuNewAccount_Click(object sender, EventArgs e)
        {
            frmNewAccount _frmNewAccount = new frmNewAccount();
            _frmNewAccount.Show();
        }

        private void menuAccountStatement_Click(object sender, EventArgs e)
        {
            frmAccountStatement _frmAccountStatement = new frmAccountStatement();
            _frmAccountStatement.Show();
        }
    }
}
