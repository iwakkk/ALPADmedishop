using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOGIN.Components;
using MySql.Data.MySqlClient;

namespace LOGIN
{
    public partial class FormCheckout : Form
    {
        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=db_medishop"); // sebagai data koneksi ke DBMSnya, memasukkan IP Address, localhost, user, password
        MySqlCommand sqlCommand = new MySqlCommand("query kita"); // memindahkan query dari VS ke database
        MySqlDataAdapter sqlAdapter; // hasil query akan disimpan olehnya atau menjadi penampung
        string sqlQuery;
        public FormCheckout()
        {
            InitializeComponent();
        }

        private void lblCompany_Click(object sender, EventArgs e)
        {

        }


        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

      

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        public void addItem(string pid, string nameMed, string pcs, string pricee, string disc, Image picDisc, Image product)
        {
            /*var x = new ucItems()
            {
                title = nameMed,
                price = pricee,
                subTitle = pcs,
                lbldisc = disc,
                priceDisc = picDisc,
                products = product,
                id 
            };*/

        }

        public void loadProductsFromDb()
        {
            sqlQuery = $"Select * FROM medicine;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dtProducts = new DataTable();
            sqlAdapter.Fill(dtProducts);

            if (dtProducts.Rows.Count > 0)
            {
                foreach(DataRow row in dtProducts.Rows)
                {
                    Byte[] imageArr = (byte[])row[""];
                    byte[] imageByteArr = imageArr;


                }
            }
            

        }
    }
}
