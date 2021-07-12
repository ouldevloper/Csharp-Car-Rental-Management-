using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionDeLocationVoiture.Control.Classes;
using GestionDeLocationVoiture.Control.Interfaces;
namespace GestionDeLocationVoiture.View.Gestionnaire
{
    public partial class UCPostBill : UserControl
    {
        private IGestionnaireControler manager;
        public UCPostBill()
        {
            InitializeComponent();
            manager = new GestionnaireControler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void id_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                facture f = new facture();
                factureDetails fd = new factureDetails();
                List<factureDetails> l = new List<factureDetails>();
                f._idfacture = manager.getLatsIdBill();
                f._cin = id.Text;
                f._dt = DateTime.Now;
                foreach (DataGridViewRow item in dt.Rows)
                {
                    fd._idfacture = f._idfacture;
                    fd._matricule = item.Cells[1].Value.ToString();
                    fd.nbday = int.Parse(item.Cells[4].Value.ToString());
                    fd.price = float.Parse(item.Cells[5].Value.ToString());
                    l.Add(fd);
                }
                f._details = l;
                manager.AddFacture(f);
                dt.DataSource = null;
            }
            else
                MessageBox.Show("there is no bill to add");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (id.Text != string.Empty)
            {
                dt.DataSource = manager.ShowClientFacture(id.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            id.Clear();
            dt.DataSource=null;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
