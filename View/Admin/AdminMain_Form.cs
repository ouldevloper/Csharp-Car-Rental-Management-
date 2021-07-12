using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionDeLocationVoiture.Control.Classes;
using GestionDeLocationVoiture.Control.Interfaces; 
namespace GestionDeLocationVoiture.View.Admin
{
    public partial class AdminMain_Form : Form
    {
        Ihelper help;
        IAdminControler admin;
        public AdminMain_Form()
        {
            InitializeComponent();
            help = new Helper();
            admin = new AdminControler();
            admin.FillDataSet();
            log.DataSource=AdminControler.Admindataset.Tables["logs"];
            admin.DeleteExpirationPromotion();
            ucDeleteClient1.Visible = false;
            ucAdd_Managers2.Visible = false;
            ucPushPromotion1.Visible = false;
        }

        private void rectangleShape1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin.UpdateDb();
            Application.Exit();
        }

        private void adminpromotion_Click(object sender, EventArgs e)
        {
            baradmin.Top = adminpromotion.Top;
            ucDeleteClient1.Visible = false;
            ucAdd_Managers2.Visible = false;
            ucPushPromotion1.Visible = true;
        }

        private void Adminhome_Click(object sender, EventArgs e)
        {
            baradmin.Top = Adminhome.Top;
            ucDeleteClient1.Visible = false;
            ucAdd_Managers2.Visible = false;
            ucPushPromotion1.Visible = false;
        }

        private void adminaddmanager_Click(object sender, EventArgs e)
        {
            baradmin.Top = adminaddmanager.Top;
            ucDeleteClient1.Visible = false;
            ucAdd_Managers2.Visible = true;
            ucPushPromotion1.Visible = false;
        }

        private void admindeleteclient_Click(object sender, EventArgs e)
        {
            baradmin.Top = admindeleteclient.Top;
            ucDeleteClient1.Visible = true;
            ucAdd_Managers2.Visible = false;
            ucPushPromotion1.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucPushPromotion1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin.UpdateDb();
            this.Hide();
            GestionDeLocationVoiture.Login l = new GestionDeLocationVoiture.Login();
            l.Show();
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            admin.ClearLogs();
            log.DataSource=AdminControler.Admindataset.Tables["logs"];
        }
    }
}
