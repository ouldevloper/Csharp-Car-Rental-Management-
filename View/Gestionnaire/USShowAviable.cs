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
    public partial class USShowAviable : UserControl
    {
        private IGestionnaireControler g;
        public USShowAviable()
        {
            InitializeComponent();
            g = new GestionnaireControler();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void USShowAviable_Load(object sender, EventArgs e)
        {
         
        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (matric.text != string.Empty)
                aviable.Text = g.showCarIfAviable(matric.text);
            else
                MessageBox.Show("there is no car");
        }
    }
}
