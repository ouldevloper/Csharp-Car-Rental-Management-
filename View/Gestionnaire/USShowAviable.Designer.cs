namespace GestionDeLocationVoiture.View.Gestionnaire
{
    partial class USShowAviable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USShowAviable));
            this.aviable = new System.Windows.Forms.Label();
            this.matric = new Bunifu.Framework.UI.BunifuTextbox();
            this.btnsearch = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // aviable
            // 
            this.aviable.AutoSize = true;
            this.aviable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aviable.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aviable.Location = new System.Drawing.Point(76, 257);
            this.aviable.Name = "aviable";
            this.aviable.Size = new System.Drawing.Size(0, 61);
            this.aviable.TabIndex = 1;
            // 
            // matric
            // 
            this.matric.BackColor = System.Drawing.SystemColors.Control;
            this.matric.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("matric.BackgroundImage")));
            this.matric.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.matric.ForeColor = System.Drawing.Color.SeaGreen;
            this.matric.Icon = ((System.Drawing.Image)(resources.GetObject("matric.Icon")));
            this.matric.Location = new System.Drawing.Point(145, 99);
            this.matric.Name = "matric";
            this.matric.Size = new System.Drawing.Size(371, 42);
            this.matric.TabIndex = 4;
            this.matric.text = "";
            this.matric.OnTextChange += new System.EventHandler(this.bunifuTextbox1_OnTextChange);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.SeaGreen;
            this.btnsearch.color = System.Drawing.Color.SeaGreen;
            this.btnsearch.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Image = global::GestionDeLocationVoiture.Properties.Resources.Search;
            this.btnsearch.ImagePosition = 10;
            this.btnsearch.ImageZoom = 50;
            this.btnsearch.LabelPosition = 0;
            this.btnsearch.LabelText = "";
            this.btnsearch.Location = new System.Drawing.Point(525, 99);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(50, 42);
            this.btnsearch.TabIndex = 6;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // USShowAviable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.matric);
            this.Controls.Add(this.aviable);
            this.Name = "USShowAviable";
            this.Size = new System.Drawing.Size(793, 467);
            this.Load += new System.EventHandler(this.USShowAviable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aviable;
        private Bunifu.Framework.UI.BunifuTextbox matric;
        private Bunifu.Framework.UI.BunifuTileButton btnsearch;
    }
}
