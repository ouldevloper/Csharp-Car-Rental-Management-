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
    public partial class cin : UserControl
    {
        IGestionnaireControler manager;
        public cin()
        {
            InitializeComponent();
            manager = new GestionnaireControler();
            grid.DataSource = manager.SearchCars("");
        }

        private void search_Click(object sender, EventArgs e)
        {
           
        }

        private void modelormatricule_OnTextChange(object sender, EventArgs e)
        {
            if (modelormatricule.text != string.Empty)
                grid.DataSource = manager.SearchCars(modelormatricule.text);
            else
                grid.DataSource = manager.showCars();
        }
    }
}
