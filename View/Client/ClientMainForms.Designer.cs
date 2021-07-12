namespace GestionDeLocationVoiture.View.Client
{
    partial class ClientMainForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientMainForms));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bar = new System.Windows.Forms.Panel();
            this.settings = new System.Windows.Forms.Button();
            this.showbill = new System.Windows.Forms.Button();
            this.showcar = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.clientimg = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.ClientName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pan3 = new System.Windows.Forms.Panel();
            this.matricule3 = new System.Windows.Forms.Label();
            this.order3 = new System.Windows.Forms.Button();
            this.desc3 = new System.Windows.Forms.Label();
            this.pric3 = new System.Windows.Forms.Label();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.name3 = new System.Windows.Forms.Label();
            this.pan2 = new System.Windows.Forms.Panel();
            this.order2 = new System.Windows.Forms.Button();
            this.matricule2 = new System.Windows.Forms.Label();
            this.desc2 = new System.Windows.Forms.Label();
            this.pric2 = new System.Windows.Forms.Label();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.name2 = new System.Windows.Forms.Label();
            this.pan1 = new System.Windows.Forms.Panel();
            this.matricule1 = new System.Windows.Forms.Label();
            this.order1 = new System.Windows.Forms.Button();
            this.desc1 = new System.Windows.Forms.Label();
            this.pric1 = new System.Windows.Forms.Label();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.name1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ucSettingForClient2 = new GestionDeLocationVoiture.View.Client.UCSettingForClient();
            this.ucFactureClient1 = new GestionDeLocationVoiture.View.Client.UCFactureClient();
            this.ucShowCarByClient1 = new GestionDeLocationVoiture.View.Client.UCShowCarByClient();
            this.ucSearchCarByClient1 = new GestionDeLocationVoiture.View.Client.UCSearchCarByClient();
            this.ucNotificationClient1 = new GestionDeLocationVoiture.View.Client.UCNotificationClient();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pan3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            this.pan2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            this.pan1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.bar);
            this.panel1.Controls.Add(this.settings);
            this.panel1.Controls.Add(this.showbill);
            this.panel1.Controls.Add(this.showcar);
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.home);
            this.panel1.Controls.Add(this.shapeContainer1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(5)))), ((int)(((byte)(53)))));
            resources.ApplyResources(this.bar, "bar");
            this.bar.Name = "bar";
            this.bar.Paint += new System.Windows.Forms.PaintEventHandler(this.bar_Paint);
            // 
            // settings
            // 
            this.settings.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.settings, "settings");
            this.settings.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.settings.Image = global::GestionDeLocationVoiture.Properties.Resources.Settings;
            this.settings.Name = "settings";
            this.settings.UseVisualStyleBackColor = true;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // showbill
            // 
            this.showbill.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.showbill, "showbill");
            this.showbill.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.showbill.Image = global::GestionDeLocationVoiture.Properties.Resources.Bill;
            this.showbill.Name = "showbill";
            this.showbill.UseVisualStyleBackColor = true;
            this.showbill.Click += new System.EventHandler(this.showbill_Click);
            // 
            // showcar
            // 
            this.showcar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.showcar, "showcar");
            this.showcar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.showcar.Image = global::GestionDeLocationVoiture.Properties.Resources.icons8_Car;
            this.showcar.Name = "showcar";
            this.showcar.UseVisualStyleBackColor = true;
            this.showcar.Click += new System.EventHandler(this.showcar_Click);
            // 
            // search
            // 
            this.search.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.search, "search");
            this.search.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.search.Name = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.button2_Click);
            // 
            // home
            // 
            this.home.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.home, "home");
            this.home.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.home.Name = "home";
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // shapeContainer1
            // 
            resources.ApplyResources(this.shapeContainer1, "shapeContainer1");
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.clientimg});
            this.shapeContainer1.TabStop = false;
            // 
            // clientimg
            // 
            resources.ApplyResources(this.clientimg, "clientimg");
            this.clientimg.Name = "clientimg";
            this.clientimg.Click += new System.EventHandler(this.rectangleShape1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(5)))), ((int)(((byte)(53)))));
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.ClientName);
            this.panel3.Controls.Add(this.label1);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button7
            // 
            resources.ApplyResources(this.button7, "button7");
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            resources.ApplyResources(this.button8, "button8");
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.Name = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // ClientName
            // 
            resources.ApplyResources(this.ClientName, "ClientName");
            this.ClientName.Name = "ClientName";
            this.ClientName.Click += new System.EventHandler(this.ClientName_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(239)))), ((int)(((byte)(241)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.ucNotificationClient1);
            this.panel4.Controls.Add(this.ucSettingForClient2);
            this.panel4.Controls.Add(this.ucFactureClient1);
            this.panel4.Controls.Add(this.ucShowCarByClient1);
            this.panel4.Controls.Add(this.ucSearchCarByClient1);
            this.panel4.Controls.Add(this.pan3);
            this.panel4.Controls.Add(this.pan2);
            this.panel4.Controls.Add(this.pan1);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // pan3
            // 
            this.pan3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan3.Controls.Add(this.matricule3);
            this.pan3.Controls.Add(this.order3);
            this.pan3.Controls.Add(this.desc3);
            this.pan3.Controls.Add(this.pric3);
            this.pan3.Controls.Add(this.pic3);
            this.pan3.Controls.Add(this.name3);
            resources.ApplyResources(this.pan3, "pan3");
            this.pan3.Name = "pan3";
            this.pan3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // matricule3
            // 
            resources.ApplyResources(this.matricule3, "matricule3");
            this.matricule3.Name = "matricule3";
            this.matricule3.Click += new System.EventHandler(this.matricule3_Click);
            // 
            // order3
            // 
            this.order3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.order3, "order3");
            this.order3.Image = global::GestionDeLocationVoiture.Properties.Resources.icons8_Shopping_Cart_1;
            this.order3.Name = "order3";
            this.order3.UseVisualStyleBackColor = false;
            this.order3.Click += new System.EventHandler(this.button14_Click);
            // 
            // desc3
            // 
            resources.ApplyResources(this.desc3, "desc3");
            this.desc3.Name = "desc3";
            this.desc3.UseMnemonic = false;
            this.desc3.Click += new System.EventHandler(this.desc3_Click);
            // 
            // pric3
            // 
            resources.ApplyResources(this.pric3, "pric3");
            this.pric3.ForeColor = System.Drawing.Color.MediumBlue;
            this.pric3.Name = "pric3";
            this.pric3.Click += new System.EventHandler(this.pric3_Click);
            // 
            // pic3
            // 
            resources.ApplyResources(this.pic3, "pic3");
            this.pic3.Name = "pic3";
            this.pic3.TabStop = false;
            this.pic3.Click += new System.EventHandler(this.pic3_Click);
            // 
            // name3
            // 
            resources.ApplyResources(this.name3, "name3");
            this.name3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name3.Name = "name3";
            this.name3.Click += new System.EventHandler(this.name3_Click);
            // 
            // pan2
            // 
            this.pan2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan2.Controls.Add(this.order2);
            this.pan2.Controls.Add(this.matricule2);
            this.pan2.Controls.Add(this.desc2);
            this.pan2.Controls.Add(this.pric2);
            this.pan2.Controls.Add(this.pic2);
            this.pan2.Controls.Add(this.name2);
            resources.ApplyResources(this.pan2, "pan2");
            this.pan2.Name = "pan2";
            this.pan2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // order2
            // 
            this.order2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.order2, "order2");
            this.order2.Image = global::GestionDeLocationVoiture.Properties.Resources.icons8_Shopping_Cart_1;
            this.order2.Name = "order2";
            this.order2.UseVisualStyleBackColor = false;
            this.order2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // matricule2
            // 
            resources.ApplyResources(this.matricule2, "matricule2");
            this.matricule2.Name = "matricule2";
            this.matricule2.Click += new System.EventHandler(this.matricule1_Click);
            // 
            // desc2
            // 
            resources.ApplyResources(this.desc2, "desc2");
            this.desc2.Name = "desc2";
            this.desc2.UseMnemonic = false;
            this.desc2.Click += new System.EventHandler(this.desc1_Click);
            // 
            // pric2
            // 
            resources.ApplyResources(this.pric2, "pric2");
            this.pric2.ForeColor = System.Drawing.Color.MediumBlue;
            this.pric2.Name = "pric2";
            this.pric2.Click += new System.EventHandler(this.pric1_Click);
            // 
            // pic2
            // 
            resources.ApplyResources(this.pic2, "pic2");
            this.pic2.Name = "pic2";
            this.pic2.TabStop = false;
            this.pic2.Click += new System.EventHandler(this.pic1_Click);
            // 
            // name2
            // 
            resources.ApplyResources(this.name2, "name2");
            this.name2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name2.Name = "name2";
            this.name2.Click += new System.EventHandler(this.name1_Click);
            // 
            // pan1
            // 
            this.pan1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan1.Controls.Add(this.matricule1);
            this.pan1.Controls.Add(this.order1);
            this.pan1.Controls.Add(this.desc1);
            this.pan1.Controls.Add(this.pric1);
            this.pan1.Controls.Add(this.pic1);
            this.pan1.Controls.Add(this.name1);
            resources.ApplyResources(this.pan1, "pan1");
            this.pan1.Name = "pan1";
            this.pan1.UseWaitCursor = true;
            this.pan1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // matricule1
            // 
            resources.ApplyResources(this.matricule1, "matricule1");
            this.matricule1.Name = "matricule1";
            this.matricule1.UseWaitCursor = true;
            this.matricule1.Click += new System.EventHandler(this.matricule1_Click);
            // 
            // order1
            // 
            this.order1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(171)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.order1, "order1");
            this.order1.Image = global::GestionDeLocationVoiture.Properties.Resources.icons8_Shopping_Cart_1;
            this.order1.Name = "order1";
            this.order1.UseVisualStyleBackColor = false;
            this.order1.UseWaitCursor = true;
            this.order1.Click += new System.EventHandler(this.button12_Click);
            // 
            // desc1
            // 
            resources.ApplyResources(this.desc1, "desc1");
            this.desc1.Name = "desc1";
            this.desc1.UseMnemonic = false;
            this.desc1.UseWaitCursor = true;
            this.desc1.Click += new System.EventHandler(this.desc1_Click);
            // 
            // pric1
            // 
            resources.ApplyResources(this.pric1, "pric1");
            this.pric1.ForeColor = System.Drawing.Color.MediumBlue;
            this.pric1.Name = "pric1";
            this.pric1.UseWaitCursor = true;
            this.pric1.Click += new System.EventHandler(this.pric1_Click);
            // 
            // pic1
            // 
            resources.ApplyResources(this.pic1, "pic1");
            this.pic1.Name = "pic1";
            this.pic1.TabStop = false;
            this.pic1.UseWaitCursor = true;
            this.pic1.Click += new System.EventHandler(this.pic1_Click);
            // 
            // name1
            // 
            resources.ApplyResources(this.name1, "name1");
            this.name1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name1.Name = "name1";
            this.name1.UseWaitCursor = true;
            this.name1.Click += new System.EventHandler(this.name1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ucSettingForClient2
            // 
            this.ucSettingForClient2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.ucSettingForClient2.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.ucSettingForClient2, "ucSettingForClient2");
            this.ucSettingForClient2.Name = "ucSettingForClient2";
            // 
            // ucFactureClient1
            // 
            resources.ApplyResources(this.ucFactureClient1, "ucFactureClient1");
            this.ucFactureClient1.Name = "ucFactureClient1";
            // 
            // ucShowCarByClient1
            // 
            resources.ApplyResources(this.ucShowCarByClient1, "ucShowCarByClient1");
            this.ucShowCarByClient1.Name = "ucShowCarByClient1";
            // 
            // ucSearchCarByClient1
            // 
            this.ucSearchCarByClient1.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.ucSearchCarByClient1, "ucSearchCarByClient1");
            this.ucSearchCarByClient1.Name = "ucSearchCarByClient1";
            // 
            // ucNotificationClient1
            // 
            this.ucNotificationClient1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            resources.ApplyResources(this.ucNotificationClient1, "ucNotificationClient1");
            this.ucNotificationClient1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucNotificationClient1.Name = "ucNotificationClient1";
            // 
            // ClientMainForms
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientMainForms";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.ClientMainForms_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.pan3.ResumeLayout(false);
            this.pan3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            this.pan2.ResumeLayout(false);
            this.pan2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            this.pan1.ResumeLayout(false);
            this.pan1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button showbill;
        private System.Windows.Forms.Button showcar;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label ClientName;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Panel bar;
        private System.Windows.Forms.Panel pan1;
        private System.Windows.Forms.Button order1;
        private System.Windows.Forms.Label desc1;
        private System.Windows.Forms.Label pric1;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Label name1;
        private System.Windows.Forms.Panel pan3;
        private System.Windows.Forms.Button order3;
        private System.Windows.Forms.Label desc3;
        private System.Windows.Forms.Label pric3;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.Label name3;
        private System.Windows.Forms.Label matricule3;
        private System.Windows.Forms.Label matricule1;
        public Microsoft.VisualBasic.PowerPacks.RectangleShape clientimg;
        private System.Windows.Forms.Panel pan2;
        private System.Windows.Forms.Button order2;
        private System.Windows.Forms.Label matricule2;
        private System.Windows.Forms.Label desc2;
        private System.Windows.Forms.Label pric2;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.Label name2;
        private UCSettingForClient ucSettingForClient1;
        private UCSettingForClient ucSettingForClient2;
        private UCFactureClient ucFactureClient1;
        private UCShowCarByClient ucShowCarByClient1;
        private UCSearchCarByClient ucSearchCarByClient1;
        private UCNotificationClient ucNotificationClient1;



    }
}