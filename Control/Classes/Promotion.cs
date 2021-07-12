using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeLocationVoiture.Control.Classes
{
    public class Promotion
    {
        public string _title;
        public string _matricule;
        public float _reduction;
        public DateTime _endpromotion;
        public string _description;
        public Promotion(
            string __title, string __matricule, float __reduction,
            DateTime __endpromotion, string __description)
        {
            _title = __title;
            _matricule = __matricule;
            _reduction = __reduction;
            _endpromotion = __endpromotion;
            _description = __description;
        }
    }
}
