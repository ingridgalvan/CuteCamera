using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Procesamiento_Imagenes.Ventanas
{
    public partial class Form_Manual : Form
    {
        public Form_Manual()
        {
            InitializeComponent();
        }
        
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
         
        private void Form_Manual_Load(object sender, EventArgs e)
        {
            string string1 = "Aplicación de filtros para fotos y videos, con histograma incluido";
            string string2 = "En el menú se encuentran 4 botones: 'Camara', 'Imagen', 'Video' y 'Manual'.";
            string string3 = "La opcion de Camara nos permitira tomar fotos, primero deberemos elegir la camara en la parte superior presionar el boton de encender"+"Una vez que hayamos finalizado su uso tendremos que desactivar la camara";
               
               
            string string4 = "En la opcion de Imagen nos permitira cargar la imagen y editarla con los filtros";
            string string5 = "En la opcion de Video nos permitira cargar la imagen y editarlo con los filtros";
            string string6 = "El boton de restaurar volvera la imagen o video a su forma original";

            richTextBox1.Text = string1 + System.Environment.NewLine +
                                string2 + System.Environment.NewLine +
                                string3 + System.Environment.NewLine +
                                string4 + System.Environment.NewLine +
                                string5 + System.Environment.NewLine +
                                string6;
        }
    }
}
