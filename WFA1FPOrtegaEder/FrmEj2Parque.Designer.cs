namespace WFA1FPOrtegaEder
{
    partial class FrmEj2Parque
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
            btnRegresar = new Button();
            lblb1 = new Label();
            txtb1 = new TextBox();
            txtb2 = new TextBox();
            lblb2 = new Label();
            txtb3 = new TextBox();
            lblb3 = new Label();
            btnCalcular = new Button();
            btnNuevo = new Button();
            listResultado = new ListBox();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.IndianRed;
            btnRegresar.Font = new Font("Century", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.ForeColor = SystemColors.Info;
            btnRegresar.Location = new Point(904, 580);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(195, 98);
            btnRegresar.TabIndex = 0;
            btnRegresar.Text = "Regresar al menu principal";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // lblb1
            // 
            lblb1.AutoSize = true;
            lblb1.BackColor = Color.DarkGreen;
            lblb1.Font = new Font("Century", 12F, FontStyle.Bold);
            lblb1.ForeColor = SystemColors.Info;
            lblb1.Location = new Point(91, 100);
            lblb1.Name = "lblb1";
            lblb1.Size = new Size(177, 28);
            lblb1.TabIndex = 1;
            lblb1.Text = "Boletos tipo 1";
            // 
            // txtb1
            // 
            txtb1.Location = new Point(91, 161);
            txtb1.Name = "txtb1";
            txtb1.Size = new Size(177, 31);
            txtb1.TabIndex = 2;
            // 
            // txtb2
            // 
            txtb2.Location = new Point(340, 161);
            txtb2.Name = "txtb2";
            txtb2.Size = new Size(177, 31);
            txtb2.TabIndex = 4;
            // 
            // lblb2
            // 
            lblb2.AutoSize = true;
            lblb2.BackColor = Color.DarkGreen;
            lblb2.Font = new Font("Century", 12F, FontStyle.Bold);
            lblb2.ForeColor = SystemColors.Info;
            lblb2.Location = new Point(340, 100);
            lblb2.Name = "lblb2";
            lblb2.Size = new Size(177, 28);
            lblb2.TabIndex = 3;
            lblb2.Text = "Boletos tipo 2";
            // 
            // txtb3
            // 
            txtb3.Location = new Point(593, 161);
            txtb3.Name = "txtb3";
            txtb3.Size = new Size(177, 31);
            txtb3.TabIndex = 6;
            // 
            // lblb3
            // 
            lblb3.AutoSize = true;
            lblb3.BackColor = Color.DarkGreen;
            lblb3.Font = new Font("Century", 12F, FontStyle.Bold);
            lblb3.ForeColor = SystemColors.Info;
            lblb3.Location = new Point(593, 100);
            lblb3.Name = "lblb3";
            lblb3.Size = new Size(177, 28);
            lblb3.TabIndex = 5;
            lblb3.Text = "Boletos tipo 3";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.SaddleBrown;
            btnCalcular.Font = new Font("Century", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = SystemColors.Info;
            btnCalcular.Location = new Point(904, 270);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(195, 76);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.DarkOrange;
            btnNuevo.Font = new Font("Century", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.ForeColor = SystemColors.Info;
            btnNuevo.Location = new Point(904, 415);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(195, 73);
            btnNuevo.TabIndex = 8;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // listResultado
            // 
            listResultado.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listResultado.FormattingEnabled = true;
            listResultado.Location = new Point(91, 270);
            listResultado.Name = "listResultado";
            listResultado.Size = new Size(512, 424);
            listResultado.TabIndex = 9;
            // 
            // FrmEj2Parque
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1178, 744);
            Controls.Add(listResultado);
            Controls.Add(btnNuevo);
            Controls.Add(btnCalcular);
            Controls.Add(txtb3);
            Controls.Add(lblb3);
            Controls.Add(txtb2);
            Controls.Add(lblb2);
            Controls.Add(txtb1);
            Controls.Add(lblb1);
            Controls.Add(btnRegresar);
            Name = "FrmEj2Parque";
            Text = "FrmEj2Parque";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresar;
        private Label lblb1;
        private TextBox txtb1;
        private TextBox txtb2;
        private Label lblb2;
        private TextBox txtb3;
        private Label lblb3;
        private Button btnCalcular;
        private Button btnNuevo;
        private ListBox listResultado;
    }
}