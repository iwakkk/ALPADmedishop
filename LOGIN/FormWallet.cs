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
    public partial class FormWallet : Form
    {
        public FormWallet()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picBoxWallet.BackColor = Color.Transparent;
            lblHeader.Parent = picBoxWallet;
            label2.Parent = picBoxWallet;
            label1.Parent = picBoxWallet;
            lblNumber.Parent = picBoxWallet;
            label2.BackColor = Color.Transparent;
            lblNumber.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            lblHeader.BackColor = Color.Transparent;
        }

        private void txtBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
