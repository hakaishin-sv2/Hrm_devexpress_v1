namespace HRM.LogIn
{
    partial class formLogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogIn));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaNV = new System.Windows.Forms.TextBox();
            this.textBoxPasswoed = new System.Windows.Forms.TextBox();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grSql = new System.Windows.Forms.GroupBox();
            this.cbSql = new System.Windows.Forms.ComboBox();
            this.chkSqlIntegratedSecurity = new System.Windows.Forms.CheckBox();
            this.txtSqlDatabaseName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDangNhapSql = new DevExpress.XtraEditors.SimpleButton();
            this.txtSqlPassword = new System.Windows.Forms.TextBox();
            this.txtSqlUserName = new System.Windows.Forms.TextBox();
            this.grHrm = new System.Windows.Forms.GroupBox();
            this.cbCSDL = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grSql.SuspendLayout();
            this.grHrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhân Viên: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "PassWord:";
            // 
            // textBoxMaNV
            // 
            this.textBoxMaNV.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaNV.Location = new System.Drawing.Point(207, 43);
            this.textBoxMaNV.Name = "textBoxMaNV";
            this.textBoxMaNV.Size = new System.Drawing.Size(210, 28);
            this.textBoxMaNV.TabIndex = 1;
            // 
            // textBoxPasswoed
            // 
            this.textBoxPasswoed.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswoed.Location = new System.Drawing.Point(207, 90);
            this.textBoxPasswoed.Name = "textBoxPasswoed";
            this.textBoxPasswoed.Size = new System.Drawing.Size(210, 28);
            this.textBoxPasswoed.TabIndex = 3;
            this.textBoxPasswoed.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLogin.ImageOptions.SvgImage")));
            this.btnLogin.Location = new System.Drawing.Point(242, 207);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(175, 38);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Location = new System.Drawing.Point(26, 207);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(122, 38);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Server";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pasword";
            // 
            // grSql
            // 
            this.grSql.Controls.Add(this.cbSql);
            this.grSql.Controls.Add(this.chkSqlIntegratedSecurity);
            this.grSql.Controls.Add(this.txtSqlDatabaseName);
            this.grSql.Controls.Add(this.label6);
            this.grSql.Controls.Add(this.btnDangNhapSql);
            this.grSql.Controls.Add(this.txtSqlPassword);
            this.grSql.Controls.Add(this.txtSqlUserName);
            this.grSql.Controls.Add(this.label3);
            this.grSql.Controls.Add(this.label5);
            this.grSql.Controls.Add(this.label4);
            this.grSql.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grSql.Location = new System.Drawing.Point(20, 25);
            this.grSql.Name = "grSql";
            this.grSql.Size = new System.Drawing.Size(410, 365);
            this.grSql.TabIndex = 0;
            this.grSql.TabStop = false;
            this.grSql.Text = "SQL Server Authentication";
            // 
            // cbSql
            // 
            this.cbSql.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSql.FormattingEnabled = true;
            this.cbSql.Location = new System.Drawing.Point(186, 48);
            this.cbSql.Name = "cbSql";
            this.cbSql.Size = new System.Drawing.Size(204, 29);
            this.cbSql.TabIndex = 1;
            // 
            // chkSqlIntegratedSecurity
            // 
            this.chkSqlIntegratedSecurity.AutoSize = true;
            this.chkSqlIntegratedSecurity.Checked = true;
            this.chkSqlIntegratedSecurity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSqlIntegratedSecurity.Location = new System.Drawing.Point(186, 233);
            this.chkSqlIntegratedSecurity.Name = "chkSqlIntegratedSecurity";
            this.chkSqlIntegratedSecurity.Size = new System.Drawing.Size(197, 25);
            this.chkSqlIntegratedSecurity.TabIndex = 8;
            this.chkSqlIntegratedSecurity.Text = "Integrated security";
            this.chkSqlIntegratedSecurity.UseVisualStyleBackColor = true;
            this.chkSqlIntegratedSecurity.CheckedChanged += new System.EventHandler(this.chkSqlIntegratedSecurity_CheckedChanged);
            // 
            // txtSqlDatabaseName
            // 
            this.txtSqlDatabaseName.Location = new System.Drawing.Point(186, 94);
            this.txtSqlDatabaseName.Name = "txtSqlDatabaseName";
            this.txtSqlDatabaseName.Size = new System.Drawing.Size(204, 28);
            this.txtSqlDatabaseName.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Database Name";
            // 
            // btnDangNhapSql
            // 
            this.btnDangNhapSql.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhapSql.Appearance.Options.UseFont = true;
            this.btnDangNhapSql.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangNhapSql.ImageOptions.SvgImage")));
            this.btnDangNhapSql.Location = new System.Drawing.Point(27, 307);
            this.btnDangNhapSql.Name = "btnDangNhapSql";
            this.btnDangNhapSql.Size = new System.Drawing.Size(363, 38);
            this.btnDangNhapSql.TabIndex = 9;
            this.btnDangNhapSql.Text = "Thiết lập dữ liệu lần đầu";
            this.btnDangNhapSql.Click += new System.EventHandler(this.btnDangNhapSql_Click);
            // 
            // txtSqlPassword
            // 
            this.txtSqlPassword.Location = new System.Drawing.Point(186, 186);
            this.txtSqlPassword.Name = "txtSqlPassword";
            this.txtSqlPassword.Size = new System.Drawing.Size(204, 28);
            this.txtSqlPassword.TabIndex = 7;
            // 
            // txtSqlUserName
            // 
            this.txtSqlUserName.Location = new System.Drawing.Point(186, 140);
            this.txtSqlUserName.Name = "txtSqlUserName";
            this.txtSqlUserName.Size = new System.Drawing.Size(204, 28);
            this.txtSqlUserName.TabIndex = 5;
            // 
            // grHrm
            // 
            this.grHrm.Controls.Add(this.label7);
            this.grHrm.Controls.Add(this.cbCSDL);
            this.grHrm.Controls.Add(this.label1);
            this.grHrm.Controls.Add(this.btnThoat);
            this.grHrm.Controls.Add(this.label2);
            this.grHrm.Controls.Add(this.btnLogin);
            this.grHrm.Controls.Add(this.textBoxMaNV);
            this.grHrm.Controls.Add(this.textBoxPasswoed);
            this.grHrm.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grHrm.Location = new System.Drawing.Point(465, 25);
            this.grHrm.Name = "grHrm";
            this.grHrm.Size = new System.Drawing.Size(507, 290);
            this.grHrm.TabIndex = 1;
            this.grHrm.TabStop = false;
            this.grHrm.Text = "Đăng Nhập";
            // 
            // cbCSDL
            // 
            this.cbCSDL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCSDL.FormattingEnabled = true;
            this.cbCSDL.Location = new System.Drawing.Point(207, 135);
            this.cbCSDL.Name = "cbCSDL";
            this.cbCSDL.Size = new System.Drawing.Size(204, 29);
            this.cbCSDL.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Chọn CSDL:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // formLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 523);
            this.Controls.Add(this.grHrm);
            this.Controls.Add(this.grSql);
            this.Name = "formLogIn";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.formLogIn_Load);
            this.grSql.ResumeLayout(false);
            this.grSql.PerformLayout();
            this.grHrm.ResumeLayout(false);
            this.grHrm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMaNV;
        private System.Windows.Forms.TextBox textBoxPasswoed;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grSql;
        private DevExpress.XtraEditors.SimpleButton btnDangNhapSql;
        private System.Windows.Forms.TextBox txtSqlPassword;
        private System.Windows.Forms.TextBox txtSqlUserName;
        private System.Windows.Forms.GroupBox grHrm;
        private System.Windows.Forms.CheckBox chkSqlIntegratedSecurity;
        private System.Windows.Forms.TextBox txtSqlDatabaseName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSql;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCSDL;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}