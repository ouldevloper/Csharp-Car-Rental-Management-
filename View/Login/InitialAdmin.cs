using GestionDeLocationVoiture.Control.Classes;
using GestionDeLocationVoiture.Control.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouchlessLib;
using System.Threading;
using OlDeveloper.SecurityAndNetworking;
namespace GestionDeLocationVoiture.View.Login
{
    public partial class InitialAdmin : Form
    {
        TouchlessLib.TouchlessMgr photo;
        IUser u;
        InputValidation input = new InputValidation();
        public InitialAdmin()
        {
            u = new user();
            u.FillDataset();
            photo = new TouchlessMgr();
            InitializeComponent();
            
        }

        private void cin_Click(object sender, EventArgs e)
        {

        }

        private void log_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cin.Text) &&
                input.isName(fullname.Text) &&
                input.isAddress(address.Text) &&
                input.isEmail(email.Text) &&
                input.isPhone(phone.Text) &&
                input.isStrongPassword(password.Text) &&
                password.Text.Equals(password2.Text) &&
                DateTime.Today.Subtract(dateNaissance.Value).Days >= 365 &&
                image.Image != null)
            {


                user uu = new user(cin.Text, fullname.Text, address.Text, email.Text, phone.Text, Convert.ToDateTime(dateNaissance.Value.ToShortDateString()), image.Image, password.Text, Convert.ToDateTime(DateTime.Today.ToShortDateString()), "admin");
                u.InitialAdmin(uu);
                MessageBox.Show("Admin Maked with success");
                Application.Restart();
                u.UpdateDb();
            }
            else
            {
                MessageBox.Show("Invalid Data");
            }
        }
        private void reset_Click(object sender, EventArgs e)
        {
            rest();
        }
        public void rest()
        {
            cin.Clear();
            fullname.Clear();
            address.Clear();
            email.Clear();
            phone.Clear();
            dateNaissance.Value = DateTime.Today;
            image.Image = null;
            password.Clear();
            password2.Clear();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void upload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog op = new OpenFileDialog())
            {
                if (op.ShowDialog() == DialogResult.OK)
                    image.Image = Image.FromFile(op.FileName);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            photo.CurrentCamera=photo.Cameras[0];
            image.Image = photo.CurrentCamera.GetCurrentImage();
        }

        private void flatClose1_Click(object sender, EventArgs e)
        {

        }
    }
}
