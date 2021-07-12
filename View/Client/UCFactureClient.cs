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
namespace GestionDeLocationVoiture.View.Client
{
    public partial class UCFactureClient : UserControl
    {
        private IClientControler c;
        public UCFactureClient()
        {
            InitializeComponent();
            c = new ClientControler();
            billgrid.DataSource = c.ShowFacture();
            float ttl = 0;
            foreach (Details item in c.ShowFacture())
            {
                ttl += item.Count;
            }
            total.Text = ttl.ToString();
        }

        private void dataRepeater1_CurrentItemIndexChanged(object sender, EventArgs e)
        {

        }

        private void UCFactureClient_Load(object sender, EventArgs e)
        {
            
           
               

        }

        private void billgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                
           
        }
    }
}
