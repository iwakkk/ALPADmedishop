using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN.Components
{
    public partial class ucItems : UserControl
    {
        public ucItems()
        {
            InitializeComponent();
        }
        public event EventHandler OnSelect = null;
        private void ucItems_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }

        public string id { get; set; }
        public string cost { get; set; }
        public string title { get => lblTitle.Text; set => lblTitle.Text = value; }
        public string subTitle { get => lblPcs.Text; set => lblPcs.Text = value; }
        public string price { get => lblPrice.Text; set => lblPrice.Text = value; }
        public string lbldisc { get => lblDisc.Text; set => lblDisc.Text = value; }
        public Image priceDisc { get => picBoxDisc.Image; set => picBoxDisc.Image = value; }
        public Image products { get => guna2PictureBox1.Image; set => guna2PictureBox1.Image = value; }





    }
}
