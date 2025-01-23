namespace WFA1FPOrtegaEder
{
    partial class FrmEJ1Nomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEJ1Nomina));
            btnregresar = new Button();
            pictureBox1 = new PictureBox();
            lblSueldoDiario = new Label();
            listNomina = new ListBox();
            txtSueldoDiario = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnregresar
            // 
            btnregresar.BackColor = Color.IndianRed;
            btnregresar.Font = new Font("Centaur", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnregresar.ForeColor = SystemColors.Info;
            btnregresar.Location = new Point(867, 632);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new Size(285, 54);
            btnregresar.TabIndex = 0;
            btnregresar.Text = "Regresar al menu principal";
            btnregresar.UseVisualStyleBackColor = false;
            btnregresar.Click += btnregresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(616, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(536, 232);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblSueldoDiario
            // 
            lblSueldoDiario.AutoSize = true;
            lblSueldoDiario.BackColor = Color.DarkCyan;
            lblSueldoDiario.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSueldoDiario.ForeColor = SystemColors.Info;
            lblSueldoDiario.Location = new Point(41, 27);
            lblSueldoDiario.Name = "lblSueldoDiario";
            lblSueldoDiario.Size = new Size(174, 28);
            lblSueldoDiario.TabIndex = 2;
            lblSueldoDiario.Text = "Sueldo diario";
            lblSueldoDiario.Click += lblSueldoDiario_Click;
            // 
            // listNomina
            // 
            listNomina.FormattingEnabled = true;
            listNomina.Location = new Point(41, 132);
            listNomina.Name = "listNomina";
            listNomina.Size = new Size(512, 554);
            listNomina.TabIndex = 3;
            // 
            // txtSueldoDiario
            // 
            txtSueldoDiario.Location = new Point(41, 73);
            txtSueldoDiario.Name = "txtSueldoDiario";
            txtSueldoDiario.PlaceholderText = "Ingresa tu sueldo diario";
            txtSueldoDiario.Size = new Size(209, 31);
            txtSueldoDiario.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.DarkSlateGray;
            btnCalcular.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = SystemColors.Info;
            btnCalcular.Location = new Point(790, 347);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(173, 46);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Century", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(790, 475);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(173, 47);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Nuevo";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FrmEJ1Nomina
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1178, 744);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtSueldoDiario);
            Controls.Add(listNomina);
            Controls.Add(lblSueldoDiario);
            Controls.Add(pictureBox1);
            Controls.Add(btnregresar);
            Name = "FrmEJ1Nomina";
            Text = "FrmEJ1Nomina";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnregresar;
        private PictureBox pictureBox1;
        private Label lblSueldoDiario;
        private ListBox listNomina;
        private TextBox txtSueldoDiario;
        private Button btnCalcular;
        private Button btnLimpiar;
    }
}