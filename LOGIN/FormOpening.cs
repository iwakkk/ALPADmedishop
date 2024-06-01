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
    public partial class FormOpening : Form
    {
        public FormOpening()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCompanyTop.BackColor = Color.Transparent;
            lblCompanyBot.BackColor = Color.Transparent;
            lblHeader.BackColor = Color.Transparent;
            lbltext.BackColor = Color.Transparent;
            lblHeader.Parent = picBox1;
            lbltext.Parent = picBox1;
            lblCompanyTop.Parent = picBox1;
            lblCompanyBot.Parent = picBox1;
        }

        private void btnGetStarted_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            this.Hide();
            formLogin.Show();
        }
    }
}
