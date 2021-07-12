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
    public partial class UCRemoveCar : UserControl
    {
        private IGestionnaireControler g;
        Helper h = new Helper();
        public UCRemoveCar()
        {
            InitializeComponent();
            g = new GestionnaireControler();
            
        }

        private void UCRemoveCar_Load(object sender, EventArgs e)
        {
            
        }

        private void matricule_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void reset()
        {
            matricule.Clear();
            name.Clear();
            model.Clear();
            color.Clear();
            description.Clear();
            image.Image = null;
        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (matricule.Text != string.Empty)
            {
                if (name.Text != string.Empty &&
                    model.Text != string.Empty &&
                    color.Text != string.Empty &&
                    description.Text != string.Empty &&
                    image.Image != null)
                {
                    g.deleteCare(matricule.Text);
                    MessageBox.Show("Car Removed With Success");
                    reset();
                }
                else
                {
                    MessageBox.Show("There is no car to remove");
                }
            }
            else
                MessageBox.Show("there is no car had a blanck code in the world bb");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (matricule.Text != string.Empty)
            {
                DataRow dv = g.SearchCar(matricule.Text);
                if (dv != null)
                {
                    name.Text = dv[1].ToString();
                    model.Text = dv[2].ToString();
                    color.Text = dv[3].ToString();
                    description.Text = dv[5].ToString();
                    image.Image = h.ConvertBytesToImage((byte[])dv[7]);
                }
                else
                {
                    MessageBox.Show("There is not a car that have those information or it removed");
                }
            }
            else
                MessageBox.Show("There is no car had a blanck code in the world");
        }

        private void matricule_Click(object sender, EventArgs e)
        {
            
        }
    }
}
