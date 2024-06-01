using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN
{
    public partial class FormLogin : Form
    {
        public static string connectionstring = "server=localhost;uid=root;pwd=;database=db_medishop;";
        public static MySqlConnection sqlConnect;
        public static MySqlCommand sqlCommand;
        public static MySqlDataAdapter sqlAdapter;
        public static MySqlDataReader sqlDataReader;
        public static string query;
        public static string firstname = "";
        public DataTable dtuser;
        List<string> usernamelist = new List<string>();
        List<string> phonelist = new List<string>();
        bool noduplicate = true;
        bool phoneduplicate = true;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            transitionPanel.ShowSync(panelLogin);
            lblHeader.BackColor = Color.White;
            lblSignUp.BackColor = Color.White;
            lblCreateAccount.BackColor = Color.White;
            lblHere.BackColor = Color.White;
            lblBack.BackColor = Color.White;
            txtBoxPass.PasswordChar = '*';
            txtBoxRegisPassword.PasswordChar = '*';
            turnOffILogin();
            turnOffRegister();
        }
        bool finishUsername = false;
        bool finishPassword = false;
        bool finishUsernameRegister = false;
        bool finishPasswordRegister = false;
        bool finishFullName = false;
        bool finishPhoneNum = false;
        bool finishAddress = false;
        bool finishGender = false;
        bool finishDate = false;
        bool finishChckBox = false;
        int count = 0;
        int count2 = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //kriteria password: panjang min >= 8, uppercase 1, lowercase 1, special character 1, angka 1
            string passwordLogin = txtBoxPass.Text.ToString();
            int minimumLength = 8;
            bool containsAtLeastOneSpecialCharacter = passwordLogin.Any(ch => !Char.IsLetterOrDigit(ch));
            bool containsAtLeastOneUppercase = passwordLogin.Any(char.IsUpper);
            bool containsAtLeastOneLowercase = passwordLogin.Any(char.IsLower);
            bool containsAtLeastOneDigit = passwordLogin.Any(char.IsDigit);
            

            if (string.IsNullOrEmpty(txtBoxUsername.Text))
            {
                //untuk validasi textbox berupa show icon error di samping kanan textbox
                errorUsername.SetError(txtBoxUsername, "Please fill the username!");
                txtBoxUsername.Focus();
            }
            else 
            {
                //penanda jika username telah diisi
                finishUsername = true;
                errorUsername.SetError(txtBoxUsername, string.Empty);
                txtBoxPass.Focus();
            }

            if (string.IsNullOrEmpty(txtBoxPass.Text))
            {
                errorPassword.SetError(txtBoxPass, "Please fill the password!");
                txtBoxPass.Focus();
            }
            else
            {
                errorPassword.SetError(txtBoxPass, string.Empty);
                txtBoxUsername.Focus();
            }

            if (containsAtLeastOneDigit)
            {
                count++;
            }
            else
            {
                errorPassword.SetError(txtBoxPass, "Password character must contains at least 1 number!");
                txtBoxPass.Focus();
            }
           
            if(containsAtLeastOneLowercase)
            {
                count++;
            }
            else
            {
                errorPassword.SetError(txtBoxPass, "Password character must contains at least 1 lowercase!");
                txtBoxPass.Focus();
            }
            
            if(containsAtLeastOneUppercase)
            {
                count++;
            }
            else
            {
                errorPassword.SetError(txtBoxPass, "Password character must contains at least 1 uppercase!");
                txtBoxPass.Focus();
            }

            if(containsAtLeastOneSpecialCharacter)
            {
                count++;
            }
            else
            {
                errorPassword.SetError(txtBoxPass, "Password character must contains at least 1 special character!");
                txtBoxPass.Focus();
            }
         
            if (passwordLogin.Length >= minimumLength)
            {
                count++;
            }
            else
            {
                errorPassword.SetError(txtBoxPass, "Password character must greater than 8!");
                txtBoxPass.Focus();
            }
            dtuser = new DataTable();
            string hash = BitConverter.ToString(MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(txtBoxRegisPassword.Text))).Replace("-", "").ToLower();
            query = $"SELECT first_name FROM user WHERE username = '{txtBoxUsername.Text}';";
            sqlConnect = new MySqlConnection(connectionstring);
            sqlCommand = new MySqlCommand(query, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtuser);
            if (dtuser.Rows.Count > 0)
            {
                firstname = Convert.ToString(dtuser.Rows[0]["first_name"]);
            }
            MessageBox.Show(firstname);
            passwordPerformanceLogin();

            FormLoading formLoading = new FormLoading();
            this.Hide();
            formLoading.Show();
            //jika sudah terisi semua dan memenuhi kriteria password, insert data dan open form selanjutnya
            /*if (finishPassword == true && finishUsername == true)
            {
                FormAddMedicine formAddMedicine = new FormAddMedicine();
                this.Hide();
                formAddMedicine.Show();
            }*/

        }
        //method untuk mengecek performa password dibagi menjadi 5 kriteria
        public void passwordPerformanceLogin()
        {
            switch (count)
            {
                case 5:
                    //manggil method
                    turnOnOffUnecessaryPassIconLogin();
                    //reset count jadi 0 kembali sebelum di break
                    count *= 0;
                    //penanda jika password memenuhi kriteria
                    finishPassword = true;
                    break;
                case 4:
                    turnOnOffUnecessaryPassIconLogin();
                    count *= 0;
                    break;
                case 3:
                    turnOnOffUnecessaryPassIconLogin();
                    count *= 0;
                    break;
                case 2:
                    turnOnOffUnecessaryPassIconLogin();
                    count *= 0;
                    break;
                case 1:
                    turnOnOffUnecessaryPassIconLogin();
                    count *= 0;
                    break;
                default:
                    count *= 0;
                    break;
            }
        }
        public void passwordPerformanceRegister()
        {
            switch (count2)
            {
                case 5:
                    //manggil method
                    turnOnOffUnecessaryPassIconRegister();
                    //reset count jadi 0 kembali sebelum di break
                    count2 *= 0;
                    finishPasswordRegister = true;
                    break;
                case 4:
                    turnOnOffUnecessaryPassIconRegister();
                    count2 *= 0;
                    break;
                case 3:
                    turnOnOffUnecessaryPassIconRegister();
                    count2 *= 0;
                    break;
                case 2:
                    turnOnOffUnecessaryPassIconRegister();
                    count2 *= 0;
                    break;
                case 1:
                    turnOnOffUnecessaryPassIconRegister();
                    count2 *= 0;
                    break;
                default:
                    count2 *= 0;
                    break;
            }
        }
        //method untuk hide/show icon(picbox) dan label yang dibutuhkan dan tidak dibutuhkan 
        private void turnOnOffUnecessaryPassIconLogin()
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
        private void turnOnOffUnecessaryPassIconRegister()
        {
            if (count2 == 5 || count2 == 4)
            {
                picBoxWeakRegis.Visible = false;
                picBoxMediumRegist.Visible = false;
                picBoxStrongRegist.Visible = true;
                lblStrengthPassRegist.Visible = true;
                lblStrengthPassRegist.Text = "Password strength is strong";
                lblStrengthPassRegist.ForeColor = Color.MediumSeaGreen;
            }
            else if (count2 == 3)
            {
                picBoxStrongRegist.Visible = false;
                picBoxWeakRegis.Visible = false;
                picBoxMediumRegist.Visible = true;
                lblStrengthPassRegist.Visible = true;
                lblStrengthPassRegist.Text = "Password strength is medium";
                lblStrengthPassRegist.ForeColor = Color.Goldenrod;
            }
            else if (count2 < 3)
            {
                picBoxStrongRegist.Visible = false;
                picBoxMediumRegist.Visible = false;
                picBoxWeakRegis.Visible = true;
                lblStrengthPassRegist.Visible = true;
                lblStrengthPassRegist.Text = "Password strength is weak";
                lblStrengthPassRegist.ForeColor = Color.Crimson;
            }
        }
        //untuk hide/show password
        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            //default password : hide
            if (txtBoxPass.PasswordChar == '*')
            {
                //jadi show
                txtBoxPass.PasswordChar = '\0';
            }
            else
            {
                //jadi hide kembali, jika diclick
                txtBoxPass.PasswordChar = '*';
            }
        }
        //reset default form login
        private void turnOffILogin()
        {
            txtBoxUsername.Text = "";
            txtBoxPass.Text = "";
            picBoxMedium.Visible = false;
            picBoxStrong.Visible = false;
            picBoxPassWeak.Visible = false;
            lblStrengthPass.Visible = false;
        }
        //reset default form register
        private void turnOffRegister()
        {
            txtfirstname.Text = "";
            txtBoxPhoneNum.Text = "";
            txtBoxRegisUsername.Text = "";
            txtBoxRegisPassword.Text = "";
            txtBoxAddress.Text = "";
            dateTimePicker.Text = "";
            cmbBoxGender.SelectedIndex = -1;
            //kenapa di set false lagi (297-303)? utk mengatasi user klik next tanpa harus ngisi fieldnya,
            //kalau ga di set false nanti user bisa tekan next tanpa ngisi field
            finishFullName = false;
            finishPhoneNum = false;
            finishUsernameRegister = false;
            finishPasswordRegister = false;
            finishAddress = false;
            finishDate = false;
            finishGender = false;
            checkBoxTC.Checked = false;
            picBoxMediumRegist.Visible = false;
            picBoxStrongRegist.Visible = false;
            picBoxWeakRegis.Visible = false;
            lblStrengthPassRegist.Visible = false;
        }
        //untuk ganti panel ke panel register lewat click label
        private void lblSignUp_Click(object sender, EventArgs e)
        {
            turnOffILogin();
            panelLogin.Visible = false;
            panelNextRegister.Visible = false;
            btnBackToOpen.Visible = false;
            transitionPanel.ShowSync(panelRegister);
            panelRegister.Visible = true;
            
        }
        //untuk kembali ke panel login lewat click label
        private void lblHere_Click(object sender, EventArgs e)
        {
            turnOffRegister();
            panelRegister.Visible = false;
            panelNextRegister.Visible = false;
            transitionPanel.ShowSync(panelLogin);
            btnBackToOpen.Visible = true;
            panelLogin.Visible = true;
            
        }
        private void checkBoxShowPassRegister_Click(object sender, EventArgs e)
        {
            if (txtBoxRegisPassword.PasswordChar == '*')
            {
                txtBoxRegisPassword.PasswordChar = '\0';
            }
            else
            {
                txtBoxRegisPassword.PasswordChar = '*';
            }
        }
        //tombol back ke halaman opening
        private void btnBackToOpen_Click(object sender, EventArgs e)
        {
            turnOffILogin();
            turnOffRegister();
            FormOpening formOpening = new FormOpening();
            this.Hide();
            formOpening.Show();
        }

        private void btnNextRegister_Click(object sender, EventArgs e)
        {
            string passwordLogin2 = txtBoxRegisPassword.Text.ToString();
            int minimumLength2 = 8;
            bool containsAtLeastOneSpecialCharacter2 = passwordLogin2.Any(ch => !Char.IsLetterOrDigit(ch));
            bool containsAtLeastOneUppercase2 = passwordLogin2.Any(char.IsUpper);
            bool containsAtLeastOneLowercase2 = passwordLogin2.Any(char.IsLower);
            bool containsAtLeastOneDigit2 = passwordLogin2.Any(char.IsDigit);
            if (string.IsNullOrEmpty(txtfirstname.Text))
            {
                //untuk validasi textbox berupa show icon error di samping kanan textbox
                errorFullNameRegist.SetError(txtfirstname, "Please fill the username!");
                txtBoxRegisUsername.Focus();
            }
            else
            {
                finishFullName = true;
                errorFullNameRegist.SetError(txtfirstname, string.Empty);
                txtBoxPhoneNum.Focus();
            }
            if (string.IsNullOrEmpty(txtBoxPhoneNum.Text))
            {
                //untuk validasi textbox berupa show icon error di samping kanan textbox
                errorPhoneNumRegist.SetError(txtBoxPhoneNum, "Please fill the phone number!");
                txtBoxPhoneNum.Focus();
            }
            else
            {
                finishPhoneNum = true;
                errorPhoneNumRegist.SetError(txtBoxPhoneNum, string.Empty);
                txtBoxRegisUsername.Focus();
            }
            if (string.IsNullOrEmpty(txtBoxRegisUsername.Text))
            {
                //untuk validasi textbox berupa show icon error di samping kanan textbox
                errorUsernameRegist.SetError(txtBoxRegisUsername, "Please fill the username!");
                txtBoxRegisUsername.Focus();
            }
            else
            {
                finishUsernameRegister = true;
                errorUsernameRegist.SetError(txtBoxRegisUsername, string.Empty);
                txtBoxRegisPassword.Focus();
            }
            if (string.IsNullOrEmpty(txtBoxRegisPassword.Text))
            {
                errorPasswordRegist.SetError(txtBoxPass, "Please fill the password!");
                txtBoxRegisPassword.Focus();
            }
            else
            {
                errorPasswordRegist.SetError(txtBoxRegisPassword, string.Empty);
                txtBoxRegisUsername.Focus();
            }

            if (containsAtLeastOneDigit2)
            {
                count2++;
            }
            else
            {
                errorPasswordRegist.SetError(txtBoxRegisPassword, "Password character must contains at least 1 number!");
                txtBoxRegisPassword.Focus();
            }

            if (containsAtLeastOneLowercase2)
            {
                count2++;
            }
            else
            {
                errorPasswordRegist.SetError(txtBoxRegisPassword, "Password character must contains at least 1 lowercase!");
                txtBoxRegisPassword.Focus();
            }

            if (containsAtLeastOneUppercase2)
            {
                count2++;
            }
            else
            {
                errorPasswordRegist.SetError(txtBoxRegisPassword, "Password character must contains at least 1 uppercase!");
                txtBoxRegisPassword.Focus();
            }

            if (containsAtLeastOneSpecialCharacter2)
            {
                count2++;
            }
            else
            {
                errorPasswordRegist.SetError(txtBoxRegisPassword, "Password character must contains at least 1 special character!");
                txtBoxRegisPassword.Focus();
            }

            if (passwordLogin2.Length >= minimumLength2)
            {
                count2++;
            }
            else
            {
                errorPasswordRegist.SetError(txtBoxRegisPassword, "Password character must greater than 8!");
                txtBoxRegisPassword.Focus();
            }
            passwordPerformanceRegister();

            if(finishFullName == true && finishPhoneNum == true && finishUsernameRegister == true && finishPasswordRegister == true)
            {
                panelRegister.Visible = false;
                transitionPanel.ShowSync(panelNextRegister);
                panelNextRegister.Visible = true;
            }
        }

        private void txtBoxPhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            //selain angka/digit, error
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only numbers allowed!","", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxPhoneNum.Focus();
            }
        }

        private void txtBoxFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //selain huruf/character/letter, error
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only characters allowed!","", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtfirstname.Focus();
            }
        }
       
        private void btnRegister_Click(object sender, EventArgs e)
        {
            //.checked return true false
            bool chckBoxTC = checkBoxTC.Checked;

            string dateValue = dateTimePicker.Value.ToString("yyyy-MM-dd");

            if(string.IsNullOrEmpty(txtBoxAddress.Text))
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
                errorDate.SetError(dateTimePicker, "Date of birth can't be in the future");
                dateTimePicker.Focus();
            }
            else
            {
                finishDate = true;
                errorDate.SetError(dateTimePicker, string.Empty);
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

            if (chckBoxTC == false)
            {
                finishChckBox = false;
            }
            else
            {
                finishChckBox = true;
            }

            if (finishAddress == true && finishDate == true && finishGender == true && finishChckBox == true)
            {
                noduplicate = true;
                phoneduplicate = true;
                usernamelist.Clear();
                phonelist.Clear();
                DataTable dtusername = new DataTable();
                query = $"select username, phone_number from user;";
                sqlConnect = new MySqlConnection(connectionstring);
                sqlCommand = new MySqlCommand(query, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtusername);

                foreach (DataRow dr in dtusername.Rows)
                {
                    usernamelist.Add(dr["username"].ToString());
                    phonelist.Add(dr["phone_number"].ToString());
                }
                for (int i = 0; i < usernamelist.Count; i++)
                {
                    if (txtBoxRegisUsername.Text == usernamelist[i])
                    {
                        noduplicate = false;
                    }
                    if (txtBoxPhoneNum.Text == phonelist[i])
                    {
                        phoneduplicate = false;
                    }
                }

                if (noduplicate == false && phoneduplicate == false)
                {
                    MessageBox.Show("Username and phone number already taken", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (noduplicate == false)
                {
                    MessageBox.Show("Username is already taken", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (phoneduplicate == false)
                {
                    MessageBox.Show("Phone number is already used", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
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
                    query = $"select concat('US', lpad((count(id_user) + 1), 3, 0)) from user;";
                    sqlCommand = new MySqlCommand(query, sqlConnect);
                    string newid = sqlCommand.ExecuteScalar().ToString();
                    string hash = BitConverter.ToString(MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(txtBoxRegisPassword.Text))).Replace("-", "").ToLower();



                    query = $"insert into user values ('{newid}', '{txtfirstname.Text}', '{txtlastname.Text}', '{datetimeformat}', '{gender}', {txtBoxPhoneNum.Text}, '{txtBoxAddress.Text}', '{txtBoxUsername.Text}', '{hash}', 0,0,0 );";
                    sqlCommand = new MySqlCommand(query, sqlConnect);
                    sqlCommand.ExecuteNonQuery().ToString();
                    sqlConnect.Close();
                    FormHome formAddMedicine = new FormHome();
                    turnOffILogin();
                    turnOffRegister();
                    this.Hide();
                    formAddMedicine.Show();
                }

                

            }
        }
        //next page register (address, gender, t&c form)
        private void lblBackNextRegister_Click(object sender, EventArgs e)
        {
            panelNextRegister.Visible = false;
            transitionPanel.ShowSync(panelRegister);
            panelRegister.Visible = true;
        }
    }
}
