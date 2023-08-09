using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Procesamiento_Imagenes.Clases
{
    internal class Filtros_videos
    {
        public Filtros_videos() { }
        public Int32[] Bits { get; private set; }
        public Bitmap Filtro_Escala_Grises(Bitmap img)
        {
            // Create a new bitmap.
            Bitmap bmp = new Bitmap(img);
return bmp;
        }

        public Bitmap Filtro_Invertido(Image img)
        {
            Bitmap bmpinverted = new Bitmap(img.Width, img.Height);
            return bmpinverted;
        }

        public Bitmap Filtro_Color_Rojo(Image img)
        {
            Bitmap bmpinverted = new Bitmap(img.Width, img.Height);
           return bmpinverted;
        }

        public Bitmap Filtro_Brillo(Image img)
        {
            Bitmap bmpinverted = new Bitmap(img.Width, img.Height);
            return bmpinverted;
        }

        public Bitmap Filtro_Binario(Image img)
        {
            
            Bitmap bmp = new Bitmap(img);
return bmp;
        }
    }
}
