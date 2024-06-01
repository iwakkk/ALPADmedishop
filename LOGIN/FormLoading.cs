using Guna.UI2.WinForms;
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
    public partial class FormLoading : Form
    {
        public FormLoading()
        {
            InitializeComponent();
        }

        private void FormLoading_Load(object sender, EventArgs e)
        {
            shdwForm.SetShadowForm(this);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (circleProgressBar.Value == 100)
            {
                timer1.Stop();
                FormHome formhome = new FormHome();
                formhome.Show();
                this.Hide();
            }
            else
            {
                circleProgressBar.Value += 1;
                lblValue.Text = (Convert.ToInt32(lblValue.Text) + 1).ToString();
            }
        }

        private void circleProgressBar_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
