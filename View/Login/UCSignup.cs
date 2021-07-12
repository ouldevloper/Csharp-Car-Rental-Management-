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
using OlDeveloper.SecurityAndNetworking;
using TouchlessLib;
namespace GestionDeLocationVoiture.View.Login
{
    public partial class UCSignup : UserControl
    {
        private TouchlessMgr Takephoto;
        private IUser usr;
        private IClientControler client;
        private InputValidation inpt=new InputValidation();
        public UCSignup()
        {
            InitializeComponent();
            client = new ClientControler();
            usr = new user();
            dateNaissance.Format = DateTimePickerFormat.Short;
            dateNaissance.Value = DateTime.Today;
            try
            {
                Takephoto = new TouchlessMgr();
            }
            catch { }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!client.ExistedClient(cin.Text))
            {
                if (password.Text == password2.Text &&
                    DateTime.Today.Year - dateNaissance.Value.Year > 17 &&
                    image.Image != null &&
                    !string.IsNullOrEmpty(cin.Text) &&
                    inpt.isName(fullname.Text) &&
                    inpt.isAddress(address.Text) &&
                    inpt.isPhone(phone.Text) &&
                    inpt.isEmail(email.Text)&&
                    inpt.isStrongPassword(password.Text))
                {
                    user u = new user(cin.Text, fullname.Text, address.Text, email.Text,
                                phone.Text, dateNaissance.Value,
                                image.Image, password.Text,
                                Convert.ToDateTime(DateTime.Today.ToShortDateString()), "client");
                    usr.SignUp(u);
                    MessageBox.Show("Signed Up with Successe");
                    res();
                }
                else
                {
                    MessageBox.Show("Incorrect data");
                }
            }
            else
            {
                MessageBox.Show("This Client Already Exist Plais Sign In Or Contact Administrator To Get The Password");
            }
        }

        private void UCSignup_Load(object sender, EventArgs e)
        {
            
        }

        private void dateNaissance_onValueChanged(object sender, EventArgs e)
        {
            
        }
        private void res()
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

        private void reset_Click(object sender, EventArgs e)
        {
            res();
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
                {
                    image.Image = Image.FromFile(op.FileName);
                }
            }
        }

        private  void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
            if(Takephoto.Cameras.Count>0){
                
                    Takephoto.CurrentCamera = Takephoto.Cameras.ElementAt(0);
                    image.Image = Takephoto.CurrentCamera.GetCurrentImage();
                
            }
        }
    }
}
