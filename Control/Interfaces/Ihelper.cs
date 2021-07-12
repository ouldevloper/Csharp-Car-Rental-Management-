using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeLocationVoiture.Control.Interfaces
{
    interface Ihelper
    {
          byte[] ConvertImageToByteArray(System.Drawing.Image img);
          System.Drawing.Image ConvertBytesToImage(byte[] img);

    }
}
