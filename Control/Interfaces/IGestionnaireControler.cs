using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GestionDeLocationVoiture.Control.Classes;
namespace GestionDeLocationVoiture.Control.Interfaces
{
    interface IGestionnaireControler
    {
        DataTable showCars();
        DataRow SearchCar(string matricule);
        DataView SearchCars(object matriculeOrModel);
        string showCarIfAviable(string matricule);
        void deleteCare(string matricule);
        void UpdateAviableCars(string matricule, string avaible);
        void AddFacture(facture _facture);
        void AddCar(Cars car);
        void FillDataSet();
        void updateDataBase();
        void ConfirmeOrder(Contract con);
        void CancelOrder(string matricule);
        DataView searchForClienOrder(string cin);
        List<Details> ShowClientFacture(string cin);
        void UpdateContract(string matricule);
        void FillCombobox(System.Windows.Forms.ComboBox cmb);
        int getLatsIdBill();
        bool ExistCar(string matricule);
    }
}
