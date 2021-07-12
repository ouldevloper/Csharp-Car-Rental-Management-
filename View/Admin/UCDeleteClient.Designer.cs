namespace GestionDeLocationVoiture.View.Admin
{
    partial class UCDeleteClient
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCDeleteClient));
            this.email = new MetroFramework.Controls.MetroTextBox();
            this.fullname = new MetroFramework.Controls.MetroTextBox();
            this.cin = new MetroFramework.Controls.MetroTextBox();
            this.phone = new MetroFramework.Controls.MetroTextBox();
            this.datenassance = new MetroFramework.Controls.MetroTextBox();
            this.id = new MetroFramework.Controls.MetroTextBox();
            this.address = new MetroFramework.Controls.MetroTextBox();
            this.Delete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.img = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cancel = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.Enabled = false;
            this.email.Location = new System.Drawing.Point(133, 198);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(211, 29);
            this.email.TabIndex = 7;
            // 
            // fullname
            // 
            this.fullname.Enabled = false;
            this.fullname.Location = new System.Drawing.Point(133, 163);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(211, 29);
            this.fullname.TabIndex = 7;
            // 
            // cin
            // 
            this.cin.Enabled = false;
            this.cin.Location = new System.Drawing.Point(133, 128);
            this.cin.Name = "cin";
            this.cin.Size = new System.Drawing.Size(211, 29);
            this.cin.TabIndex = 7;
            // 
            // phone
            // 
            this.phone.Enabled = false;
            this.phone.Location = new System.Drawing.Point(133, 233);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(211, 29);
            this.phone.TabIndex = 7;
            this.phone.Click += new System.EventHandler(this.metroTextBox6_Click);
            // 
            // datenassance
            // 
            this.datenassance.Enabled = false;
            this.datenassance.Location = new System.Drawing.Point(133, 268);
            this.datenassance.Name = "datenassance";
            this.datenassance.Size = new System.Drawing.Size(211, 29);
            this.datenassance.TabIndex = 7;
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("MS Reference Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(133, 70);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(452, 41);
            this.id.TabIndex = 0;
            this.id.Click += new System.EventHandler(this.id_Click);
            // 
            // address
            // 
            this.address.Enabled = false;
            this.address.Location = new System.Drawing.Point(133, 303);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(500, 81);
            this.address.TabIndex = 40;
            // 
            // Delete
            // 
            this.Delete.ActiveBorderThickness = 1;
            this.Delete.ActiveCornerRadius = 20;
            this.Delete.ActiveFillColor = System.Drawing.Color.MediumBlue;
            this.Delete.ActiveForecolor = System.Drawing.Color.White;
            this.Delete.ActiveLineColor = System.Drawing.Color.MediumBlue;
            this.Delete.BackColor = System.Drawing.SystemColors.Control;
            this.Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete.BackgroundImage")));
            this.Delete.ButtonText = "Delete";
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.IdleBorderThickness = 1;
            this.Delete.IdleCornerRadius = 20;
            this.Delete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(41)))), ((int)(((byte)(225)))));
            this.Delete.IdleForecolor = System.Drawing.Color.White;
            this.Delete.IdleLineColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(250, 392);
            this.Delete.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(134, 41);
            this.Delete.TabIndex = 2;
            this.Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(353, 128);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(280, 169);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 8;
            this.img.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::GestionDeLocationVoiture.Properties.Resources.icons8_Find_User_Male_3;
            this.button1.Location = new System.Drawing.Point(584, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 41);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.cancel.Location = new System.Drawing.Point(394, 392);
            this.cancel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(134, 41);
            this.cancel.TabIndex = 3;
            this.cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancel.Click += new System.EventHandler(this.cancel_Click_1);
            // 
            // UCDeleteClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.address);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.img);
            this.Controls.Add(this.datenassance);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.cin);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.email);
            this.Controls.Add(this.id);
            this.Name = "UCDeleteClient";
            this.Size = new System.Drawing.Size(793, 467);
            this.Load += new System.EventHandler(this.UCDeleteClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox email;
        private MetroFramework.Controls.MetroTextBox fullname;
        private MetroFramework.Controls.MetroTextBox cin;
        private MetroFramework.Controls.MetroTextBox phone;
        private MetroFramework.Controls.MetroTextBox datenassance;
        private System.Windows.Forms.PictureBox img;
        private MetroFramework.Controls.MetroTextBox id;
        private Bunifu.Framework.UI.BunifuThinButton2 Delete;
        private MetroFramework.Controls.MetroTextBox address;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuThinButton2 cancel;


    }
}
