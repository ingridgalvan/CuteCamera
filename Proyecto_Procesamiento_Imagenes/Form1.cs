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
using Proyecto_Procesamiento_Imagenes.Ventanas;

namespace Proyecto_Procesamiento_Imagenes
{
    public partial class Form1 : Form
    {
        private Form formActual = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void AbrirFormSecundario(Form form) 
        {
            if (formActual != null) 
                formActual.Close();

            formActual = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel_Form.Controls.Add(form);
            panel_Form.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            AbrirFormSecundario(new Form_Imagen());
        }

        private void btn_camara_Click(object sender, EventArgs e)
        {
            AbrirFormSecundario(new Form_Camara());
        }

        private void btn_video_Click(object sender, EventArgs e)
        {
            AbrirFormSecundario(new Form_Video());
        }

        private void panel_Form_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_manual_Click(object sender, EventArgs e)
        {
            AbrirFormSecundario(new Form_Manual());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
