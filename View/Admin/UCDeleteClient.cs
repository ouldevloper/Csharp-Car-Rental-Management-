using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GestionDeLocationVoiture.Control.Classes;
using GestionDeLocationVoiture.Control.Interfaces;
namespace GestionDeLocationVoiture.View.Admin
{
    public partial class UCDeleteClient : UserControl
    {
        private IAdminControler admin;
        private Ihelper help = new Helper();
        public UCDeleteClient()
        {
            InitializeComponent();
            admin = new AdminControler();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
           
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UCDeleteClient_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click_1(object sender, EventArgs e)
        {
            reset();
        }

        private void search_Click(object sender, EventArgs e)
        {
            
            


        }
        private void reset()
        {
            cin.Clear();
            fullname.Clear();
            address.Clear();
            email.Clear();
            phone.Clear();
            id.Clear();
            datenassance.Clear();
            img.Image = null;
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cin.Text))
            {
                if (MessageBox.Show("Really You Want to Remve This Client ?") == DialogResult.OK)
                {
                    try
                    {
                        string x=id.Text;
                        admin.RemoveClient(x);
                        if(admin.searchClien(x).Rows.Count==0)
                            MessageBox.Show("Deleted with Success");
                        else
                            MessageBox.Show("Failed To Delete this Client");
                        reset();
                    }
                    catch
                    {
                        MessageBox.Show("Can not Delete This Client");
                    }
                }
            }
            else
            {
                MessageBox.Show("There Is no Client To Delete ");
            }
            reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id.Text)) return;
            DataTable dt = admin.searchClien(id.Text);
            reset();
            if (dt.Rows.Count > 0)
            {
                cin.Text = dt.Rows[0]["cin"].ToString();
                fullname.Text = dt.Rows[0]["fullname"].ToString();
                email.Text = dt.Rows[0]["email"].ToString();
                phone.Text = dt.Rows[0]["phone"].ToString();
                address.Text = dt.Rows[0]["address"].ToString();
                datenassance.Text = dt.Rows[0]["datenaissance"].ToString();
                img.Image = help.ConvertBytesToImage((byte[])dt.Rows[0]["image"]);
            }
            else
            {
                MessageBox.Show("Can Not Find Any Client ");
            }
        }

        private void id_Click(object sender, EventArgs e)
        {

        }
    }
}
