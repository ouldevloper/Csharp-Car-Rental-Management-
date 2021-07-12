namespace GestionDeLocationVoiture
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flatClose1 = new theme.FlatClose();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bar = new System.Windows.Forms.Panel();
            this.signup = new System.Windows.Forms.Button();
            this.Signin = new System.Windows.Forms.Button();
            this.panlog = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.remamber = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.loginreset = new Bunifu.Framework.UI.BunifuThinButton2();
            this.log = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pwd = new MetroFramework.Controls.MetroTextBox();
            this.id = new MetroFramework.Controls.MetroTextBox();
            this.ucSignup2 = new GestionDeLocationVoiture.View.Login.UCSignup();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panlog.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(4)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.flatClose1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 29);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(728, 3);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 3;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatClose1.Click += new System.EventHandler(this.flatClose1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.bar);
            this.panel2.Controls.Add(this.signup);
            this.panel2.Controls.Add(this.Signin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 65);
            this.panel2.TabIndex = 1;
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(4)))), ((int)(((byte)(53)))));
            this.bar.Location = new System.Drawing.Point(204, 52);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(166, 10);
            this.bar.TabIndex = 1;
            // 
            // signup
            // 
            this.signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(41)))), ((int)(((byte)(225)))));
            this.signup.FlatAppearance.BorderSize = 0;
            this.signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.Location = new System.Drawing.Point(370, 19);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(166, 33);
            this.signup.TabIndex = 0;
            this.signup.Text = "SignUp";
            this.signup.UseVisualStyleBackColor = false;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // Signin
            // 
            this.Signin.BackColor = System.Drawing.Color.SeaGreen;
            this.Signin.FlatAppearance.BorderSize = 0;
            this.Signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signin.Location = new System.Drawing.Point(204, 19);
            this.Signin.Name = "Signin";
            this.Signin.Size = new System.Drawing.Size(166, 33);
            this.Signin.TabIndex = 0;
            this.Signin.Text = "SignIn";
            this.Signin.UseVisualStyleBackColor = false;
            this.Signin.Click += new System.EventHandler(this.Signin_Click);
            // 
            // panlog
            // 
            this.panlog.BackColor = System.Drawing.SystemColors.Control;
            this.panlog.Controls.Add(this.ucSignup2);
            this.panlog.Controls.Add(this.bunifuCustomLabel1);
            this.panlog.Controls.Add(this.remamber);
            this.panlog.Controls.Add(this.cancel);
            this.panlog.Controls.Add(this.loginreset);
            this.panlog.Controls.Add(this.log);
            this.panlog.Controls.Add(this.label4);
            this.panlog.Controls.Add(this.label2);
            this.panlog.Controls.Add(this.pwd);
            this.panlog.Controls.Add(this.id);
            this.panlog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panlog.Location = new System.Drawing.Point(0, 95);
            this.panlog.Name = "panlog";
            this.panlog.Size = new System.Drawing.Size(749, 415);
            this.panlog.TabIndex = 2;
            this.panlog.Paint += new System.Windows.Forms.PaintEventHandler(this.panlog_Paint);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(294, 187);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(120, 22);
            this.bunifuCustomLabel1.TabIndex = 76;
            this.bunifuCustomLabel1.Text = "Remember Me";
            // 
            // remamber
            // 
            this.remamber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.remamber.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.remamber.Checked = false;
            this.remamber.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.remamber.ForeColor = System.Drawing.Color.White;
            this.remamber.Location = new System.Drawing.Point(271, 189);
            this.remamber.Name = "remamber";
            this.remamber.Size = new System.Drawing.Size(20, 20);
            this.remamber.TabIndex = 75;
            // 
            // cancel
            // 
            this.cancel.ActiveBorderThickness = 1;
            this.cancel.ActiveCornerRadius = 20;
            this.cancel.ActiveFillColor = System.Drawing.Color.MediumBlue;
            this.cancel.ActiveForecolor = System.Drawing.Color.White;
            this.cancel.ActiveLineColor = System.Drawing.Color.MediumBlue;
            this.cancel.BackColor = System.Drawing.SystemColors.Control;
            this.cancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancel.BackgroundImage")));
            this.cancel.ButtonText = "Cancel";
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.IdleBorderThickness = 1;
            this.cancel.IdleCornerRadius = 20;
            this.cancel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.cancel.IdleForecolor = System.Drawing.Color.White;
            this.cancel.IdleLineColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(583, 219);
            this.cancel.Margin = new System.Windows.Forms.Padding(5);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(134, 41);
            this.cancel.TabIndex = 74;
            this.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // loginreset
            // 
            this.loginreset.ActiveBorderThickness = 1;
            this.loginreset.ActiveCornerRadius = 20;
            this.loginreset.ActiveFillColor = System.Drawing.Color.MediumBlue;
            this.loginreset.ActiveForecolor = System.Drawing.Color.White;
            this.loginreset.ActiveLineColor = System.Drawing.Color.MediumBlue;
            this.loginreset.BackColor = System.Drawing.SystemColors.Control;
            this.loginreset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginreset.BackgroundImage")));
            this.loginreset.ButtonText = "Reset";
            this.loginreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginreset.ForeColor = System.Drawing.Color.White;
            this.loginreset.IdleBorderThickness = 1;
            this.loginreset.IdleCornerRadius = 20;
            this.loginreset.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(41)))), ((int)(((byte)(225)))));
            this.loginreset.IdleForecolor = System.Drawing.Color.White;
            this.loginreset.IdleLineColor = System.Drawing.Color.White;
            this.loginreset.Location = new System.Drawing.Point(298, 219);
            this.loginreset.Margin = new System.Windows.Forms.Padding(5);
            this.loginreset.Name = "loginreset";
            this.loginreset.Size = new System.Drawing.Size(134, 41);
            this.loginreset.TabIndex = 73;
            this.loginreset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginreset.Click += new System.EventHandler(this.loginreset_Click);
            // 
            // log
            // 
            this.log.ActiveBorderThickness = 1;
            this.log.ActiveCornerRadius = 20;
            this.log.ActiveFillColor = System.Drawing.Color.MediumBlue;
            this.log.ActiveForecolor = System.Drawing.Color.White;
            this.log.ActiveLineColor = System.Drawing.Color.MediumBlue;
            this.log.BackColor = System.Drawing.SystemColors.Control;
            this.log.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("log.BackgroundImage")));
            this.log.ButtonText = "Login";
            this.log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.log.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log.ForeColor = System.Drawing.Color.White;
            this.log.IdleBorderThickness = 1;
            this.log.IdleCornerRadius = 20;
            this.log.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.log.IdleForecolor = System.Drawing.Color.White;
            this.log.IdleLineColor = System.Drawing.Color.White;
            this.log.Location = new System.Drawing.Point(442, 219);
            this.log.Margin = new System.Windows.Forms.Padding(5);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(134, 41);
            this.log.TabIndex = 72;
            this.log.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Password";
            // 
            // pwd
            // 
            this.pwd.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwd.Location = new System.Drawing.Point(271, 150);
            this.pwd.Name = "pwd";
            this.pwd.PasswordChar = 'X';
            this.pwd.Size = new System.Drawing.Size(305, 29);
            this.pwd.TabIndex = 58;
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(271, 107);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(305, 29);
            this.id.TabIndex = 56;
            // 
            // ucSignup2
            // 
            this.ucSignup2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucSignup2.Location = new System.Drawing.Point(0, 0);
            this.ucSignup2.Name = "ucSignup2";
            this.ucSignup2.Size = new System.Drawing.Size(749, 415);
            this.ucSignup2.TabIndex = 77;
            this.ucSignup2.Load += new System.EventHandler(this.ucSignup2_Load);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(749, 510);
            this.Controls.Add(this.panlog);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.TransparencyKey = System.Drawing.Color.GhostWhite;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panlog.ResumeLayout(false);
            this.panlog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button signup;
        private theme.FlatClose flatClose1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panlog;
        private Bunifu.Framework.UI.BunifuThinButton2 cancel;
        private Bunifu.Framework.UI.BunifuThinButton2 loginreset;
        private Bunifu.Framework.UI.BunifuThinButton2 log;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox pwd;
        private MetroFramework.Controls.MetroTextBox id;
        private View.Login.UCSignup ucSignup1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCheckbox remamber;
        private View.Login.UCSignup ucSignup2;
        public System.Windows.Forms.Button Signin;
        public System.Windows.Forms.Panel bar;

    }
}

