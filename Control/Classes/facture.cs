using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeLocationVoiture.Control.Classes
{
    class factureDetails
    {
        public int _idfacture { get; set; }
        public string _matricule { get; set; }
        public int nbday { get; set; }
        public float price { get; set; }
        
    }
    class facture
    {
        public int _idfacture { get; set; }
        public string _cin { get; set; }
        public DateTime _dt { get; set; }
        public List<factureDetails> _details { get; set; }
    }
}
