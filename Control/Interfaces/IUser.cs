using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using GestionDeLocationVoiture.Control.Classes;
namespace GestionDeLocationVoiture.Control.Interfaces
{
    interface IUser
    {
         bool GeneratForm(string id, string pwd);
         void SignUp(user u);
         void FillDataset();
         void UpdateDb();
         void InitialAdmin(user u);
         bool IsExist();
         void InsertSerial(string serail);
         bool checkserial();
    }
}
