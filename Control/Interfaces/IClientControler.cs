using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GestionDeLocationVoiture.Control.Classes;
namespace GestionDeLocationVoiture.Control.Interfaces
{
    interface IClientControler
    {
         void UpdateProfile(user usr);
         DataView searchCar(string modelOrMatricule);
         DataRow ShowCar(string matricule);
         List<Details> ShowFacture();
         void FillDataSet();
         void updateDataBase();
         void MakeOrder(string matricule);
         void LoadNotifications(System.Windows.Forms.ListView notification);
         DataTable PromotionCars();
         bool ExistedClient(string cin);
    }
}
