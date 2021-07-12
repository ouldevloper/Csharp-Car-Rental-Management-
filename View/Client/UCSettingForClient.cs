using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OlDeveloper.SecurityAndNetworking;
using GestionDeLocationVoiture.Control.Classes;
using GestionDeLocationVoiture.Control.Interfaces;
using TouchlessLib;
using System.IO;
namespace GestionDeLocationVoiture.View.Client
{
    public partial class UCSettingForClient : UserControl
    {
        private InputValidation input;
        private user u;
        private Helper h = new Helper();
        private IClientControler c;
        
        public UCSettingForClient()
        {
            InitializeComponent();
            input = new InputValidation();
            c = new ClientControler();
            dateNaissance.Value = DateTime.Today.AddYears(-18);
            if (user.usertable.Rows.Count > 0)
            {
                cin.Enabled = false;
                cin.Text = user.usertable.Rows[0][0].ToString();
                fullname.Text = user.usertable.Rows[0][1].ToString();
                address.Text = user.usertable.Rows[0][2].ToString();
                email.Text = user.usertable.Rows[0][3].ToString();
                phone.Text = user.usertable.Rows[0][4].ToString();
                dateNaissance.Value = Convert.ToDateTime(user.usertable.Rows[0][5].ToString());
                image.Image = h.ConvertBytesToImage((byte[]) user.usertable.Rows[0][6]);
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            reset1();
        }
        private void save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cin.Text) && cin.Text.Equals(user.usertable.Rows[0][0].ToString()))
            {
                if (input.isName(fullname.Text) &&
                    input.isEmail(email.Text) &&
                    input.isPhone(phone.Text) &&
                    input.isAddress(address.Text) &&
                    DateTime.Now.Year - dateNaissance.Value.Year >= 18 &&
                    image.Image != null &&
                    input.isStrongPassword(password.Text) &&
                    input.isStrongPassword(password2.Text))
                {
                    u = new user(user.usertable.Rows[0]["cin"].ToString(),
                             fullname.Text,
                             address.Text,
                             email.Text,
                             phone.Text,
                             dateNaissance.Value,
                             image.Image,
                             password2.Text,
                             DateTime.Today,
                            "'client'");
                    c.UpdateProfile(u);
                    MessageBox.Show("Saved Successfully");
                    reset1();
                }
            }
            else
            {
                MessageBox.Show("Try to update just your profile ... ");
            }
        }
        private void reset1()
        {
            fullname.Clear();
             address.Clear();
            email.Clear();
            phone.Clear();
            dateNaissance.Value=DateTime.Today;
            image.Image=null;
            password.Clear();
            password2.Clear();
        }
        private void upload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog op = new OpenFileDialog())
            {
                if (op.ShowDialog() == DialogResult.OK)
                {
                    image.Image = Image.FromFile(op.FileName);
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }
    }
}
