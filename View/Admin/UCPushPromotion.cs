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
using OlDeveloper.Data.SqlServer;
namespace GestionDeLocationVoiture.View.Admin
{
    public partial class UCPushPromotion : UserControl
    {
        private IAdminControler admin;
        public UCPushPromotion()
        {
            InitializeComponent();
            admin = new AdminControler();
            admin.FillCombobox(matriculepromotion, "cars");
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                if (admin.ExistMatricule(matriculepromotion.SelectedItem.ToString()))
                {
                    if (!string.IsNullOrEmpty(titlepromotion.Text) &&
                        !string.IsNullOrEmpty(matriculepromotion.SelectedItem.ToString()) &&
                        float.Parse(reductionpromotion.Text) >= 0 &&
                        float.Parse(reductionpromotion.Text) <= 100 &&
                        Convert.ToDateTime(endpromotion.Value.ToShortDateString()) > DateTime.Today &&
                        !string.IsNullOrEmpty(descriptionpromotion.Text))
                    {
                        Promotion p = new Promotion(titlepromotion.Text,
                                                    matriculepromotion.SelectedValue.ToString(),
                                                    float.Parse(reductionpromotion.Text),
                                                    Convert.ToDateTime(endpromotion.Value.ToShortDateString()),
                                                    descriptionpromotion.Text);
                        admin.pushPromotion(p);
                        MessageBox.Show("Promotion has been Added with successe");
                    }
                    else
                    {
                        MessageBox.Show("Some Information are Missing or incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("This Matricule Already Exist");
                }
            }catch
            {
                MessageBox.Show("Failed To Add Promotion");
            }
            reset();
        }
        private void reset()
        {
            titlepromotion.Clear();
            reductionpromotion.Clear();
            descriptionpromotion.Clear();
            matriculepromotion.Text = "";
            endpromotion.Value = Convert.ToDateTime(DateTime.Today.ToShortDateString()).AddDays(1) ;
        }
        private void UCPushPromotion_Load(object sender, EventArgs e)
        {
            endpromotion.Value = DateTime.Today;
        }
    }
}
