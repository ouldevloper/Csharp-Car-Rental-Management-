using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionDeLocationVoiture.View.Login;
using GestionDeLocationVoiture.Control.Interfaces;
using GestionDeLocationVoiture.Control.Classes;
namespace GestionDeLocationVoiture
{
    public partial class Login : Form
    {
        IUser u;
        public Login()
        {
            u = new user();
            u.FillDataset();

                if (!u.IsExist())
                {
                    Application.Run(new InitialAdmin());

                }
                else
                {
                    InitializeComponent();
                    ucSignup2.Visible = false;
                }
            //}
            
        }

        private void formSkin1_Click(object sender, EventArgs e)
        {
        }

        private void signup_Click(object sender, EventArgs e)
        {
            bar.Left = signup.Left;
            ucSignup2.Visible = true;
        }

        private void Signin_Click(object sender, EventArgs e)
        {
            bar.Left = Signin.Left;
            ucSignup2.Visible = false;
        }

        private void id_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            u.UpdateDb();
            Application.Exit();
        }

        private void loginreset_Click(object sender, EventArgs e)
        {
            resit();
        }
        private void resit()
        {
            id.Clear();
            pwd.Clear();
        }
        private void daten_Load(object sender, EventArgs e)
        {
           
        }

        private void ucSignup1_Load(object sender, EventArgs e)
        {
        }

        private void log_Click(object sender, EventArgs e)
        {
            if (id.Text != "" && pwd.Text != "")
            {
                if (u.GeneratForm(id.Text, pwd.Text))
                {
                    if (!remamber.Checked)
                    {
                        resit();
                        this.Hide();
                    }
                    else
                        this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Incorrect Data");
            }
            
        }

        private void ucSignup1_Load_1(object sender, EventArgs e)
        {

        }

        private void panlog_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucSignup2_Load(object sender, EventArgs e)
        {

        }

        private void flatClose1_Click(object sender, EventArgs e)
        {
            u.UpdateDb();
        }
    }
}
