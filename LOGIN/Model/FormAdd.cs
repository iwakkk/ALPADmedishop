using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;


namespace LOGIN
{
    public partial class FormAdd : Form
    {
        public static string connectionstring = "server=localhost;uid=root;pwd=;database=db_medishop;";
        public static MySqlConnection sqlConnect;
        public static MySqlCommand sqlCommand;
        public static MySqlDataAdapter sqlAdapter;
        public static MySqlDataReader sqlDataReader;
        public static string query;
        public FormAdd()
        {
            InitializeComponent();
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            turnOfAddUser();
            //lblHeader.Parent = picBoxWave;
            //lblHeader.BackColor = Color.Transparent;
            
        }

        bool finishUsername = false;
        bool finishPassword = false;
        bool finishFullName = false;
        bool finishPhoneNum = false;
        bool finishAddress = false;
        bool finishGender = false;
        bool finishDate = false;
        int count = 0;
        private void passwordPerformace()
        {
            switch (count)
            {
                case 5:
                    //manggil method
                    turnOnOffUnecessaryPassIcon();
                    //reset count jadi 0 kembali sebelum di break
                    count *= 0;
                    //penanda jika password memenuhi kriteria
                    finishPassword = true;
                    break;
                case 4:
                    turnOnOffUnecessaryPassIcon();
                    count *= 0;
                    break;
                case 3:
                    turnOnOffUnecessaryPassIcon();
                    count *= 0;
                    break;
                case 2:
                    turnOnOffUnecessaryPassIcon();
                    count *= 0;
                    break;
                case 1:
                    turnOnOffUnecessaryPassIcon();
                    count *= 0;
                    break;
                default:
                    count *= 0;
                    break;
            }
        }
        private void turnOnOffUnecessaryPassIcon()
        {
            if (count == 5 || count == 4)
            {
                picBoxPassWeak.Visible = false;
                picBoxMedium.Visible = false;
                picBoxStrong.Visible = true;
                lblStrengthPass.Visible = true;
                lblStrengthPass.Text = "Password strength is strong";
                lblStrengthPass.ForeColor = Color.MediumSeaGreen;
            }
            else if (count == 3)
            {
                picBoxStrong.Visible = false;
                picBoxPassWeak.Visible = false;
                picBoxMedium.Visible = true;
                lblStrengthPass.Visible = true;
                lblStrengthPass.Text = "Password strength is medium";
                lblStrengthPass.ForeColor = Color.Goldenrod;
            }
            else if (count < 3)
            {
                picBoxStrong.Visible = false;
                picBoxMedium.Visible = false;
                picBoxPassWeak.Visible = true;
                lblStrengthPass.Visible = true;
                lblStrengthPass.Text = "Password strength is weak";
                lblStrengthPass.ForeColor = Color.Crimson;
            }
        }
        private void turnOfAddUser()
        {
            txtBoxAddress.Text = "";
            txtfirstname.Text = "";
            txtBoxPassword.Text = "";
            txtBoxPhoneNum.Text = "";
            txtBoxUsername.Text = "";
            cmbBoxGender.SelectedIndex = -1;
            finishUsername = false;
            finishPassword = false;
            finishFullName = false;
            finishPhoneNum = false;
            finishAddress = false;
            finishGender = false;
            finishDate = false;
            picBoxMedium.Visible = false;
            picBoxStrong.Visible = false;
            picBoxPassWeak.Visible = false;
            lblStrengthPass.Visible = false;
            
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            string password = txtBoxPassword.Text.ToString();
            int minimumLength = 8;
            bool containsAtLeastOneSpecialCharacter = password.Any(ch => !Char.IsLetterOrDigit(ch));
            bool containsAtLeastOneUppercase = password.Any(char.IsUpper);
            bool containsAtLeastOneLowercase = password.Any(char.IsLower);
            bool containsAtLeastOneDigit = password.Any(char.IsDigit);

            if (string.IsNullOrEmpty(txtfirstname.Text))
            {
                errorFullName.SetError(txtfirstname, "Please fill the full name!");
            }
            else
            {
                finishUsername = true;
                errorFullName.SetError(txtfirstname, string.Empty);
                finishFullName = true;
            }
            if (string.IsNullOrEmpty(txtBoxPassword.Text))
            {
                errorPass.SetError(txtBoxPassword, "Please fill the password!");
                txtBoxPassword.Focus();
            }
            else
            {
                errorPass.SetError(txtBoxPassword, string.Empty);
                txtBoxUsername.Focus();
            }

            if (containsAtLeastOneDigit)
            {
                count++;
            }
            else
            {
                errorPass.SetError(txtBoxPassword, "Password character must contains at least 1 number!");
                txtBoxPassword.Focus();
            }

            if (containsAtLeastOneLowercase)
            {
                count++;
            }
            else
            {
                errorPass.SetError(txtBoxPassword, "Password character must contains at least 1 lowercase!");
                txtBoxPassword.Focus();
            }

            if (containsAtLeastOneUppercase)
            {
                count++;
            }
            else
            {
                errorPass.SetError(txtBoxPassword, "Password character must contains at least 1 uppercase!");
                txtBoxPassword.Focus();
            }

            if (containsAtLeastOneSpecialCharacter)
            {
                count++;
            }
            else
            {
                errorPass.SetError(txtBoxPassword, "Password character must contains at least 1 special character!");
                txtBoxPassword.Focus();
            }

            if (password.Length >= minimumLength)
            {
                count++;
            }
            else
            {
                errorPass.SetError(txtBoxPassword, "Password character must greater than 8!");
                txtBoxPassword.Focus();
            }
            if (string.IsNullOrEmpty(txtfirstname.Text))
            {
                //untuk validasi textbox berupa show icon error di samping kanan textbox
                errorFullName.SetError(txtfirstname, "Please fill the username!");
                txtfirstname.Focus();
            }
            else
            {
                finishFullName = true;
                errorFullName.SetError(txtfirstname, string.Empty);
                txtBoxPhoneNum.Focus();
            }
            if (string.IsNullOrEmpty(txtBoxPhoneNum.Text))
            {
                //untuk validasi textbox berupa show icon error di samping kanan textbox
                errorPhoneNum.SetError(txtBoxPhoneNum, "Please fill the phone number!");
                txtBoxPhoneNum.Focus();
            }
            else
            {
                finishPhoneNum = true;
                errorPhoneNum.SetError(txtBoxPhoneNum, string.Empty);
                txtBoxAddress.Focus();
            }
            if (string.IsNullOrEmpty(txtBoxUsername.Text))
            {
                //untuk validasi textbox berupa show icon error di samping kanan textbox
                errorUsername.SetError(txtBoxUsername, "Please fill the username!");
                txtBoxUsername.Focus();
            }
            else
            {
                finishUsername = true;
                errorUsername.SetError(txtBoxUsername, string.Empty);
                txtBoxPassword.Focus();
            }
            if (string.IsNullOrEmpty(txtBoxAddress.Text))
            {
                errorAddress.SetError(txtBoxAddress, "Please fill the address!");
                txtBoxAddress.Focus();
            }
            else
            {
                finishAddress = true;
                errorAddress.SetError(txtBoxAddress, string.Empty);
            }


            if (dateTimePicker.Value > DateTime.Now)
            {
                errorDOB.SetError(dateTimePicker, "Date of birth can't be in the future");
                dateTimePicker.Focus();
            }
            else
            {
                finishDate = true;
                errorDOB.SetError(dateTimePicker, string.Empty);
            }

            if (cmbBoxGender.SelectedIndex == -1)
            {
                errorGender.SetError(cmbBoxGender, "Please choose the gender!");
                cmbBoxGender.Focus();
            }
            else
            {
                finishGender = true;
                errorGender.SetError(cmbBoxGender, string.Empty);
            }
            passwordPerformace();

            if (!string.IsNullOrEmpty(txtlastname.Text) && finishFullName == true && finishPhoneNum == true && finishUsername == true && finishPassword == true && finishAddress == true && finishDate == true && finishGender == true)
            {
                try
                {
                    
                    string gender = "";
                    string datetimeformat = dateTimePicker.Value.ToString("yyyy-MM-dd");
                    if (cmbBoxGender.Text == "Male")
                    {
                        gender = "M";
                    }
                    else
                    {
                        gender = "F";
                    }
                    sqlConnect = new MySqlConnection(connectionstring);
                    sqlConnect.Open();
                    query = $"select concat('U', lpad((count(id_user) + 1), 3, 0)) from user;";
                    sqlCommand = new MySqlCommand(query, sqlConnect);
                    string newid = sqlCommand.ExecuteScalar().ToString();
                    string hash = BitConverter.ToString(MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(txtBoxPassword.Text))).Replace("-", "").ToLower();



                    query = $"insert into user values ('{newid}', '{txtfirstname.Text}', '{txtlastname.Text}', '{datetimeformat}', '{gender}', {txtBoxPhoneNum.Text}, '{txtBoxAddress.Text}', '{txtBoxUsername.Text}', '{hash}', 0,0 );";
                    sqlCommand = new MySqlCommand(query, sqlConnect);
                    sqlCommand.ExecuteNonQuery().ToString();
                    sqlConnect.Close();

                    MessageBox.Show("Yay, account created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {

                }
                finally
                {

                }
            }
        }

        private void txtBoxPhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only numbers allowed!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxPhoneNum.Focus();
            }
        }

        private void txtBoxFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only characters allowed!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtfirstname.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        { 
            turnOfAddUser();
            FormHome formhome = new FormHome();
            transition.ShowSync(formhome);
            formhome.Show();
            this.Hide();
        }


    }
}
