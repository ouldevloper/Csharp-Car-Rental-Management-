using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OlDeveloper.Data.SqlServer;
using OlDeveloper.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using OlDeveloper.SecurityAndNetworking;
using GestionDeLocationVoiture.Control.Interfaces;
namespace GestionDeLocationVoiture.Control.Classes
{

    class ClientControler :IClientControler
    {
        string cin;
        static  DataRow row;
        public  static DataSet clientdataset = new DataSet();
        private static SqlServer dataconnectionMode = SqlServer.GetInstance(@"  server=.\OLDEVELOPER;
                                                                                database=LocationCar1;
                                                                                integrated security=true;");
        private static SqlServerDeconnectionMode datadeconnectionMode = SqlServerDeconnectionMode.GetInstance(@"server=.\OLDEVELOPER;
                                                                                                                database=LocationCar1;
                                                                                                                integrated security=true;");
       
        public  void UpdateProfile(user usr)
        {
            InputValidation input=new InputValidation();
           
            user.usertable.Rows[0][1] = usr._FullName;
            user.usertable.Rows[0][2] = usr._Address;
            user.usertable.Rows[0][3] = usr._Email;
            user.usertable.Rows[0][4] = usr._Phone;
            user.usertable.Rows[0][5] = usr._DateNaissance;
            user.usertable.Rows[0][6] = usr._ImageProfile;
            user.usertable.Rows[0][7] = usr._Password;
            HappendInSystem("Updated Here Profile");
            
        }
        public  DataView searchCar(string modelOrMatricule)
       {
            HappendInSystem("Searching for a car " + modelOrMatricule);
            DataView dv = new DataView(clientdataset.Tables["cars"]);
            dv.RowFilter = "(( matricule like '%" + modelOrMatricule + "%' or model like '%" + modelOrMatricule + "%') and aviable not like '0')";
            return dv;
        }
        public  DataRow ShowCar(string matricule)
        {
            row = null;
            if (clientdataset.Tables["cars"].Rows.Count > 0)
            {
                for (int i = 0; i < clientdataset.Tables["cars"].Rows.Count; i++)
                {
                    if (clientdataset.Tables["cars"].Rows[i][0].Equals(matricule) && !clientdataset.Tables["cars"].Rows[i]["aviable"].Equals("0"))
                    {
                        row = clientdataset.Tables["cars"].Rows[i];
                    }

                }
                HappendInSystem("Show A Car");
            }
            return row;

        }
        public  List<Details> ShowFacture()
        {
            
            if(user.usertable.Rows.Count>0)
                 cin = (string)user.usertable.Rows[0]["cin"];
            DataTable dt = new DataTable();
            List<Contract> lst = new List<Contract>();
            for (int i = 0; i < clientdataset.Tables["contract"].Rows.Count; i++)
            {
                if (clientdataset.Tables["contract"].Rows[i]["cin"].Equals(cin))
                {
                    lst.Add(new Contract(clientdataset.Tables["contract"].Rows[i]["matricule"].ToString(),
                        int.Parse(clientdataset.Tables["contract"].Rows[i]["nbDay"].ToString())));
                }
            }
            List<Details> car = new List<Details>();
            for (int i = 0; i < clientdataset.Tables["cars"].Rows.Count; i++)
            {
                for (int j = 0; j < lst.Count; j++)
                {
                    if (clientdataset.Tables["cars"].Rows[i]["matricule"].Equals(lst[j].matricule))
                    {
                        Details c = new Details(clientdataset.Tables["cars"].Rows[i]["NomCar"].ToString(),
                                          clientdataset.Tables["cars"].Rows[i]["Matricule"].ToString(),
                                          clientdataset.Tables["cars"].Rows[i]["model"].ToString(),
                                          clientdataset.Tables["cars"].Rows[i]["color"].ToString(),
                                          int.Parse(lst[j].nbday.ToString()),
                                          float.Parse(clientdataset.Tables["cars"].Rows[i]["price"].ToString()) * lst[j].nbday,
                                          lst[j].nbday * float.Parse(clientdataset.Tables["cars"].Rows[i]["price"].ToString()) * lst[j].nbday);
                        car.Add(c);
                    }
                }
            }
            for (int i = 0; i < clientdataset.Tables["promotion"].Rows.Count; i++)
            {
                for (int j = 0; j < car.Count; j++)
                {
                    if (clientdataset.Tables["promotion"].Rows[i]["Matricule"].Equals(car[j].Matricule))
                    {
                        car[j].Price -= float.Parse(clientdataset.Tables["promotion"].Rows[i]["reduction"].ToString()) / 100*lst[i].nbday;
                    }
                }
            }
            return car;
        }
        public  void FillDataSet()
        {
            datadeconnectionMode.FillDataSetByOneTable(clientdataset, "cars");
            datadeconnectionMode.FillDataSetByOneTable(clientdataset, "Promotion");
            datadeconnectionMode.FillDataSetByOneTable(clientdataset, "reservedCars");
            datadeconnectionMode.FillDataSetByOneTable(clientdataset, "logs");
            datadeconnectionMode.FillDataSetByOneTable(clientdataset, "contract");
            HappendInSystem("Logged In ");
            DeleteExpirationPromotion();
        }
        public  void updateDataBase()
        {
            HappendInSystem("Logged Out");
            datadeconnectionMode.UpdateDataBase(clientdataset,"cars");
            datadeconnectionMode.UpdateDataBase(clientdataset, "reservedCars");
            datadeconnectionMode.UpdateDataBase(clientdataset, "logs");
            datadeconnectionMode.UpdateDataBase(user.usertable, "usertable");
            datadeconnectionMode.UpdateDataBase(clientdataset, "Promotion");
            user.usertable.Clear();
            clientdataset.Clear();
        }
        public  void MakeOrder(string matricule) 
        {
            View.Client.dateDeo d = new View.Client.dateDeo();
            d.ShowDialog();
            if (d.isok)
            {
                if (d.dtstart.Value >= DateTime.Today && d.dtend.Value > d.dtstart.Value)
                {
                    DataRow row = clientdataset.Tables["reservedcars"].NewRow();
                    row[0] = user.usertable.Rows[0]["cin"];
                    row[1] = matricule;
                    row[2] = d.dtstart.Value;
                    row[3] = d.dtend.Value.Subtract(d.dtstart.Value).TotalDays;
                    clientdataset.Tables["ReservedCars"].Rows.Add(row);
                    UpdateAviableCars(matricule, "no");
                    HappendInSystem("Reserved a Car");
                }
            }
            
        }
        public  DataTable PromotionCars()
        {
            return clientdataset.Tables["promotion"];
        }
        public bool ExistedClient(string cin)
        {
            column col = new column("cin", "'" + cin + "'");
            SqlDataReader rd=(SqlDataReader)dataconnectionMode.Read("usertable",col,OpType.Equals);
            rd.Read();
            if (rd.HasRows)
            {
                dataconnectionMode.CloseReading();
                return true;
            }
            else
            {
                dataconnectionMode.CloseReading();
                return false;
            }
            
        }
        private void HappendInSystem(string action)
        {
            DataRow r = clientdataset.Tables["logs"].NewRow();
            r[0] = user.usertable.Rows[0]["cin"];
            r[1] = DateTime.Now;
            r[2] = action;
            clientdataset.Tables["logs"].Rows.Add(r);
        }
        private void UpdateAviableCars(string matricule, string avaible)
        {
            for (int i = 0; i < clientdataset.Tables["cars"].Rows.Count; i++)
            {
                if (clientdataset.Tables["cars"].Rows[i]["matricule"].Equals(matricule))
                {
                    clientdataset.Tables["cars"].Rows[i]["aviable"] = avaible;
                    break;
                }
            }
        }
        public void LoadNotifications(System.Windows.Forms.ListView notification)
        {
            try
            {
                for (int i = 0; i < clientdataset.Tables["promotion"].Rows.Count; i++)
                {
                    System.Windows.Forms.ListViewItem item = new System.Windows.Forms.ListViewItem();
                    item.Text = clientdataset.Tables["promotion"].Rows[i]["description"].ToString();
                    notification.Items.Add(item);
                }
            }catch{}
        }

        private void DeleteExpirationPromotion()
        {
            try
            {
                foreach (DataRow item in clientdataset.Tables["promotion"].Rows)
                {
                    if (Convert.ToDateTime(item[4]).Subtract(DateTime.Today).TotalDays <= 0)
                    {
                        item.Delete();
                        HappendInSystem("Deleted An Expired Promotion");
                    }
                }

            }
            catch 
            {
                HappendInSystem("Try To Deleted An Expired Promotion");


            }
        }

    }
}