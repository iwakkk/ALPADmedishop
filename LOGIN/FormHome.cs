using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnWallets_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormWallet formWallet = new FormWallet();
            formWallet.Show();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            picBoxWallet.BackColor = Color.Transparent;
            lblHeader.Parent = picBoxWallet;
            label3.Parent = picBoxHello;
            label2.Parent = picBoxWallet;
            label1.Parent = picBoxWallet;
            label4.Parent = picBoxHello;
            label5.Parent = picBoxHello;
            lblNumber.Parent = picBoxWallet;
            label5.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            lblNumber.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            lblHeader.BackColor = Color.Transparent;

            label5.Text = label5.Text.Replace("User", FormLogin.firstname);
        }

        private void btnGetStarted_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
