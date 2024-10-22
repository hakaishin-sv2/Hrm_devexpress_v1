using BusinessLayer;
using BusinessLayer.LogIn;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native.WebClientUIControl;
using DevExpress.XtraSplashScreen;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM.LogIn
{
    


    public partial class formLogIn : DevExpress.XtraEditors.XtraForm
    {
        const string CONNSTR_FILE = "data.dat";

        public formLogIn()
        {
            InitializeComponent();
        }
        User _us;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();

                SaveDbDaChon();

                bool check = true;

                if (string.IsNullOrEmpty(textBoxMaNV.Text))
                {
                    //MessageBox.Show("Bạn cần nhập mã nhân viên!", "Hướng dẫn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //return;
                    errorProvider1.SetError(textBoxMaNV, "Bạn cần nhập mã nhân viên!");

                    check = false;
                }


                if (string.IsNullOrEmpty(textBoxPasswoed.Text))
                {
                    //MessageBox.Show("Bạn cần nhập password!", "Hướng dẫn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // return;

                    errorProvider1.SetError(textBoxPasswoed, "Bạn cần nhập password!");

                    check = false;
                }


                if (check == false)
                {
                    return;
                }

                if (string.IsNullOrEmpty(cbCSDL.Text))
                {
                    //MessageBox.Show("Bạn cần nhập password!", "Hướng dẫn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // return;

                    errorProvider1.SetError(cbCSDL, "Bạn cần chọn CSDL!");

                    check = false;
                }

                // Chuyển đổi mã nhân viên thành số và kiểm tra xem có hợp lệ không
                int manv;
                if (!int.TryParse(textBoxMaNV.Text, out manv))
                {
                    //MessageBox.Show("Sai thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //return;

                    errorProvider1.SetError(textBoxMaNV, "Sai thông tin!");

                    check = false;
                }


                if(check == false)
                {
                    return;
                }

                string password = textBoxPasswoed.Text;

                // Mã hóa mật khẩu
                string hashpassword = PasswordHelper.HashPassword(password);

                // Lấy thông tin người dùng từ cơ sở dữ liệu
                _us = new User();
                var user_login = _us.getItemByManv(manv);

                // Kiểm tra mã nhân viên và mật khẩu
                if (user_login != null && user_login.MANV_LOGIN == manv && user_login.HASHPASSWORD == hashpassword)
                {
                    int role = int.Parse(user_login.ROLE.ToString());
                    Session.User = new User(manv, hashpassword, role);
                    this.Hide();

                    MainForm frmMain = new MainForm();
                    frmMain.ShowDialog();
                    this.Close();

                    //save db da chon


                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể đăng nhập lúc này. hãy thử lại sau!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveDbDaChon()
        {
            Login_Sql_Model login = new Login_Sql_Model();

            login.ServerName = cbSql.Text.Trim();
            login.DatabaseName = cbCSDL.Text.Trim();
            login.UserName = txtSqlUserName.Text.Trim();
            login.Password = txtSqlPassword.Text.Trim();
            login.IntegratedSecurity = chkSqlIntegratedSecurity.Checked;

            Session.CONN_STR_INIT = login.CONNSTR_INIT;
            Session.CONN_STR = login.CONNSTR;

            string LoginSqlInfoJson = JsonConvert.SerializeObject(login);

            string hashedCONN = StringCipher.Encrypt(LoginSqlInfoJson);

            //sau khi thiet lap data thanh cong moi luu conn
            System.IO.File.WriteAllText(CONNSTR_FILE, hashedCONN);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhapSql_Click(object sender, EventArgs e)
        {
            if(System.IO.File.Exists(CONNSTR_FILE))
            {
                if(MessageBox.Show("Thiết lập lại cơ sở dữ liệu lại sẽ làm mất dữ liệu hiện có\r\nBạn muốn thực hiện không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

            Login_Sql_Model login = new Login_Sql_Model();

            login.ServerName = cbSql.Text.Trim();
            login.DatabaseName = txtSqlDatabaseName.Text.Trim();
            login.UserName = txtSqlUserName.Text.Trim();
            login.Password = txtSqlPassword.Text.Trim();
            login.IntegratedSecurity = chkSqlIntegratedSecurity.Checked;

            Session.CONN_STR_INIT = login.CONNSTR_INIT;
            Session.CONN_STR = login.CONNSTR;

            Init init = new Init();
            bool res= init.SetupDB(login.DatabaseName, out string Err);


            if(res)
            {
                string LoginSqlInfoJson = JsonConvert.SerializeObject(login);

                string hashedCONN = StringCipher.Encrypt(LoginSqlInfoJson);

                //sau khi thiet lap data thanh cong moi luu conn
                System.IO.File.WriteAllText(CONNSTR_FILE, hashedCONN);

                //day la dang nhap lan dau nen cai script ở đây
                MessageBox.Show("Da tao thanh cong co so du lieu mau", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

                grHrm.Enabled = true;
            }
            else
            {
                if(string.IsNullOrEmpty(Err))
                {
                    Err = "Khong the tao co so du lieu";
                }

                MessageBox.Show(Err, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        void GetSqlDropDown()
        {
            string ServerName = Environment.MachineName;
            Microsoft.Win32.RegistryView registryView = Environment.Is64BitOperatingSystem ? Microsoft.Win32.RegistryView.Registry64 : Microsoft.Win32.RegistryView.Registry32;
            using (Microsoft.Win32.RegistryKey hklm = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, registryView))
            {
                Microsoft.Win32.RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        if (instanceName == "MSSQLSERVER")
                        {
                            cbSql.Items.Add(ServerName);

                        }
                        else
                        {
                            cbSql.Items.Add(ServerName + "\\" + instanceName);
                        }
                    }
                }
            }
        }

        private void formLogIn_Load(object sender, EventArgs e)
        {
            GetSqlDropDown();            

            chkSqlIntegratedSecurity_CheckedChanged(null, null);

            if (System.IO.File.Exists(CONNSTR_FILE))
            {
                string CONN = StringCipher.Decrypt(System.IO.File.ReadAllText(CONNSTR_FILE));

                Login_Sql_Model obj = JsonConvert.DeserializeObject<Login_Sql_Model>(CONN);

                cbSql.Text = obj.ServerName;
                txtSqlDatabaseName.Text = obj.DatabaseName;
                txtSqlUserName.Text = obj.UserName;
                txtSqlPassword.Text = obj.Password;
                chkSqlIntegratedSecurity.Checked = obj.IntegratedSecurity;
                chkSqlIntegratedSecurity_CheckedChanged(null, null);

                Session.CONN_STR = obj.CONNSTR;

                Session.CONN_STR_INIT = obj.CONNSTR_INIT;

                grSql.Enabled = false;
                grHrm.Enabled = true;

                GetSqlDropDownLogin();

                foreach(var item in cbCSDL.Items)
                {
                    if(item.ToString() == obj.DatabaseName)
                    {
                        cbCSDL.SelectedItem = item;
                        break;
                    }
                }

            }
            else
            {
                grHrm.Enabled = false;
                grSql.Enabled = true;
            }
        }

        private void GetSqlDropDownLogin()
        {
            SqlConnection conn = new SqlConnection(Session.CONN_STR_INIT);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT name from sys.databases";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if(dt != null && dt.Rows.Count > 0)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    cbCSDL.Items.Add(dr[0].ToString());
                }
            }
        }

        private void chkSqlIntegratedSecurity_CheckedChanged(object sender, EventArgs e)
        {
            if(chkSqlIntegratedSecurity.Checked)
            {
                txtSqlPassword.Enabled = txtSqlUserName.Enabled = false;
            }
            else
            {
                txtSqlPassword.Enabled = txtSqlUserName.Enabled = true;
            }
        }
    }
}