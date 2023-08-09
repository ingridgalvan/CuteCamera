namespace Proyecto_Procesamiento_Imagenes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_manual = new FontAwesome.Sharp.IconButton();
            this.btn_imagen = new FontAwesome.Sharp.IconButton();
            this.btn_camara = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel_Form = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_video = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel_Form.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_manual);
            this.panel1.Controls.Add(this.btn_video);
            this.panel1.Controls.Add(this.btn_imagen);
            this.panel1.Controls.Add(this.btn_camara);
            this.panel1.Location = new System.Drawing.Point(213, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 91);
            this.panel1.TabIndex = 3;
            // 
            // btn_manual
            // 
            this.btn_manual.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_manual.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_manual.BackgroundImage")));
            this.btn_manual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_manual.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_manual.FlatAppearance.BorderSize = 0;
            this.btn_manual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manual.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manual.ForeColor = System.Drawing.Color.Orange;
            this.btn_manual.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            this.btn_manual.IconColor = System.Drawing.Color.White;
            this.btn_manual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_manual.IconSize = 1;
            this.btn_manual.Location = new System.Drawing.Point(381, 0);
            this.btn_manual.Margin = new System.Windows.Forms.Padding(2);
            this.btn_manual.Name = "btn_manual";
            this.btn_manual.Size = new System.Drawing.Size(126, 91);
            this.btn_manual.TabIndex = 4;
            this.btn_manual.Text = "Manual";
            this.btn_manual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_manual.UseVisualStyleBackColor = false;
            this.btn_manual.Click += new System.EventHandler(this.btn_manual_Click);
            // 
            // btn_imagen
            // 
            this.btn_imagen.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_imagen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_imagen.BackgroundImage")));
            this.btn_imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_imagen.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_imagen.FlatAppearance.BorderSize = 0;
            this.btn_imagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imagen.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imagen.ForeColor = System.Drawing.Color.Orange;
            this.btn_imagen.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.btn_imagen.IconColor = System.Drawing.Color.Orange;
            this.btn_imagen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_imagen.IconSize = 1;
            this.btn_imagen.Location = new System.Drawing.Point(122, 0);
            this.btn_imagen.Margin = new System.Windows.Forms.Padding(2);
            this.btn_imagen.Name = "btn_imagen";
            this.btn_imagen.Size = new System.Drawing.Size(130, 91);
            this.btn_imagen.TabIndex = 2;
            this.btn_imagen.Text = "Imagen";
            this.btn_imagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_imagen.UseVisualStyleBackColor = false;
            this.btn_imagen.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btn_camara
            // 
            this.btn_camara.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_camara.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_camara.BackgroundImage")));
            this.btn_camara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_camara.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_camara.FlatAppearance.BorderSize = 0;
            this.btn_camara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_camara.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_camara.ForeColor = System.Drawing.Color.Orange;
            this.btn_camara.IconChar = FontAwesome.Sharp.IconChar._500Px;
            this.btn_camara.IconColor = System.Drawing.Color.Orange;
            this.btn_camara.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_camara.IconSize = 1;
            this.btn_camara.Location = new System.Drawing.Point(0, 0);
            this.btn_camara.Margin = new System.Windows.Forms.Padding(2);
            this.btn_camara.Name = "btn_camara";
            this.btn_camara.Size = new System.Drawing.Size(122, 91);
            this.btn_camara.TabIndex = 1;
            this.btn_camara.Text = "Camara";
            this.btn_camara.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_camara.UseVisualStyleBackColor = false;
            this.btn_camara.Click += new System.EventHandler(this.btn_camara_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(922, 102);
            this.panel4.TabIndex = 4;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel_Form
            // 
            this.panel_Form.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel_Form.Controls.Add(this.pictureBox2);
            this.panel_Form.Controls.Add(this.pictureBox1);
            this.panel_Form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Form.Location = new System.Drawing.Point(0, 102);
            this.panel_Form.Margin = new System.Windows.Forms.Padding(2);
            this.panel_Form.Name = "panel_Form";
            this.panel_Form.Size = new System.Drawing.Size(922, 494);
            this.panel_Form.TabIndex = 5;
            this.panel_Form.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Form_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 276);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(282, 243);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(637, 301);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_video
            // 
            this.btn_video.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_video.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_video.BackgroundImage")));
            this.btn_video.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_video.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_video.FlatAppearance.BorderSize = 0;
            this.btn_video.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_video.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_video.ForeColor = System.Drawing.Color.Orange;
            this.btn_video.IconChar = FontAwesome.Sharp.IconChar.Video;
            this.btn_video.IconColor = System.Drawing.Color.Orange;
            this.btn_video.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_video.IconSize = 1;
            this.btn_video.Location = new System.Drawing.Point(252, 0);
            this.btn_video.Margin = new System.Windows.Forms.Padding(2);
            this.btn_video.Name = "btn_video";
            this.btn_video.Size = new System.Drawing.Size(129, 91);
            this.btn_video.TabIndex = 3;
            this.btn_video.Text = "Video";
            this.btn_video.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_video.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_video.UseVisualStyleBackColor = false;
            this.btn_video.Click += new System.EventHandler(this.btn_video_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(922, 596);
            this.Controls.Add(this.panel_Form);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel_Form.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_camara;
        private FontAwesome.Sharp.IconButton btn_imagen;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel_Form;
        private FontAwesome.Sharp.IconButton btn_manual;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btn_video;
    }
}