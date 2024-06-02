using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace alp_ad_checkout
{
    public partial class Form1 : Form
    {
        string connectionstring = "server=localhost;uid=root;pwd=junior123;database=db_medishop";
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        MySqlDataReader sqlDataReader;
        public string query;
        public int stock;
        public int price;
        public int total;
        public int freight;
        public int totalftertax;
        public double totalafterdisc;
        public string discount;
        public string desimal;
        public double tax;
        public int finalTotal;
        DataTable dtmedicine;
        bool sudahcount = false;
       DataTable dtor;
        public int gtotall;
        public static double tampung;

        Random random = new Random();
        DataRow[] selectedMedicineRows;
        DataRow[] selectedmedrows;
        public Form1()
        {
            InitializeComponent();
        }

        private void executeSQL (string query)
        {
            try
            {
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlDataReader = sqlCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnect.Close();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtmedicine = new DataTable();
            query = $"select * from medicine";
            sqlConnect = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtmedicine);
            comboBox_name.DataSource = dtmedicine;
            comboBox_name.ValueMember = "id_medicine";
            comboBox_name.DisplayMember = "medicine_name";

        }

        private void comboBox_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedMedicineId = comboBox_name.SelectedValue.ToString();
            selectedMedicineRows = dtmedicine.Select($"id_medicine = '{selectedMedicineId}'");

            if (selectedMedicineRows.Length > 0)
            {
                stock = (int)selectedMedicineRows[0]["stock"];
                label_stock.Text = stock.ToString();
            }

            selectedmedrows = dtmedicine.Select($"id_medicine = '{selectedMedicineId}'");
            if (selectedmedrows.Length > 0)
            {
                price = (int)selectedMedicineRows[0]["price_unit"];
                label_price.Text = price.ToString();
            }
        }

        private void button_checkout_Click(object sender, EventArgs e)
        {
            if (sudahcount)
            {
                if (string.IsNullOrEmpty(textBox_phone.Text) || string.IsNullOrEmpty(textBox_shipment.Text) || string.IsNullOrEmpty(comboBox_payment.Text))
                {
                    MessageBox.Show("Fill the Blank!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dtor = new DataTable();
                    string selectedMedicineId = comboBox_name.SelectedValue.ToString();
                    DataRow[] selectedMedicineRows = dtmedicine.Select($"id_medicine = '{selectedMedicineId}'");

                    if (selectedMedicineRows.Length > 0)
                    {
                        stock = (int)selectedMedicineRows[0]["stock"];
                    }

                    DataRow[] selectedmedrows = dtmedicine.Select($"id_medicine = '{selectedMedicineId}'");
                    if (selectedmedrows.Length > 0)
                    {
                        price = (int)selectedMedicineRows[0]["price_unit"];
                        label_price.Text = price.ToString();
                    }

                    int qtty = Int32.Parse(textBox_qty.Text);
                    stock = stock - qtty;

                    query = $"sELECT * FROM db_medishop.order;";
                    sqlCommand = new MySqlCommand(query, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtor);
                    int count = dtor.Rows.Count + 1;
                    string o_id = "OR";

                    if (count <= 999 && count > 99)
                    {
                        o_id += count.ToString();
                    }
                    else if (count <= 99 && count > 9)
                    {
                        o_id += $"0{count.ToString()}";
                    }
                    else
                    {
                        o_id += $"00{count.ToString()}";
                    }
                    string datetimenow = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    query = $"insert into db_medishop.order values ('{o_id}', 'US001', '{datetimenow}', '{textBox_shipment.Text}', '{comboBox_payment.Text}', '{textBox_phone.Text}', '0');";
                    executeSQL(query);
                    query = $"update medicine set stock = '{stock}', sold_count = '{qtty}' where id_medicine = '{selectedMedicineId}'";
                    executeSQL(query);
                    query = $"insert into order_detail values ('{o_id}', '{selectedMedicineId}', '{price}', '{qtty}', '{freight}', '{discount}', '0.10', '{gtotall}', '0')";
                    executeSQL(query);

                    MessageBox.Show("Checkout Berhasil!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_phone.ResetText();
                    textBox_qty.ResetText();
                    textBox_phone.ResetText();
                    comboBox_payment.ResetText();
                    comboBox_name.ResetText();
                    label_tax.Text = "--";
                    label_freight.Text = "--";
                    label_disc.Text = "--";
                    label_gtotal.Text = "--";
                    label_stock.Text = "--";
                    label_total.Text = "--";
                    textBox_shipment.ResetText();
                    label_stock.Text = stock.ToString();
                    sudahcount = false;
                }
            }
            else
            {
                MessageBox.Show("Please Count First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedMedicineId = comboBox_name.SelectedValue.ToString();
            DataRow[] selectedMedicineRows = dtmedicine.Select($"id_medicine = '{selectedMedicineId}'");

            if (selectedMedicineRows.Length > 0)
            {
                stock = (int)selectedMedicineRows[0]["stock"];
                label_stock.Text = stock.ToString();
            }

            if (int.TryParse(textBox_qty.Text, out int qtty))
            {
                if (string.IsNullOrEmpty(textBox_qty.Text))
                {
                    MessageBox.Show("Fill the Quantity!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (stock < qtty)
                    {
                        MessageBox.Show("You Can't Buy More than the Stock available!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        total = price * qtty;
                        label_total.Text = total.ToString();

                        tampung = random.NextDouble() * 0.31;
                        tampung = Math.Round(tampung, 2);
                        discount = tampung.ToString();
                        discount = discount.Replace(",", ".");

                        //MessageBox.Show(discount.ToString());
                        
                        totalafterdisc = total*tampung;
                        finalTotal = (int)Math.Round(totalafterdisc);

                        label_disc.Text = finalTotal.ToString();

                        freight = random.Next(50, 301) * 100;
                        //MessageBox.Show(freight.ToString());

                        label_freight.Text = freight.ToString();

                        tax = 0.10 * total ;
                        totalftertax = (int)Math.Round(tax);

                        label_tax.Text = totalftertax.ToString();

                        gtotall = total  + freight + totalftertax - finalTotal;
                        label_gtotal.Text = gtotall.ToString();

                        sudahcount = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
