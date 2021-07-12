using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Drawing;
using GestionDeLocationVoiture.Control.Classes;
namespace GestionDeLocationVoiture.Control.Interfaces
{
    interface IAdminControler
    {
         void FillDataSet();
         void FillCombobox(System.Windows.Forms.ComboBox cmb, string name);
         void pushPromotion(Promotion promotion);
         void RemoveClient(string cin);
         DataTable searchClien(string cin);
         void UpdateDb();
         void DeleteExpirationPromotion();
         void ClearLogs();
         bool ExistMatricule(string matricule);
    }
}
