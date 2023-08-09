using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Procesamiento_Imagenes.Clases
{
    internal class Filtros
    {
        public Filtros() { }

        public Bitmap Filtro_Escala_Grises(Bitmap original) 
        {
            Bitmap nuevo = null;
            return nuevo;
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

        public Bitmap Filtro_Binario(Bitmap original)
        {
            Bitmap nuevo = null;

            return nuevo;
        }
    }
}
