using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Proyecto_Procesamiento_Imagenes.Clases;

namespace Proyecto_Procesamiento_Imagenes.Ventanas
{
    public partial class Form_Camara : Form
    {
        private bool isDevice = true;
        private FilterInfoCollection misDispositivos;
        private VideoCaptureDevice miWebCam;
        private int contadorPersonas = 0;
        Filtros filtros = new Filtros();
        private Color[] colorCamCapture = new Color[10];

        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");

        public Form_Camara()
        {
            InitializeComponent();
            InicializarColoresArray();
        }

        private void Form_Camara_Load(object sender, EventArgs e)
        {
            CargarDispositivos();
        }

        public void CargarDispositivos()
        {
            misDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (misDispositivos.Count > 0)
            {
                isDevice = true;
                for (int i = 0; i < misDispositivos.Count; i++)
                    comboBox1.Items.Add(misDispositivos[i].Name.ToString());

                comboBox1.Text = misDispositivos[0].ToString();
            }
            else
            {
                isDevice = false;
            }
        }

        public void CerrarWebCam()
        {
            if (miWebCam != null && miWebCam.IsRunning)
            {
                miWebCam.SignalToStop();
                miWebCam = null;
            }
        }

        private void btn_Empezar_Click(object sender, EventArgs e)
        {
            CerrarWebCam();
            int i = comboBox1.SelectedIndex;
            string NombreVideo = misDispositivos[i].MonikerString;
            miWebCam = new VideoCaptureDevice(NombreVideo);
            miWebCam.NewFrame += new NewFrameEventHandler(Capturando);
            miWebCam.Start();
            lbl_Contador.Text = contadorPersonas.ToString();
        }

        private void Capturando(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();

            Image<Bgr, byte> nuevaImagen = new Image<Bgr, byte> (imagen);
            Rectangle[] rectangulos = cascadeClassifier.DetectMultiScale(nuevaImagen, 1.2, 1);

            contadorPersonas = 0;
            foreach (Rectangle rectangulo in rectangulos)
            {
                Graphics graphics = Graphics.FromImage(imagen);
                Pen pen = new Pen(colorCamCapture[contadorPersonas], 3);
                graphics.DrawRectangle(pen, rectangulo);

                contadorPersonas++;
            }

            if (InvokeRequired)
                Invoke(new Action(() => lbl_Contador.Text = contadorPersonas.ToString()));

            img_Camara.Image = imagen;
        }

        private void InicializarColoresArray() 
        {
            colorCamCapture[0] = Color.Pink;
            colorCamCapture[1] = Color.Green;
            colorCamCapture[2] = Color.Blue;
            colorCamCapture[3] = Color.Black;
            colorCamCapture[4] = Color.Coral;
            colorCamCapture[5] = Color.Red;
            colorCamCapture[6] = Color.Green;
            colorCamCapture[7] = Color.Blue;
            colorCamCapture[8] = Color.Black;
            colorCamCapture[9] = Color.Coral;
        }

        private void Form_Camara_FormClosed(object sender, FormClosedEventArgs e)
        {
            CerrarWebCam();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             
        }

        private void CerrarCamara_Click(object sender, EventArgs e)
        {
            CerrarWebCam();
        }
    }
}
