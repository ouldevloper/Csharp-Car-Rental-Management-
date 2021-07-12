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
    
    public partial class UCShowCarByClient : UserControl
    {
        private IClientControler c;
        private Helper help = new Helper();
        public UCShowCarByClient()
        {
            InitializeComponent();
            c = new ClientControler();
            reset();
        }
        private void reset()
        {
            search.Text = "";
            matric.Text = "";
            pic.Image = null;
            desc.Text = "";
            order.Visible = false;
            panel1.Visible = false;
            prc.Text = "";

        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            DataRow dv = c.ShowCar(search.Text);
            if (dv == null)
            {
                reset();
                dv = null;
            }
            if (dv!=null)
            {
                panel1.Visible = true;
                matric.Text = dv[0].ToString();
                pic.Image = help.ConvertBytesToImage((byte[])dv["ImageCar"]);
                desc.Text = dv["description"].ToString();
                if (dv["aviable"].ToString().ToLower().Equals("yes"))
                {
                    prc.Text = dv["price"].ToString()+" DH";
                    order.Visible = true;
                }
                else
                {
                    prc.Text = "Not Aviable In This Moment";
                    order.Visible = false;
                }
                dv = null;
            }
            
        }

        private void order_Click(object sender, EventArgs e)
        {
            c.MakeOrder(search.Text);
            reset();
        }
    }
}
