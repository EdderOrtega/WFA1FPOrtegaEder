﻿namespace WFA1FPOrtegaEder
{
    partial class FrmEjTotalTetra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEjTotalTetra));
            btnCalcular = new Button();
            btnRegresar = new Button();
            lblInicial = new Label();
            txtInicial = new TextBox();
            btnLimpiar = new Button();
            lblTitulo = new Label();
            lblMensualidad = new Label();
            txtMensualidad = new TextBox();
            lblLicencias = new Label();
            txtLicencias = new TextBox();
            lblLibros = new Label();
            txtLibros = new TextBox();
            lblEstacionamiento = new Label();
            txtEstacionamiento = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.SteelBlue;
            btnCalcular.ForeColor = SystemColors.Info;
            btnCalcular.Location = new Point(811, 544);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 34);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.IndianRed;
            btnRegresar.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = SystemColors.Info;
            btnRegresar.Location = new Point(30, 544);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(218, 71);
            btnRegresar.TabIndex = 1;
            btnRegresar.Text = "Regresar al \r\nmenú principal";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lblInicial
            // 
            lblInicial.AutoSize = true;
            lblInicial.Location = new Point(30, 277);
            lblInicial.Name = "lblInicial";
            lblInicial.Size = new Size(101, 25);
            lblInicial.TabIndex = 2;
            lblInicial.Text = "Pago Inicial";
            // 
            // txtInicial
            // 
            txtInicial.Location = new Point(30, 333);
            txtInicial.Name = "txtInicial";
            txtInicial.Size = new Size(150, 31);
            txtInicial.TabIndex = 3;
            txtInicial.TextChanged += txtInicial_TextChanged;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(616, 544);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 34);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Nuevo";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(416, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(312, 84);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Total por tetramestre \r\nEder Ortega \r\nEjercicio1 20 Enero 2025";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            lblTitulo.Click += lblTitulo_Click;
            // 
            // lblMensualidad
            // 
            lblMensualidad.AutoSize = true;
            lblMensualidad.Location = new Point(246, 277);
            lblMensualidad.Name = "lblMensualidad";
            lblMensualidad.Size = new Size(113, 25);
            lblMensualidad.TabIndex = 6;
            lblMensualidad.Text = "Mensualidad";
            // 
            // txtMensualidad
            // 
            txtMensualidad.Location = new Point(246, 333);
            txtMensualidad.Name = "txtMensualidad";
            txtMensualidad.Size = new Size(150, 31);
            txtMensualidad.TabIndex = 7;
            // 
            // lblLicencias
            // 
            lblLicencias.AutoSize = true;
            lblLicencias.Location = new Point(453, 277);
            lblLicencias.Name = "lblLicencias";
            lblLicencias.Size = new Size(80, 25);
            lblLicencias.TabIndex = 8;
            lblLicencias.Text = "Licencias";
            lblLicencias.TextAlign = ContentAlignment.TopCenter;
            lblLicencias.Click += label1_Click;
            // 
            // txtLicencias
            // 
            txtLicencias.Location = new Point(453, 333);
            txtLicencias.Name = "txtLicencias";
            txtLicencias.Size = new Size(150, 31);
            txtLicencias.TabIndex = 9;
            // 
            // lblLibros
            // 
            lblLibros.AutoSize = true;
            lblLibros.Location = new Point(649, 277);
            lblLibros.Name = "lblLibros";
            lblLibros.Size = new Size(60, 25);
            lblLibros.TabIndex = 10;
            lblLibros.Text = "Libros";
            // 
            // txtLibros
            // 
            txtLibros.Location = new Point(649, 333);
            txtLibros.Name = "txtLibros";
            txtLibros.Size = new Size(150, 31);
            txtLibros.TabIndex = 11;
            // 
            // lblEstacionamiento
            // 
            lblEstacionamiento.AutoSize = true;
            lblEstacionamiento.Location = new Point(844, 277);
            lblEstacionamiento.Name = "lblEstacionamiento";
            lblEstacionamiento.Size = new Size(142, 25);
            lblEstacionamiento.TabIndex = 12;
            lblEstacionamiento.Text = "Estacionamiento";
            // 
            // txtEstacionamiento
            // 
            txtEstacionamiento.Location = new Point(844, 333);
            txtEstacionamiento.Name = "txtEstacionamiento";
            txtEstacionamiento.Size = new Size(150, 31);
            txtEstacionamiento.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.uni_norte;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(30, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 81);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // FrmEjTotalTetra
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1141, 674);
            Controls.Add(pictureBox1);
            Controls.Add(txtEstacionamiento);
            Controls.Add(lblEstacionamiento);
            Controls.Add(txtLibros);
            Controls.Add(lblLibros);
            Controls.Add(txtLicencias);
            Controls.Add(lblLicencias);
            Controls.Add(txtMensualidad);
            Controls.Add(lblMensualidad);
            Controls.Add(lblTitulo);
            Controls.Add(btnLimpiar);
            Controls.Add(txtInicial);
            Controls.Add(lblInicial);
            Controls.Add(btnRegresar);
            Controls.Add(btnCalcular);
            Name = "FrmEjTotalTetra";
            Text = "FrmEjTotalTetra";
            Load += FrmEjTotalTetra_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Button btnRegresar;
        private Label lblInicial;
        private TextBox txtInicial;
        private Button btnLimpiar;
        private Label lblTitulo;
        private Label lblMensualidad;
        private TextBox txtMensualidad;
        private Label lblLicencias;
        private TextBox txtLicencias;
        private Label lblLibros;
        private TextBox txtLibros;
        private Label lblEstacionamiento;
        private TextBox txtEstacionamiento;
        private PictureBox pictureBox1;
    }
}