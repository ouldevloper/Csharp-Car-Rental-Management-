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
    public partial class UCNotificationClient : UserControl
    {
        private IClientControler c ;
        public UCNotificationClient()
        {
            InitializeComponent();
            c = new ClientControler();
            c.LoadNotifications(listView1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void notification_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
