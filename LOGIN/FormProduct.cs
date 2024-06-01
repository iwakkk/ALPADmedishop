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
    public partial class FormProduct : Form
    {
       
        public FormProduct()
        {
            InitializeComponent();
        }


        public void btnAddNew_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new FormAddProducts());


        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
        }
    }
}
