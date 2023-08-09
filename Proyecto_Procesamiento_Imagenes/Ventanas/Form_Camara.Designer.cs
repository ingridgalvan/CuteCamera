namespace Proyecto_Procesamiento_Imagenes.Ventanas
{
    partial class Form_Camara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Camara));
            this.btn_Empezar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.img_Camara = new System.Windows.Forms.PictureBox();
            this.lbl_Contador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CerrarCamara = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_Camara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Empezar
            // 
            this.btn_Empezar.BackColor = System.Drawing.Color.Thistle;
            this.btn_Empezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Empezar.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Empezar.ForeColor = System.Drawing.Color.Orange;
            this.btn_Empezar.Location = new System.Drawing.Point(15, 50);
            this.btn_Empezar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Empezar.Name = "btn_Empezar";
            this.btn_Empezar.Padding = new System.Windows.Forms.Padding(1);
            this.btn_Empezar.Size = new System.Drawing.Size(179, 44);
            this.btn_Empezar.TabIndex = 3;
            this.btn_Empezar.Text = "Activar camara";
            this.btn_Empezar.UseVisualStyleBackColor = false;
            this.btn_Empezar.Click += new System.EventHandler(this.btn_Empezar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Thistle;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(411, 62);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(557, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // img_Camara
            // 
            this.img_Camara.Location = new System.Drawing.Point(284, 122);
            this.img_Camara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.img_Camara.Name = "img_Camara";
            this.img_Camara.Size = new System.Drawing.Size(657, 414);
            this.img_Camara.TabIndex = 5;
            this.img_Camara.TabStop = false;
            // 
            // lbl_Contador
            // 
            this.lbl_Contador.AutoSize = true;
            this.lbl_Contador.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contador.Location = new System.Drawing.Point(547, 566);
            this.lbl_Contador.Name = "lbl_Contador";
            this.lbl_Contador.Size = new System.Drawing.Size(18, 18);
            this.lbl_Contador.TabIndex = 8;
            this.lbl_Contador.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(281, 566);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(948, 180);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // CerrarCamara
            // 
            this.CerrarCamara.BackColor = System.Drawing.Color.Thistle;
            this.CerrarCamara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarCamara.Font = new System.Drawing.Font("Verdana", 9F);
            this.CerrarCamara.ForeColor = System.Drawing.Color.Orange;
            this.CerrarCamara.Location = new System.Drawing.Point(217, 50);
            this.CerrarCamara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CerrarCamara.Name = "CerrarCamara";
            this.CerrarCamara.Padding = new System.Windows.Forms.Padding(1);
            this.CerrarCamara.Size = new System.Drawing.Size(163, 44);
            this.CerrarCamara.TabIndex = 43;
            this.CerrarCamara.Text = "Desactivar";
            this.CerrarCamara.UseVisualStyleBackColor = false;
            this.CerrarCamara.Click += new System.EventHandler(this.CerrarCamara_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 566);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "contador de personas";
            // 
            // Form_Camara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(1211, 593);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CerrarCamara);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Contador);
            this.Controls.Add(this.img_Camara);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_Empezar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Camara";
            this.Text = "Form_Camara";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Camara_FormClosed);
            this.Load += new System.EventHandler(this.Form_Camara_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Camara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Empezar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox img_Camara;
        private System.Windows.Forms.Label lbl_Contador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CerrarCamara;
        private System.Windows.Forms.Label label2;
    }
}