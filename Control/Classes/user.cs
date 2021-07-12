using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OlDeveloper.Data.SqlServer;
using System.Data;
using System.IO;
using System.Drawing;
using System.Data.SqlClient;
using OlDeveloper.SecurityAndNetworking;
namespace GestionDeLocationVoiture.Control.Classes
{
    class user:Interfaces.IUser
    {
        Serial s = new Serial();
        private SqlServerDeconnectionMode obj = SqlServerDeconnectionMode.GetInstance(@"server=.\OLDEVELOPER;database=LocationCar1;integrated security=true;");
        public static DataTable usertable = new DataTable("usertable");
        public DataTable dtlog = new DataTable("logs"); 
        Interfaces.Ihelper h = new Helper();
        public string _Cin { get; set; }
        public string _FullName { get; set; }
        public string _Address { get; set; }
        public string _Email { get; set; }
        public string _Phone { get; set; }
        public DateTime _DateNaissance { get; set; }
        public byte[] _ImageProfile { get; set; }
        public string _Password { get; set; }
        public DateTime _LasetActivity { get; set; }
        public string _permission { get; set; }
        public user(string __Cin, string __FullName, string __Address, string __Email,
                    string __Phone, DateTime __DateNaissance, Image __ImageProfile,
                    string __Password, DateTime __LasetActivity, string __permission)
        {
            this._Cin = __Cin;
            _FullName = __FullName;
            _Address = __Address;
            _Email = __Email;
            _Phone = __Phone;
            _DateNaissance = __DateNaissance;
            _ImageProfile = h.ConvertImageToByteArray(__ImageProfile);
            _Password = Encryption.PasswordEncryptionEverySec(__Password);
            _LasetActivity = __LasetActivity;
            _permission = __permission;
        }
        public user() { }
        public void SignUp(user u)
        {

            System.Data.SqlClient.SqlParameter[] param = new System.Data.SqlClient.SqlParameter[10];
            param[0] = new System.Data.SqlClient.SqlParameter("@a", SqlDbType.VarChar, 10);
            param[0].Value = u._Cin;
            param[1] = new System.Data.SqlClient.SqlParameter("@b", SqlDbType.VarChar, 75);
            param[1].Value = u._FullName;
            param[2] = new System.Data.SqlClient.SqlParameter("@c", SqlDbType.VarChar, 255);
            param[2].Value = u._Address;
            param[3] = new System.Data.SqlClient.SqlParameter("@d", SqlDbType.VarChar, 50);
            param[3].Value = u._Email;
            param[4] = new System.Data.SqlClient.SqlParameter("@e", SqlDbType.VarChar, 15);
            param[4].Value = u._Phone;
            param[5] = new System.Data.SqlClient.SqlParameter("@f", SqlDbType.Date);
            param[5].Value = u._DateNaissance;
            param[6] = new System.Data.SqlClient.SqlParameter("@g", SqlDbType.Image);
            param[6].Value = u._ImageProfile;
            param[7] = new System.Data.SqlClient.SqlParameter("@h", SqlDbType.VarChar, 255);
            param[7].Value = u._Password;
            param[8] = new System.Data.SqlClient.SqlParameter("@i", SqlDbType.Date);
            param[8].Value = u._LasetActivity;
            param[9] = new System.Data.SqlClient.SqlParameter("@j", SqlDbType.VarChar, 15);
            param[9].Value = u._permission;
            obj.ExecuteStoredProcAndFuc("signup", param);
            HappendInSystem(u._Cin + "Added To System As " + u._permission );
        }
        private DataTable login(string id)
        {
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@a", SqlDbType.VarChar, 50);
            param[0].Value = id;
            return obj.ExecuteStoredProcAndFuc("login", param);
        }
        public bool GeneratForm(string id, string pwd)
        {
                usertable = login(id);
                
                    if (usertable.Rows.Count > 0)
                    {
                            if (Encryption.IsPasswordEncryptionEverySec((string)usertable.Rows[0]["password"], pwd))
                            {
                                switch (usertable.Rows[0]["permission"].ToString().ToLower())
                                {
                                    case "client": View.Client.ClientMainForms clt = new View.Client.ClientMainForms();
                                        byte[] img = (byte[])usertable.Rows[0]["Image"];
                                        clt.clientimg.BackgroundImage = h.ConvertBytesToImage(img);
                                        clt.Show();
                                        UpdateDb();
                                        break;
                                    case "manager": View.Gestionnaire.GestionnaireMainForm mng = new View.Gestionnaire.GestionnaireMainForm();
                                        byte[] img1 = (byte[])usertable.Rows[0]["Image"];
                                        mng.rectangleShape1.BackgroundImage = h.ConvertBytesToImage(img1);
                                        mng.Show();
                                        UpdateDb();
                                        break;
                                    case "admin": View.Admin.AdminMain_Form admin = new View.Admin.AdminMain_Form();
                                        admin.Show();
                                        byte[] img2 = (byte[])usertable.Rows[0]["Image"];
                                        admin.adminimg.BackgroundImage = h.ConvertBytesToImage(img2);
                                        UpdateDb();
                                        break;
                                    default: System.Windows.Forms.Application.Exit(); break;
                                }
                                return true;
                            }else{
                            System.Windows.Forms.MessageBox.Show("Invalide Password");
                            return false;
                            }  
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Can not find User That have those Information\nSign up To Be a Client\nOr Contact Administrator to Make You As Manager");
                        return false;
                    }
                 
               
           
        }
        public void FillDataset()
        {
            obj.FillDataTabletByOneTable(dtlog, "logs");
        }
        public void UpdateDb()
        {
            obj.UpdateDataBase(dtlog, "logs");
        }
        private void HappendInSystem(string action)
        {
            DataRow r = dtlog.NewRow();
            if (dtlog.Rows.Count > 0)
            {
                if (usertable.Rows.Count > 0)
                    r[0] = user.usertable.Rows[0]["cin"];
                else
                {
                    Networking n = new Networking();
                    n.GetInternetProtocol();
                }
                r[1] = DateTime.Now;
                r[2] = action;
                dtlog.Rows.Add(r);
            }
        }
        public void InitialAdmin(user u)
        {

            System.Data.SqlClient.SqlParameter[] param = new System.Data.SqlClient.SqlParameter[10];
            param[0] = new System.Data.SqlClient.SqlParameter("@a", SqlDbType.VarChar, 10);
            param[0].Value = u._Cin;
            param[1] = new System.Data.SqlClient.SqlParameter("@b", SqlDbType.VarChar, 75);
            param[1].Value = u._FullName;
            param[2] = new System.Data.SqlClient.SqlParameter("@c", SqlDbType.VarChar, 255);
            param[2].Value = u._Address;
            param[3] = new System.Data.SqlClient.SqlParameter("@d", SqlDbType.VarChar, 50);
            param[3].Value = u._Email;
            param[4] = new System.Data.SqlClient.SqlParameter("@e", SqlDbType.VarChar, 15);
            param[4].Value = u._Phone;
            param[5] = new System.Data.SqlClient.SqlParameter("@f", SqlDbType.Date);
            param[5].Value = u._DateNaissance;
            param[6] = new System.Data.SqlClient.SqlParameter("@g", SqlDbType.Image);
            param[6].Value = u._ImageProfile;
            param[7] = new System.Data.SqlClient.SqlParameter("@h", SqlDbType.VarChar, 255);
            param[7].Value = u._Password;
            param[8] = new System.Data.SqlClient.SqlParameter("@i", SqlDbType.Date);
            param[8].Value = u._LasetActivity;
            param[9] = new System.Data.SqlClient.SqlParameter("@j", SqlDbType.VarChar, 15);
            param[9].Value = "admin";
            obj.ExecuteStoredProcAndFuc("signup", param);
            HappendInSystem(u._Cin + "Initialis as Admin ");
        }
        public bool IsExist()
        {
            DataTable dt = obj.ExecuteStoredProcAndFuc("IsExistAdmin", null);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;

        }


        public void InsertSerial(string serail)
        {
            SqlParameter[] param=new SqlParameter[1];
            param[0]=new SqlParameter("@a",SqlDbType.VarChar,255);
            param[0].Value=serail;
            if (s.CheckSerial(serail))
            {
                DataTable dt = obj.ExecuteStoredProcAndFuc("Insertsrl", param);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Invalide Serial");
            }
            
        }
        public bool checkserial()
        {
            DataTable dt = obj.ExecuteStoredProcAndFuc("Checksrl", null);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["srl"].ToString().Equals(s.GenerateSerial()))
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
    }
}
