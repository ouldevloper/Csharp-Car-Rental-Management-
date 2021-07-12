using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeLocationVoiture.Control.Classes
{
    class Contract
    {
        public string cin { get; set; }
        public string matricule { get; set; }
        public DateTime started { get; set; }
        public int nbday { get; set; }
        public Contract() { }
        public Contract(string matricule, int nbday) 
        {
            this.matricule = matricule; 
            this.nbday = nbday;
        }
    }
}
