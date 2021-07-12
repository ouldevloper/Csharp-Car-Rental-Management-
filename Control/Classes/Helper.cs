using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Data;
using OlDeveloper.SecurityAndNetworking;
namespace GestionDeLocationVoiture.Control.Classes
{
    class Helper:Interfaces.Ihelper
    {
        
        public   byte[] ConvertImageToByteArray(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                if (img != null)
                {
                    if (img.RawFormat.GetType() == typeof(System.Drawing.Imaging.ImageFormat))
                    {
                        img.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                    }
                    else
                    {
                        img.Save(ms, img.RawFormat);
                    }
                }
                return ms.ToArray();

            }
        }
        public   Image ConvertBytesToImage(byte[] img)
        {
            MemoryStream ms = new MemoryStream(img);
            return Image.FromStream(ms);
                
            
        }
        
    }
}
