namespace GestionDeLocationVoiture.View.Client
{
    partial class UCFactureClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.billgrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.total = new System.Windows.Forms.TextBox();
            this.yy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.billgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // billgrid
            // 
            this.billgrid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.billgrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.billgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billgrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.billgrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.billgrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.billgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.billgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billgrid.DoubleBuffered = true;
            this.billgrid.EnableHeadersVisualStyles = false;
            this.billgrid.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.billgrid.HeaderForeColor = System.Drawing.Color.Black;
            this.billgrid.Location = new System.Drawing.Point(21, 18);
            this.billgrid.Name = "billgrid";
            this.billgrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.billgrid.Size = new System.Drawing.Size(740, 418);
            this.billgrid.TabIndex = 0;
            this.billgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billgrid_CellContentClick);
            // 
            // total
            // 
            this.total.Enabled = false;
            this.total.Location = new System.Drawing.Point(567, 442);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(194, 20);
            this.total.TabIndex = 6;
            // 
            // yy
            // 
            this.yy.AutoSize = true;
            this.yy.Location = new System.Drawing.Point(505, 445);
            this.yy.Name = "yy";
            this.yy.Size = new System.Drawing.Size(45, 13);
            this.yy.TabIndex = 3;
            this.yy.Text = "TOTAL ";
            // 
            // UCFactureClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.total);
            this.Controls.Add(this.yy);
            this.Controls.Add(this.billgrid);
            this.Name = "UCFactureClient";
            this.Size = new System.Drawing.Size(794, 470);
            this.Load += new System.EventHandler(this.UCFactureClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid billgrid;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label yy;

    }
}
