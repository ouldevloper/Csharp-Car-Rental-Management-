using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using OlDeveloper.Data.Common;
using OlDeveloper.Data.SqlServer;
using GestionDeLocationVoiture.Control.Interfaces;
using OlDeveloper.SecurityAndNetworking;
namespace GestionDeLocationVoiture.Control.Classes
{
    
    class AdminControler:IAdminControler
    {
        public  static DataSet Admindataset = new DataSet();
        private static SqlServerDeconnectionMode s = SqlServerDeconnectionMode.GetInstance(@"server=.\oldeveloper;
                                                                                             database=locationcar1; 
                                                                                            integrated security=true;");
        private static SqlServer ss = SqlServer.GetInstance(@"server=.\oldeveloper;
                                                              database=locationcar1;
                                                              integrated security=true;");
        public void FillDataSet()
        {
            s.FillDataSetByOneTable(Admindataset, "promotion");
            s.FillDataSetByOneTable(Admindataset, "cars");
            s.FillDataSetByOneTable(Admindataset, "logs");
            HappendInSystem("Logged In ");
        }
        public void UpdateDb()
        {
            HappendInSystem("Logged Out ");
            s.UpdateDataBase(Admindataset, "promotion");
            s.UpdateDataBase(Admindataset, "logs");
            user.usertable.Clear();
            Admindataset.Clear();

        }
        public void FillCombobox(System.Windows.Forms.ComboBox cmb,string name)
        {
            ss.FillComboBoxByOneTable(cmb, name,"matricule","matricule");
        }
        public void pushPromotion(Promotion promotion)
        {
            DataRow row = Admindataset.Tables["promotion"].NewRow();
            row[0] = promotion._title;
            row[1] = promotion._matricule;
            row[2] = promotion._reduction;
            row[3] = promotion._description;
            row[4] = promotion._endpromotion;           
            Admindataset.Tables["promotion"].Rows.Add(row);
            HappendInSystem("Maked A New Promotion");

        }
        public void RemoveClient(string cin)
        {            
                column col=new column("cin","'"+cin+"'");
                ss.Delete("userTable", col, OpType.Equals);
                HappendInSystem("Deleted a Client "+cin);

        }
        public DataTable searchClien(string cin)
        {
            DataTable dt=new DataTable();
            HappendInSystem("Searching For a Client "+cin);
            List<column> col = new List<column>() { new column("cin", "'"+cin+"'"),
                                                    new column("permission", "'client'") };
            OpType[] op=new OpType[]{OpType.Equals,OpType.Equals};
            if (ss.Read("userTable", col, op) != null)
                dt.Load(ss.Read("userTable", col, op));
            return dt;
        }
        public void DeleteExpirationPromotion()
        {
            try
            {
                foreach (DataRow item in Admindataset.Tables["promotion"].Rows)
                {
                    if (Convert.ToDateTime(item[4]).Subtract(DateTime.Today).TotalDays <= 0)
                    {
                        item.Delete();
                        HappendInSystem("Deleted An Expired Promotion");
                    }
                }
                
            }catch
            {
                HappendInSystem("Try To Deleted An Expired Promotion");


            }
        }
        public void ClearLogs()
        {
            Admindataset.Tables["logs"].Clear();
            HappendInSystem("Deleting All Logs");

        }
        private void HappendInSystem(string action)
        {
            DataRow r = Admindataset.Tables["logs"].NewRow();
            if(user.usertable.Rows.Count>0)
                r[0] = user.usertable.Rows[0]["cin"];
            else
            {
                Networking n = new Networking();
                n.GetInternetProtocol();
            }
                
            r[1] = DateTime.Now;
            r[2] = action;
            Admindataset.Tables["logs"].Rows.Add(r);
        }
        public bool ExistMatricule(string matricule)
        {
            bool isExist=true;
            foreach (DataRow item in Admindataset.Tables["promotion"].Rows)
            {
                if (item["matricule"].ToString().Equals(matricule))
                {
                    isExist = true;
                    break;
                }
                else
                {
                    isExist = false;
                }
            }
            return isExist;
        }
    }
}
