using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using OlDeveloper.SecurityAndNetworking;
using System.Threading.Tasks;
using System.Windows.Forms;
using TouchlessLib;
using GestionDeLocationVoiture.Control.Classes;
using GestionDeLocationVoiture.Control.Interfaces;
using System.IO;
namespace GestionDeLocationVoiture.View.Admin
{
    public partial class UCAdd_Managers : UserControl
    {
        private TouchlessMgr takephoto;
        private InputValidation valid;
        private IAdminControler admin;
        private user u;
        public UCAdd_Managers()
        {
            InitializeComponent();
            admin = new AdminControler();
            valid = new InputValidation();
            ManagerDateN.Value = Convert.ToDateTime(DateTime.Today.AddYears(-18).ToShortDateString());
            try
            {
                takephoto = new TouchlessMgr();
            }
            catch { }
        }

        private void Managerreset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            Managercin.Clear();
            ManagerFullName.Clear();
            ManagerAddress.Clear();
            ManagerEmail.Clear();
            ManagerPhone.Clear();
            ManagerPassword.Clear();
            ManagerPassword2.Clear();
            ManagerDateN.Value=Convert.ToDateTime(DateTime.Today.AddYears(-18).ToShortDateString());
            ManagerImage.Image = null;
            permission.SelectedText = "";
        }

        private void UCAdd_Managers_Load(object sender, EventArgs e)
        {

        }

        private void ManagerAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (valid.isEmail(ManagerEmail.Text) &&
                    valid.isPhone(ManagerPhone.Text) &&
                    valid.isAddress(ManagerAddress.Text) &&
                    valid.isStrongPassword(ManagerPassword.Text) &&
                    valid.isName(ManagerFullName.Text)&&
                    DateTime.Today.Year - Convert.ToDateTime(ManagerDateN.Value.ToShortDateString()).Year > 17 &&
                    ManagerImage.Image != null&&
                    permission.Text!=string.Empty)
                    {
                        u= new user(Managercin.Text,
                                ManagerFullName.Text,
                                ManagerAddress.Text,
                                ManagerEmail.Text,
                                ManagerPhone.Text,
                                Convert.ToDateTime(ManagerDateN.Value.ToShortDateString()),
                                ManagerImage.Image,
                                ManagerPassword.Text,
                                Convert.ToDateTime(DateTime.Today.ToShortDateString()),
                                permission.Text);
                        u.SignUp(u);
                        MessageBox.Show("Manager Added Successfully");
                        Reset();
                   
                }
                else
                {
                    MessageBox.Show("Data Is Not Valide");
                }
            }
            catch
            {
                MessageBox.Show("Failed to Add Manager Try Again");
            }

        }

        private void Managercancel_Click(object sender, EventArgs e)
        {
        }

        private void Managerupload_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog op=new OpenFileDialog())
            {
                if (op.ShowDialog() == DialogResult.OK)
                {
                    ManagerImage.Image = Image.FromFile(op.FileName);
                }
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

            if (takephoto.Cameras.Count > 0)
            {
                takephoto.CurrentCamera = takephoto.Cameras[0];
                ManagerImage.Image = takephoto.CurrentCamera.GetCurrentImage();
                //ManagerImage.Image.Save(Application.UserAppDataPath + @"\..\..\..\temp\manager.png");
            }
        }
    }
}
