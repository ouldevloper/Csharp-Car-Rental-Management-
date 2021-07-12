using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using OlDeveloper.Data.Common;
using OlDeveloper.Data.SqlServer;
using GestionDeLocationVoiture.Control.Interfaces;
using OlDeveloper.SecurityAndNetworking;
namespace GestionDeLocationVoiture.Control.Classes
{
    class GestionnaireControler :IGestionnaireControler
    {
        private DataRow row;
        private static SqlServerDeconnectionMode datadeconnectionMode = SqlServerDeconnectionMode.GetInstance(@"server=.\oldeveloper;database=locationcar1;integrated security=true;");
        private static SqlServer dataconnectionMode = SqlServer.GetInstance(@"server=.\oldeveloper;database=locationcar1;integrated security=true;");
        public static DataSet managerdataset = new DataSet();




        public DataTable showCars()
        {
            HappendInSystem("Displayed All Cars");
            DataView dv = new DataView(managerdataset.Tables["Cars"]);
            dv.RowFilter = "aviable not like '0'";
            return dv.Table;
        } 

        public DataRow SearchCar(string matricule)
        {
            HappendInSystem("Searching For Car, Matricule is "+matricule);

            for (int i = 0; i < managerdataset.Tables["cars"].Rows.Count; i++)
            {
                if (managerdataset.Tables["cars"].Rows[i][0].Equals(matricule))
                {
                    if(!managerdataset.Tables["cars"].Rows[i]["aviable"].Equals("0"))
                        row = managerdataset.Tables["cars"].Rows[i];
                }

            }
            return row;
        }

        public DataView SearchCars(object matriculeOrModel)
        {
            DataView dv = new DataView();
            HappendInSystem("Searching For Cars");
            dv.Table = managerdataset.Tables["cars"];
            dv.RowFilter = "matricule like '%" + matriculeOrModel + "%' or model like '%"+matriculeOrModel+"%' and aviable not like '0'";
            return dv;
        }

        public string showCarIfAviable(string matricule)
        {
            HappendInSystem("Checked If Car are Aviable or Not");
            try
            {
                DataRow dv = SearchCar(matricule);
                if (dv != null){
                    if (dv["aviable"].ToString().Equals("yes"))
                        return "This Car Is Aviable";
                    else if (dv["aviable"].ToString().Equals("no"))
                        return "This Car Is Not Aviable";

                }
                else
                    return "This Car does not exist in sys\nor it removed from sys";
            }
            catch {  }
            return "";
        }

        public void deleteCare(string matricule)
        {
            for (int i = 0; i < managerdataset.Tables["cars"].Rows.Count; i++)
            {
                if (managerdataset.Tables["cars"].Rows[i]["matricule"].Equals(matricule))
                {
                    managerdataset.Tables["cars"].Rows[i]["aviable"] = "0";
                }
            }
            HappendInSystem("Deleted a Car "+matricule);
        }

        public void UpdateAviableCars(string matricule, string avaible)
        {
            for (int i = 0; i < managerdataset.Tables["cars"].Rows.Count; i++)
            {
                if (managerdataset.Tables["cars"].Rows[i]["matricule"].Equals(matricule))
                {
                    managerdataset.Tables["cars"].Rows[i]["aviable"] = avaible;
                }
            }
        }

        private void HappendInSystem(string action)
        {
            if(managerdataset.Tables["logs"]!=null){
                DataRow r = managerdataset.Tables["logs"].NewRow();
                if (user.usertable.Rows.Count > 0)
                    r[0] = user.usertable.Rows[0]["cin"];
                else
                {
                    Networking n = new Networking();
                    n.GetInternetProtocol();
                }
                r[1] = DateTime.Now;
                r[2] = action;
                managerdataset.Tables["logs"].Rows.Add(r);
            }
        }

        public void AddFacture(facture _facture)
        {
            DataRow billrow = managerdataset.Tables["Bill"].NewRow();
            DataRow billDetailsrow = managerdataset.Tables["BillDetails"].NewRow();
            billrow[0] = _facture._idfacture;
            billrow[1] = _facture._cin;
            billrow[2] =  _facture._dt;
            managerdataset.Tables["Bill"].Rows.Add(billrow);
            foreach (var item in _facture._details)
            {
                billDetailsrow[0] = item._idfacture;
                billDetailsrow[1] = item._matricule;
                billDetailsrow[2] = item.nbday;
                billDetailsrow[3] = item.price;
                managerdataset.Tables["BillDetails"].Rows.Add(billDetailsrow);
                UpdateContract(item._matricule);
                UpdateAviableCars(item._matricule, "yes");
                HappendInSystem(_facture._cin + " Pay For " + user.usertable.Rows[0]["cin"].ToString());
            }
        }

        public void AddCar(Cars car)
        {
            DataRow row = managerdataset.Tables["cars"].NewRow();
            row[0] = car._matricule;
            row[1]=car._nomcar;
            row[2] = car._model;
            row[3] = car._color;
            row[4] = car._price;
            row[5] = car._description;
            row[7] = car._image;
            row[6] = car._avaible;
            managerdataset.Tables["cars"].Rows.Add(row);
            HappendInSystem("Added Car "+car._matricule);
        }

        public void FillDataSet()
        {
            datadeconnectionMode.FillDataSetByOneTable(managerdataset, "Cars");
            datadeconnectionMode.FillDataSetByOneTable(managerdataset, "promotion");
            datadeconnectionMode.FillDataSetByOneTable(managerdataset, "Bill");
            datadeconnectionMode.FillDataSetByOneTable(managerdataset, "BillDetails");
            datadeconnectionMode.FillDataSetByOneTable(managerdataset, "Contract");
            datadeconnectionMode.FillDataSetByOneTable(managerdataset, "ReservedCars");
            datadeconnectionMode.FillDataSetByOneTable(managerdataset, "logs");
            HappendInSystem("Logged In");
            DeleteExpirationPromotion();
        }

        public void updateDataBase() 
        {
            HappendInSystem("Logged Out");
            datadeconnectionMode.UpdateDataBase(managerdataset, "Cars");
            datadeconnectionMode.UpdateDataBase(managerdataset, "Bill");
            datadeconnectionMode.UpdateDataBase(managerdataset, "BillDetails");
            datadeconnectionMode.UpdateDataBase(managerdataset, "ReservedCars");
            datadeconnectionMode.UpdateDataBase(managerdataset, "Contract");
            datadeconnectionMode.UpdateDataBase(managerdataset, "logs");
            managerdataset.Clear();
            user.usertable.Clear();
        }

        public void ConfirmeOrder(Contract con)
        {
            DataRow row = managerdataset.Tables["contract"].NewRow();
            row[0] = con.cin;
            row[1] = con.matricule;
            row[2] = con.started;
            row[3] = con.nbday;
            managerdataset.Tables["contract"].Rows.Add(row);
            for (int i = 0; i < managerdataset.Tables["ReservedCars"].Rows.Count; i++)
            {
                if (managerdataset.Tables["ReservedCars"].Rows[i][1].Equals(con.matricule))
                {
                    managerdataset.Tables["ReservedCars"].Rows[i].Delete();
                }
            }
            HappendInSystem("Confirmed An Order For "+con.cin);
        }

        public void CancelOrder(string matricule)
        {
            for (int i = 0; i < managerdataset.Tables["ReservedCars"].Rows.Count; i++)
            {
                if (managerdataset.Tables["ReservedCars"].Rows[i][1].Equals(matricule))
                {
                    managerdataset.Tables["ReservedCars"].Rows[i].Delete();
                    UpdateAviableCars(matricule, "yes");
                }
            }
            HappendInSystem("Canceled an Order of "+matricule);
        }

        public DataView searchForClienOrder(string cin)
        {
            HappendInSystem("Searched For an Order of "+cin);
            DataView dv = new DataView();
            dv.Table = managerdataset.Tables["ReservedCars"];
            dv.RowFilter = "cin like '" + cin + "'";
            return dv;
        }

        public List<Details> ShowClientFacture(string cin)
        {
            DataTable dt = new DataTable();
            List<Contract> lst=new List<Contract>();
            for (int i = 0; i < managerdataset.Tables["contract"].Rows.Count; i++)
            {
                if (managerdataset.Tables["contract"].Rows[i]["cin"].Equals(cin))
                {
                    lst.Add(new Contract(managerdataset.Tables["contract"].Rows[i]["matricule"].ToString(),
                        int.Parse(managerdataset.Tables["contract"].Rows[i]["nbDay"].ToString())));
                }
            }
            List<Details> car = new List<Details>();
            for (int i = 0; i < managerdataset.Tables["cars"].Rows.Count; i++)
            {
                for (int j = 0; j < lst.Count; j++)
                {
                    if (GestionnaireControler.managerdataset.Tables["cars"].Rows[i]["matricule"].Equals(lst[j].matricule))
                    {
                        Details c = new Details(managerdataset.Tables["cars"].Rows[i]["NomCar"].ToString(),
                                          managerdataset.Tables["cars"].Rows[i]["Matricule"].ToString(),
                                          managerdataset.Tables["cars"].Rows[i]["model"].ToString(),
                                          managerdataset.Tables["cars"].Rows[i]["color"].ToString(),
                                          int.Parse(lst[j].nbday.ToString()),
                                          float.Parse(managerdataset.Tables["cars"].Rows[i]["price"].ToString())*lst[j].nbday,
                                          lst[j].nbday * float.Parse(managerdataset.Tables["cars"].Rows[i]["price"].ToString()) * lst[j].nbday);
                        car.Add(c);
                    }
                }
            }
            for (int i = 0; i < managerdataset.Tables["promotion"].Rows.Count; i++)
            {
                for (int j = 0; j < car.Count; j++)
                {
                    if (managerdataset.Tables["promotion"].Rows[i]["Matricule"].Equals(car[j].Matricule))
                    {
                        car[j].Price -= (car[j].Price * float.Parse(managerdataset.Tables["promotion"].Rows[i]["reduction"].ToString()) / 100) * lst[i].nbday;
                    }
                }
            }
            HappendInSystem("Searching For Client [ " + cin + " ] Bill ");
            return car;
        }

        public void UpdateContract(string matricule)
        {
            for (int i = 0; i < managerdataset.Tables["contract"].Rows.Count; i++)
            {
                if (managerdataset.Tables["contract"].Rows[i]["matricule"].Equals(matricule))
                {
                    managerdataset.Tables["contract"].Rows[i].Delete();
                }
            }
        }

        public void FillCombobox(System.Windows.Forms.ComboBox cmb)
        {
            dataconnectionMode.FillComboBoxByOneTable(cmb, "cars", "matricule", "matricule");
        }

        public int getLatsIdBill()
        {
            int id = (int)managerdataset.Tables["bill"].Rows[managerdataset.Tables["bill"].Rows.Count - 1][0];
            return id+1;
        }
        public bool ExistCar(string matricule)
        {
            bool isExist = true;
            for (int i = 0; i < managerdataset.Tables["cars"].Rows.Count; i++)
            {
                if (managerdataset.Tables["cars"].Rows[i]["matricule"].ToString().Equals(matricule))
                {
                    isExist = true;
                    break;
                }
                else
                    isExist = false;
            }
            return isExist;
        }

        private void DeleteExpirationPromotion()
        {
            try
            {
                foreach (DataRow item in managerdataset.Tables["promotion"].Rows)
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
