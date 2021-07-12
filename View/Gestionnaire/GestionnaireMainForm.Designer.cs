namespace GestionDeLocationVoiture.View.Gestionnaire
{
    partial class GestionnaireMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionnaireMainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addcar = new System.Windows.Forms.Button();
            this.showaviablecars = new System.Windows.Forms.Button();
            this.carmanagement = new System.Windows.Forms.Button();
            this.postingbill = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.managerhome = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.usShowAviable1 = new GestionDeLocationVoiture.View.Gestionnaire.USShowAviable();
            this.ucRemoveCar1 = new GestionDeLocationVoiture.View.Gestionnaire.UCRemoveCar();
            this.ucAddCar1 = new GestionDeLocationVoiture.View.Gestionnaire.UCAddCar();
            this.ucPostBill1 = new GestionDeLocationVoiture.View.Gestionnaire.UCPostBill();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.search = new MetroFramework.Controls.MetroTextBox();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.reservegrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservegrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.addcar);
            this.panel1.Controls.Add(this.showaviablecars);
            this.panel1.Controls.Add(this.carmanagement);
            this.panel1.Controls.Add(this.postingbill);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.managerhome);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 518);
            this.panel1.TabIndex = 0;
            // 
            // addcar
            // 
            this.addcar.FlatAppearance.BorderSize = 0;
            this.addcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addcar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addcar.Image = global::GestionDeLocationVoiture.Properties.Resources.icons8_Car_Rental_1;
            this.addcar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addcar.Location = new System.Drawing.Point(10, 250);
            this.addcar.Name = "addcar";
            this.addcar.Size = new System.Drawing.Size(191, 53);
            this.addcar.TabIndex = 3;
            this.addcar.Text = "Add Car";
            this.addcar.UseVisualStyleBackColor = true;
            this.addcar.Click += new System.EventHandler(this.addcar_Click);
            // 
            // showaviablecars
            // 
            this.showaviablecars.FlatAppearance.BorderSize = 0;
            this.showaviablecars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showaviablecars.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.showaviablecars.Image = global::GestionDeLocationVoiture.Properties.Resources.icons8_Traffic_Jam;
            this.showaviablecars.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showaviablecars.Location = new System.Drawing.Point(8, 362);
            this.showaviablecars.Name = "showaviablecars";
            this.showaviablecars.Size = new System.Drawing.Size(191, 53);
            this.showaviablecars.TabIndex = 3;
            this.showaviablecars.Text = "Show Aviable Cars";
            this.showaviablecars.UseVisualStyleBackColor = true;
            this.showaviablecars.Click += new System.EventHandler(this.showaviablecars_Click);
            // 
            // carmanagement
            // 
            this.carmanagement.FlatAppearance.BorderSize = 0;
            this.carmanagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carmanagement.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.carmanagement.Image = global::GestionDeLocationVoiture.Properties.Resources.icons8_Trash;
            this.carmanagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.carmanagement.Location = new System.Drawing.Point(8, 309);
            this.carmanagement.Name = "carmanagement";
            this.carmanagement.Size = new System.Drawing.Size(191, 53);
            this.carmanagement.TabIndex = 3;
            this.carmanagement.Text = "Remove Car";
            this.carmanagement.UseVisualStyleBackColor = true;
            this.carmanagement.Click += new System.EventHandler(this.carmanagement_Click);
            // 
            // postingbill
            // 
            this.postingbill.FlatAppearance.BorderSize = 0;
            this.postingbill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.postingbill.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.postingbill.Image = global::GestionDeLocationVoiture.Properties.Resources.icons8_Add;
            this.postingbill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.postingbill.Location = new System.Drawing.Point(10, 196);
            this.postingbill.Name = "postingbill";
            this.postingbill.Size = new System.Drawing.Size(191, 53);
            this.postingbill.TabIndex = 3;
            this.postingbill.Text = "Posting Bill";
            this.postingbill.UseVisualStyleBackColor = true;
            this.postingbill.Click += new System.EventHandler(this.postingbill_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(3)))), ((int)(((byte)(53)))));
            this.panel5.Location = new System.Drawing.Point(3, 144);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 51);
            this.panel5.TabIndex = 4;
            // 
            // managerhome
            // 
            this.managerhome.FlatAppearance.BorderSize = 0;
            this.managerhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managerhome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.managerhome.Image = global::GestionDeLocationVoiture.Properties.Resources.Home;
            this.managerhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.managerhome.Location = new System.Drawing.Point(12, 143);
            this.managerhome.Name = "managerhome";
            this.managerhome.Size = new System.Drawing.Size(191, 53);
            this.managerhome.TabIndex = 3;
            this.managerhome.Text = "Home";
            this.managerhome.UseVisualStyleBackColor = true;
            this.managerhome.Click += new System.EventHandler(this.managerhome_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(204, 518);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectangleShape1.CornerRadius = 53;
            this.rectangleShape1.Location = new System.Drawing.Point(47, 12);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(108, 106);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(3)))), ((int)(((byte)(53)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(204, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 12);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(204, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(793, 38);
            this.panel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::GestionDeLocationVoiture.Properties.Resources.Shutdown_1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(695, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 28);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::GestionDeLocationVoiture.Properties.Resources.exit;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(741, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 28);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel4.Controls.Add(this.usShowAviable1);
            this.panel4.Controls.Add(this.ucRemoveCar1);
            this.panel4.Controls.Add(this.ucAddCar1);
            this.panel4.Controls.Add(this.ucPostBill1);
            this.panel4.Controls.Add(this.bunifuImageButton1);
            this.panel4.Controls.Add(this.search);
            this.panel4.Controls.Add(this.bunifuFlatButton2);
            this.panel4.Controls.Add(this.bunifuFlatButton1);
            this.panel4.Controls.Add(this.reservegrid);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(204, 51);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(793, 467);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // usShowAviable1
            // 
            this.usShowAviable1.Location = new System.Drawing.Point(0, -1);
            this.usShowAviable1.Name = "usShowAviable1";
            this.usShowAviable1.Size = new System.Drawing.Size(793, 467);
            this.usShowAviable1.TabIndex = 15;
            // 
            // ucRemoveCar1
            // 
            this.ucRemoveCar1.Location = new System.Drawing.Point(0, 0);
            this.ucRemoveCar1.Name = "ucRemoveCar1";
            this.ucRemoveCar1.Size = new System.Drawing.Size(793, 467);
            this.ucRemoveCar1.TabIndex = 14;
            // 
            // ucAddCar1
            // 
            this.ucAddCar1.Location = new System.Drawing.Point(0, 0);
            this.ucAddCar1.Name = "ucAddCar1";
            this.ucAddCar1.Size = new System.Drawing.Size(793, 467);
            this.ucAddCar1.TabIndex = 13;
            // 
            // ucPostBill1
            // 
            this.ucPostBill1.Location = new System.Drawing.Point(0, -1);
            this.ucPostBill1.Name = "ucPostBill1";
            this.ucPostBill1.Size = new System.Drawing.Size(793, 467);
            this.ucPostBill1.TabIndex = 11;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.InitialImage = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(530, 15);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(35, 29);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 10;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(216, 15);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(308, 29);
            this.search.TabIndex = 9;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Cancel Order";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.SeaGreen;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 70D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(415, 424);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(181, 35);
            this.bunifuFlatButton2.TabIndex = 8;
            this.bunifuFlatButton2.Text = "Cancel Order";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Confirme Order";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(216, 424);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(181, 35);
            this.bunifuFlatButton1.TabIndex = 8;
            this.bunifuFlatButton1.Text = "Confirme Order";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // reservegrid
            // 
            this.reservegrid.AllowUserToAddRows = false;
            this.reservegrid.AllowUserToOrderColumns = true;
            this.reservegrid.AllowUserToResizeColumns = false;
            this.reservegrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.reservegrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.reservegrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reservegrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.reservegrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reservegrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reservegrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.reservegrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservegrid.DoubleBuffered = true;
            this.reservegrid.EnableHeadersVisualStyles = false;
            this.reservegrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reservegrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.reservegrid.HeaderForeColor = System.Drawing.Color.Black;
            this.reservegrid.Location = new System.Drawing.Point(19, 50);
            this.reservegrid.Name = "reservegrid";
            this.reservegrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.reservegrid.Size = new System.Drawing.Size(762, 368);
            this.reservegrid.TabIndex = 7;
            this.reservegrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reservegrid_CellContentClick);
            // 
            // GestionnaireMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(997, 518);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionnaireMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionnaireMainForm";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservegrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button managerhome;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button showaviablecars;
        private System.Windows.Forms.Button carmanagement;
        private System.Windows.Forms.Button postingbill;
        private System.Windows.Forms.Button addcar;
        public Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Button button1;
        public Bunifu.Framework.UI.BunifuCustomDataGrid reservegrid;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private MetroFramework.Controls.MetroTextBox search;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private UCPostBill ucPostBill1;
        private UCRemoveCar ucRemoveCar1;
        private UCAddCar ucAddCar1;
        private USShowAviable usShowAviable1;
        //private UCRemoveCar ucRemoveCar1;
    }
}