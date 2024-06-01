using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace LOGIN
{
    public partial class FormAddProducts : Form
    {
        public static string connectionstring = "server=localhost;uid=root;pwd=;database=db_medishop;";
        public static MySqlConnection sqlConnect;
        public static MySqlCommand sqlCommand;
        public static MySqlDataAdapter sqlAdapter;
       public static MySqlDataReader sqlDataReader;
        public static string query;
     public FormAddProducts()
        {
            InitializeComponent();
        }

        private void FormAddProducts_Load(object sender, EventArgs e)
        {
            turnOfAddProducts();
            DataTable dtcategory = new DataTable();
            query = "SELECT * FROM db_medishop.category;";
            sqlConnect = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtcategory);
            cmbBoxCategory.DisplayMember = "name_category";
            cmbBoxCategory.ValueMember = "id_category";
            cmbBoxCategory.DataSource = dtcategory;
        }

        bool finishMedName = false;
        bool finishPriceUnit = false;
        bool finishDesc = false;
        bool finishStock = false;
        bool finishSoldCount = false;
        bool finishWeight = false;
        
        private void turnOfAddProducts()
        {
            txtBoxDesc.Text = "";
            txtBoxMedName.Text = "";
            txtBoxPrice.Text = "";
            txtBoxStock.Text = "";
            txtBoxWeight.Text = "";
            finishMedName = false;
            finishSoldCount = false;
            finishDesc = false;
            finishStock = false;
            finishWeight = false;
            finishPriceUnit = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtBoxMedName.Text))
            {
                errorMedName.SetError(txtBoxMedName, "Please fill the medicine name!");
            }
            else
            {
                string medName = txtBoxMedName.Text.ToString();
                finishMedName = true;
                errorMedName.SetError(txtBoxMedName, string.Empty);
                txtBoxPrice.Focus();
            }

            if (string.IsNullOrEmpty(txtBoxPrice.Text))
            {
                //untuk validasi textbox berupa show icon error di samping kanan textbox
                errorPrice.SetError(txtBoxPrice, "Please fill the item price!");
                txtBoxPrice.Focus();
            }
            else
            {
                finishPriceUnit = true;
                errorPrice.SetError(txtBoxPrice, string.Empty);
                txtBoxDesc.Focus();
            }

            if (string.IsNullOrEmpty(txtBoxDesc.Text))
            {
                errorDesc.SetError(txtBoxDesc, "Please fill the description!");
                txtBoxDesc.Focus();
            }
            else
            {
                finishDesc = true;
                errorDesc.SetError(txtBoxDesc, string.Empty);
                txtBoxStock.Focus();
            }





            
            if (string.IsNullOrEmpty(txtBoxWeight.Text))
            {
                //untuk validasi textbox berupa show icon error di samping kanan textbox
                errorWeight.SetError(txtBoxWeight, "Please fill the weight item!");
                txtBoxWeight.Focus();
            }
            else
            {
                finishWeight = true;
                errorWeight.SetError(txtBoxWeight, string.Empty);
            }
            
            
            if (finishMedName == true && finishPriceUnit == true && finishDesc == true && finishStock == true && finishSoldCount == true && finishWeight == true)
            {
                try
                {


                    sqlConnect = new MySqlConnection(connectionstring);
                    sqlConnect.Open();
                    query = $"select concat('{txtBoxMedName.Text.ToUpper()[0]}', lpad((count(id_medicine) + 1), 3, 0)) from medicine where medicine_name like '{txtBoxMedName.Text.ToUpper()[0]}%';";
                    sqlCommand = new MySqlCommand(query, sqlConnect);
                    string newid = sqlCommand.ExecuteScalar().ToString();



                    query = $"insert into medicine values ('{newid}', '{txtBoxMedName.Text}', '{txtBoxPrice.Text}', '{txtBoxDesc.Text}', '{txtBoxStock.Text}', 0 , '{txtBoxWeight.Text}', '{cmbBoxCategory.SelectedValue}',0 );";
                    sqlCommand = new MySqlCommand(query, sqlConnect);
                    sqlCommand.ExecuteNonQuery().ToString();
                    sqlConnect.Close();

                    MessageBox.Show("Medicine added", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {

                }
                finally
                {

                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            turnOfAddProducts();
            FormHome formhome = new FormHome();
            transition.ShowSync(formhome);
            formhome.Show();
            this.Hide();
        }

        private void txtBoxSold_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only numbers allowed!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxPrice.Focus();
            }
        }

        private void txtBoxStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only numbers allowed!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxPrice.Focus();
            }
        }

        private void txtBoxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only numbers allowed!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxPrice.Focus();
            }
        }

        private void txtBoxMedName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only characters allowed!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxMedName.Focus();
            }
        }

        private void txtBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only numbers allowed!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxPrice.Focus();
            }
        }

        private void txtBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
