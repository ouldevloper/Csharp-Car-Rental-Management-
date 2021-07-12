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
    public partial class UCAddCar : UserControl
    {
        IGestionnaireControler m;
        public UCAddCar()
        {
            InitializeComponent();
            m = new GestionnaireControler();
        }
        
        void Reset() 
        {
            matricule.Clear();
            name.Clear();
            model.Clear();
            price.Clear();
            color.Text = string.Empty;
            description.Clear();
            pic.Image = null;
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            
            if (m.ExistCar(matricule.Text))
            {
                MessageBox.Show("this car already exist check the system \nor contact the administrator for more information about it");
                return;
            }
            if (string.IsNullOrEmpty(matricule.Text)                ||
                string.IsNullOrEmpty(name.Text)                     ||
                string.IsNullOrEmpty(model.Text)                    ||
                string.IsNullOrEmpty(color.SelectedItem.ToString()) ||
                string.IsNullOrEmpty(price.Text)                    ||
                string.IsNullOrEmpty(description.Text)              ||
                pic.Image == null
                )
            {
                MessageBox.Show("Data does not valid");
                return;
            }
            Cars cc = new GestionDeLocationVoiture.Control.Classes.Cars(matricule.Text,
                              name.Text,
                              model.Text,
                              color.Text,
                              float.Parse(price.Text),
                              description.Text,
                              "yes",
                              pic.Image);
            
            m.AddCar(cc);
            MessageBox.Show("Car added to system with success");
            Reset();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog op = new OpenFileDialog())
            {
                if(op.ShowDialog()==DialogResult.OK)
                {
                    pic.Image = Image.FromFile(op.FileName);
                }
            }
        }

        private void matricule_Click(object sender, EventArgs e)
        {

        }
    }
}
