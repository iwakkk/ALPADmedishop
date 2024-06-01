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
    public partial class FormMaster : Form
    {
        public FormMaster()
        {
            InitializeComponent();
        }


        static FormMaster _obj;
        public static FormMaster Instance
        {
            get { if (_obj == null) { _obj = new FormMaster(); } return _obj; }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct();
            formProduct.Show();
        }

        private void FormMaster_Load(object sender, EventArgs e)
        {
            _obj = this;
                
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            FormSetting formSetting = new FormSetting();
            formSetting.Show();
        }
    }
}
