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
    public partial class UCSearchCarByClient : UserControl
    {
        private IClientControler c;
        public UCSearchCarByClient()
        {
            InitializeComponent();
            c = new ClientControler();
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c.searchCar(bunifuTextbox1.text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.CurrentRow.Cells["aviable"].Value.ToString().Equals("yes"))
                c.MakeOrder(dataGridView1.CurrentRow.Cells["matricule"].Value.ToString());
            else
                MessageBox.Show("selected car are not aviable in this moment");
        }
    }
}
