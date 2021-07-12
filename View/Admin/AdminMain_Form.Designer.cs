namespace GestionDeLocationVoiture.View.Admin
{
    partial class AdminMain_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.admindeleteclient = new System.Windows.Forms.Button();
            this.adminaddmanager = new System.Windows.Forms.Button();
            this.adminpromotion = new System.Windows.Forms.Button();
            this.baradmin = new System.Windows.Forms.Panel();
            this.Adminhome = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.adminimg = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flatButton1 = new theme.FlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.log = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.ucPushPromotion1 = new GestionDeLocationVoiture.View.Admin.UCPushPromotion();
            this.ucDeleteClient1 = new GestionDeLocationVoiture.View.Admin.UCDeleteClient();
            this.ucAdd_Managers2 = new GestionDeLocationVoiture.View.Admin.UCAdd_Managers();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.log)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.admindeleteclient);
            this.panel1.Controls.Add(this.adminaddmanager);
            this.panel1.Controls.Add(this.adminpromotion);
            this.panel1.Controls.Add(this.baradmin);
            this.panel1.Controls.Add(this.Adminhome);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 518);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // admindeleteclient
            // 
            this.admindeleteclient.FlatAppearance.BorderSize = 0;
            this.admindeleteclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admindeleteclient.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.admindeleteclient.Image = global::GestionDeLocationVoiture.Properties.Resources.Remove_Administrator;
            this.admindeleteclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.admindeleteclient.Location = new System.Drawing.Point(12, 312);
            this.admindeleteclient.Name = "admindeleteclient";
            this.admindeleteclient.Size = new System.Drawing.Size(191, 53);
            this.admindeleteclient.TabIndex = 1;
            this.admindeleteclient.Text = "Delete Client";
            this.admindeleteclient.UseVisualStyleBackColor = true;
            this.admindeleteclient.Click += new System.EventHandler(this.admindeleteclient_Click);
            // 
            // adminaddmanager
            // 
            this.adminaddmanager.FlatAppearance.BorderSize = 0;
            this.adminaddmanager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminaddmanager.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.adminaddmanager.Image = global::GestionDeLocationVoiture.Properties.Resources.icons8_Add_Administrator;
            this.adminaddmanager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminaddmanager.Location = new System.Drawing.Point(12, 255);
            this.adminaddmanager.Name = "adminaddmanager";
            this.adminaddmanager.Size = new System.Drawing.Size(191, 53);
            this.adminaddmanager.TabIndex = 1;
            this.adminaddmanager.Text = "Add Manager";
            this.adminaddmanager.UseVisualStyleBackColor = true;
            this.adminaddmanager.Click += new System.EventHandler(this.adminaddmanager_Click);
            // 
            // adminpromotion
            // 
            this.adminpromotion.FlatAppearance.BorderSize = 0;
            this.adminpromotion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminpromotion.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.adminpromotion.Image = global::GestionDeLocationVoiture.Properties.Resources.icons8_Advertising;
            this.adminpromotion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminpromotion.Location = new System.Drawing.Point(12, 198);
            this.adminpromotion.Name = "adminpromotion";
            this.adminpromotion.Size = new System.Drawing.Size(191, 53);
            this.adminpromotion.TabIndex = 1;
            this.adminpromotion.Text = "Promotion";
            this.adminpromotion.UseVisualStyleBackColor = true;
            this.adminpromotion.Click += new System.EventHandler(this.adminpromotion_Click);
            // 
            // baradmin
            // 
            this.baradmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(3)))), ((int)(((byte)(53)))));
            this.baradmin.Location = new System.Drawing.Point(3, 144);
            this.baradmin.Name = "baradmin";
            this.baradmin.Size = new System.Drawing.Size(10, 52);
            this.baradmin.TabIndex = 2;
            // 
            // Adminhome
            // 
            this.Adminhome.FlatAppearance.BorderSize = 0;
            this.Adminhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Adminhome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Adminhome.Image = global::GestionDeLocationVoiture.Properties.Resources.Home;
            this.Adminhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Adminhome.Location = new System.Drawing.Point(12, 143);
            this.Adminhome.Name = "Adminhome";
            this.Adminhome.Size = new System.Drawing.Size(191, 53);
            this.Adminhome.TabIndex = 1;
            this.Adminhome.Text = "Home";
            this.Adminhome.UseVisualStyleBackColor = true;
            this.Adminhome.Click += new System.EventHandler(this.Adminhome_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.adminimg});
            this.shapeContainer1.Size = new System.Drawing.Size(204, 518);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // adminimg
            // 
            this.adminimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminimg.CornerRadius = 53;
            this.adminimg.Location = new System.Drawing.Point(47, 12);
            this.adminimg.Name = "adminimg";
            this.adminimg.Size = new System.Drawing.Size(108, 106);
            this.adminimg.Click += new System.EventHandler(this.rectangleShape1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(4)))), ((int)(((byte)(53)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(204, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 12);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(204, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(793, 38);
            this.panel3.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::GestionDeLocationVoiture.Properties.Resources.Shutdown_1;
            this.button2.Location = new System.Drawing.Point(712, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 27);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome Back";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::GestionDeLocationVoiture.Properties.Resources.exit;
            this.button1.Location = new System.Drawing.Point(746, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 27);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.ucAdd_Managers2);
            this.panel4.Controls.Add(this.ucDeleteClient1);
            this.panel4.Controls.Add(this.ucPushPromotion1);
            this.panel4.Controls.Add(this.flatButton1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.log);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(204, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(793, 467);
            this.panel4.TabIndex = 2;
            // 
            // flatButton1
            // 
            this.flatButton1.BackColor = System.Drawing.Color.Transparent;
            this.flatButton1.BaseColor = System.Drawing.Color.Maroon;
            this.flatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatButton1.Location = new System.Drawing.Point(341, 437);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Rounded = false;
            this.flatButton1.Size = new System.Drawing.Size(106, 27);
            this.flatButton1.TabIndex = 1;
            this.flatButton1.Text = "Clear Logs";
            this.flatButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatButton1.Click += new System.EventHandler(this.flatButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(303, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 35);
            this.label2.TabIndex = 6;
            this.label2.Text = "System Logs";
            // 
            // log
            // 
            this.log.AllowUserToAddRows = false;
            this.log.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.log.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.log.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.log.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.log.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.log.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.log.DoubleBuffered = true;
            this.log.EnableHeadersVisualStyles = false;
            this.log.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.log.HeaderBgColor = System.Drawing.Color.DarkBlue;
            this.log.HeaderForeColor = System.Drawing.Color.White;
            this.log.Location = new System.Drawing.Point(9, 43);
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.log.Size = new System.Drawing.Size(772, 388);
            this.log.TabIndex = 0;
            // 
            // ucPushPromotion1
            // 
            this.ucPushPromotion1.Location = new System.Drawing.Point(0, 2);
            this.ucPushPromotion1.Name = "ucPushPromotion1";
            this.ucPushPromotion1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ucPushPromotion1.Size = new System.Drawing.Size(793, 467);
            this.ucPushPromotion1.TabIndex = 7;
            // 
            // ucDeleteClient1
            // 
            this.ucDeleteClient1.Location = new System.Drawing.Point(0, 0);
            this.ucDeleteClient1.Name = "ucDeleteClient1";
            this.ucDeleteClient1.Size = new System.Drawing.Size(793, 467);
            this.ucDeleteClient1.TabIndex = 3;
            // 
            // ucAdd_Managers2
            // 
            this.ucAdd_Managers2.Location = new System.Drawing.Point(0, 0);
            this.ucAdd_Managers2.Name = "ucAdd_Managers2";
            this.ucAdd_Managers2.Size = new System.Drawing.Size(793, 467);
            this.ucAdd_Managers2.TabIndex = 8;
            // 
            // AdminMain_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(997, 518);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMain_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMain_Form";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.log)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Button Adminhome;
        private System.Windows.Forms.Button admindeleteclient;
        private System.Windows.Forms.Button adminaddmanager;
        private System.Windows.Forms.Button adminpromotion;
        private System.Windows.Forms.Panel baradmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        public Microsoft.VisualBasic.PowerPacks.RectangleShape adminimg;
        private System.Windows.Forms.Button button2;
        private theme.FlatButton flatButton1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid log;
        private System.Windows.Forms.Label label2;
        private UCAdd_Managers ucAdd_Managers1;
        private UCAdd_Managers ucAdd_Managers2;
        private UCDeleteClient ucDeleteClient1;
        private UCPushPromotion ucPushPromotion1;

    }
}