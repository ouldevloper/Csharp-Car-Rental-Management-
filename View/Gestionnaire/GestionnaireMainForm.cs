using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionDeLocationVoiture.Control.Interfaces;
using GestionDeLocationVoiture.Control.Classes;
namespace GestionDeLocationVoiture.View.Gestionnaire
{
    public partial class GestionnaireMainForm : Form
    {
        IGestionnaireControler manager;
        public GestionnaireMainForm()
        {
            InitializeComponent();
            manager =new  GestionnaireControler();
            manager.FillDataSet();
            reservegrid.DataSource = GestionnaireControler.managerdataset.Tables["ReservedCars"];
            
            ucPostBill1.Visible = false;
            ucAddCar1.Visible = false;
            ucRemoveCar1.Visible = false;
            usShowAviable1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            manager.updateDataBase();
            Application.Exit();
            
        }

        private void addcar_Click(object sender, EventArgs e)
        {
            panel5.Top = addcar.Top;
            ucPostBill1.Visible = false;
            ucAddCar1.Visible = true;
            ucRemoveCar1.Visible = false;
            usShowAviable1.Visible = false;

        }

        private void managerhome_Click(object sender, EventArgs e)
        {
           panel5.Top = managerhome.Top;

           ucPostBill1.Visible = false;
           ucAddCar1.Visible = false;
           ucRemoveCar1.Visible = false;
           usShowAviable1.Visible = false;
           
        }

        private void postingbill_Click(object sender, EventArgs e)
        {
            panel5.Top = postingbill.Top;
            ucPostBill1.Visible = true;
            ucAddCar1.Visible = false;
            ucRemoveCar1.Visible = false;
            usShowAviable1.Visible = false;

        }

        private void showbill_Click(object sender, EventArgs e)
        {

        }

        private void carmanagement_Click(object sender, EventArgs e)
        {
            panel5.Top = carmanagement.Top;
            ucPostBill1.Visible = false;
            ucAddCar1.Visible = false;
            ucRemoveCar1.Visible = true;
            usShowAviable1.Visible = false;

        }

        private void showaviablecars_Click(object sender, EventArgs e)
        {
            panel5.Top = showaviablecars.Top;
            ucPostBill1.Visible = false;
            ucAddCar1.Visible = false;
            ucRemoveCar1.Visible = false;
            usShowAviable1.Visible = true;

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Contract con=new Contract();
            if (reservegrid.Rows.Count > 0)
            {
                con.cin = reservegrid.CurrentRow.Cells[0].Value.ToString();
                con.matricule = reservegrid.CurrentRow.Cells[1].Value.ToString();
                con.started = Convert.ToDateTime(reservegrid.CurrentRow.Cells[2].Value);
                con.nbday = int.Parse(reservegrid.CurrentRow.Cells[3].Value.ToString());
                manager.ConfirmeOrder(con);
                reservegrid.DataSource = GestionnaireControler.managerdataset.Tables["reservedCars"];
            }
            else
            {
                MessageBox.Show("There Is not Order To Confirme.");
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if(reservegrid.Rows.Count>0)
            {
                if(reservegrid.SelectedRows.Count>0)
                    manager.CancelOrder(reservegrid.CurrentRow.Cells[1].Value.ToString());
            }
            else
            {
                MessageBox.Show("There Is not Order To Cancel.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manager.updateDataBase();
            this.Hide();
            GestionDeLocationVoiture.Login l = new GestionDeLocationVoiture.Login();
            l.Show();
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            reservegrid.DataSource = GestionnaireControler.managerdataset.Tables["reservedCars"];
        }

        private void reservegrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            reservegrid.DataSource = GestionnaireControler.managerdataset.Tables["reservedCars"];
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(manager.searchForClienOrder("").Count.ToString());
            if (search.Text != string.Empty)
            {
                reservegrid.DataSource = manager.searchForClienOrder(search.Text);
            }
            else
            {
                reservegrid.DataSource = manager.searchForClienOrder("");
            }
        }

        private void ucPostBill1_Load(object sender, EventArgs e)
        {

        }

        private void ucPostBill1_Load_1(object sender, EventArgs e)
        {

        }

        private void ucPostBill1_Load_2(object sender, EventArgs e)
        {

        }

        private void usShowAviable1_Load(object sender, EventArgs e)
        {

        }
    }
}
