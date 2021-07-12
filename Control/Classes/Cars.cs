using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using GestionDeLocationVoiture.Control.Interfaces;
namespace GestionDeLocationVoiture.Control.Classes
{
    class Cars
    {
        private Ihelper h = new Helper();

        public string _matricule { get; set; }
        public string _nomcar { get; set; }
        public string _model { get; set; }
        public string _color { get; set; }
        public float _price { get; set; }
        public string _description { get; set; }
        public string _avaible { get; set; }
        public byte[] _image { get; set; }

        public Cars(string __matricule,string __nomcar,string __model,string __color,
                    float __price,string __description,string __avaible,Image __image)
        {
            _matricule = __matricule;
            _nomcar = __nomcar;
            _model = __model;
            _color = __color;
            _price = __price;
            _description = __description;
            _avaible=__avaible;
            _image = h.ConvertImageToByteArray(__image);
        }
        public Cars(string __matricule, string __nomcar, string __model, string __color,
                    float __price)
        {
            _matricule = __matricule;
            _nomcar = __nomcar;
            _model = __model;
            _color = __color;
            _price = __price;
        }
        public Cars(string __matricule,float __price)
        {
            _matricule = __matricule;
            _price = __price;
        }
    }
}
