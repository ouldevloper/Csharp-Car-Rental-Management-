using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GestionDeLocationVoiture.Control.Classes;
using GestionDeLocationVoiture.Control.Interfaces;

namespace GestionDeLocationVoiture.View.Client
{
    public partial class ClientMainForms : Form
    {
        private IClientControler clientObject;
        Helper help = new Helper();
        public ClientMainForms()
        {
            clientObject = new ClientControler();
            clientObject.FillDataSet();
            InitializeComponent();
            ucNotificationClient1.Visible = false;
            ucSearchCarByClient1.Visible = false;
            ucFactureClient1.Visible = false;
            ucSettingForClient2.Visible = false;
            ucShowCarByClient1.Visible = false;
            
            ShowInformation();
        }
        public void ShowInformation()
        {
            DataTable dt = clientObject.PromotionCars();
            if (dt.Rows.Count > 0)
            {
                DataRow dv = clientObject.ShowCar(dt.Rows[0]["Matricule"].ToString());
                if (!dv["aviable"].Equals("yes"))
                    order1.Visible = false;
                name1.Text = dt.Rows[0]["title"].ToString();
                desc1.Text = dt.Rows[0]["description"].ToString();
                matricule1.Text = dt.Rows[0]["Matricule"].ToString();
                pic1.Image = help.ConvertBytesToImage((byte[])dv["imagecar"]);
                pric1.Text = "-"+dt.Rows[0]["reduction"].ToString() + " %";
            }
            else
            {
                pan1.Visible = false;
                order1.Visible = false;
            }
            if (dt.Rows.Count > 1)
            {
                DataRow dv1 = clientObject.ShowCar(dt.Rows[1]["Matricule"].ToString());
                if (!dv1["aviable"].Equals("yes"))
                    order1.Visible = false;
                name2.Text = dt.Rows[1]["title"].ToString();
                desc2.Text = dt.Rows[1]["description"].ToString();
                matricule2.Text = dt.Rows[1]["Matricule"].ToString();
                pic2.Image = help.ConvertBytesToImage((byte[])dv1["imagecar"]);
                pric2.Text = "-" + dt.Rows[1]["reduction"].ToString() + " %";
            }
            else
            {
                pan2.Visible = false;
                order2.Visible = false;
            }
            if (dt.Rows.Count > 2)
            {
                DataRow dv2 = clientObject.ShowCar(dt.Rows[2]["Matricule"].ToString());
                if (!dv2["aviable"].Equals("yes"))
                    order3.Visible = false;
                name3.Text = dt.Rows[2]["title"].ToString();
                desc3.Text = dt.Rows[2]["description"].ToString();
                matricule3.Text = dt.Rows[2]["Matricule"].ToString();
                pic3.Image = help.ConvertBytesToImage((byte[])dv2["imagecar"]);
                pric3.Text = "-" + dt.Rows[2]["reduction"].ToString() + " %";
            }
            else
            {
                pan3.Visible = false;
                order3.Visible = false;
            }
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bar.Top = search.Top;
            ucSearchCarByClient1.Visible = true;
            ucFactureClient1.Visible = false;
            ucSettingForClient2.Visible = false;
            ucShowCarByClient1.Visible = false;
            
        }

        private void rectangleShape1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            clientObject.updateDataBase();
            Application.Exit();
        }

        private void home_Click(object sender, EventArgs e)
        {
            bar.Top = home.Top;
            ucSearchCarByClient1.Visible = false;
            ucFactureClient1.Visible = false;
            ucSettingForClient2.Visible = false;
            ucShowCarByClient1.Visible = false;
        }

        private void showcar_Click(object sender, EventArgs e)
        {
            bar.Top = showcar.Top;
            ucSearchCarByClient1.Visible = false;
            ucFactureClient1.Visible = false;
            ucSettingForClient2.Visible = false;
            ucShowCarByClient1.Visible = true;
            
        }

        private void showbill_Click(object sender, EventArgs e)
        {
            bar.Top = showbill.Top;
            ucSearchCarByClient1.Visible = false;
            ucFactureClient1.Visible = true;
            ucSettingForClient2.Visible = false;
            ucShowCarByClient1.Visible = false;
            
        }

        private void settings_Click(object sender, EventArgs e)
        {
            bar.Top = settings.Top;
            ucSearchCarByClient1.Visible = false;
            ucFactureClient1.Visible = false;
            ucSettingForClient2.Visible = true;
            ucShowCarByClient1.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ucNotificationClient1.Visible == true)
            {
                ucNotificationClient1.Visible = false;
            }
            else
            {
                ucNotificationClient1.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            clientObject.updateDataBase();
            this.Hide();
            GestionDeLocationVoiture.Login l = new GestionDeLocationVoiture.Login();
            l.Show();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            clientObject.MakeOrder(matricule1.Text);
            ShowInformation();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            clientObject.MakeOrder(matricule2.Text);
            ShowInformation();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            clientObject.MakeOrder(matricule3.Text);
            ShowInformation();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClientMainForms_Load(object sender, EventArgs e)
        {

        }

        private void bar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void ClientName_Click(object sender, EventArgs e)
        {

        }

       

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void matricule3_Click(object sender, EventArgs e)
        {

        }
        

        private void desc3_Click(object sender, EventArgs e)
        {

        }

        private void pric3_Click(object sender, EventArgs e)
        {

        }

        private void pic3_Click(object sender, EventArgs e)
        {

        }

        private void name3_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void matricule2_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void desc2_Click(object sender, EventArgs e)
        {

        }

        private void pric2_Click(object sender, EventArgs e)
        {

        }

        private void pic2_Click(object sender, EventArgs e)
        {

        }

        private void name2_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void matricule1_Click(object sender, EventArgs e)
        {

        }

        
        private void desc1_Click(object sender, EventArgs e)
        {

        }

        private void pric1_Click(object sender, EventArgs e)
        {

        }

        private void pic1_Click(object sender, EventArgs e)
        {

        }

        private void name1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ucShowCarByClient1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
