namespace WFA1FPOrtegaEder
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblEncabezado = new Label();
            label1 = new Label();
            btnTotalTetra = new Button();
            btnNomina = new Button();
            btnParque = new Button();
            btnTotalAPagar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblEncabezado
            // 
            lblEncabezado.BackColor = Color.Transparent;
            lblEncabezado.Font = new Font("Century", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEncabezado.Location = new Point(264, 65);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(563, 177);
            lblEncabezado.TabIndex = 0;
            lblEncabezado.Text = "Fundamentos de Programación\r\nParcial 1 \r\nEder Ortega\r\n42188\r\n16/01/25\r\n\r\n\r\n";
            lblEncabezado.TextAlign = ContentAlignment.TopCenter;
            lblEncabezado.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(293, 245);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 1;
            label1.Click += label1_Click_1;
            // 
            // btnTotalTetra
            // 
            btnTotalTetra.BackColor = SystemColors.Highlight;
            btnTotalTetra.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTotalTetra.ForeColor = SystemColors.Info;
            btnTotalTetra.Location = new Point(182, 245);
            btnTotalTetra.Name = "btnTotalTetra";
            btnTotalTetra.Size = new Size(165, 68);
            btnTotalTetra.TabIndex = 2;
            btnTotalTetra.Text = "Total por tetramestre";
            btnTotalTetra.UseVisualStyleBackColor = false;
            btnTotalTetra.Click += btnTotalTetra_Click;
            // 
            // btnNomina
            // 
            btnNomina.BackColor = SystemColors.Highlight;
            btnNomina.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNomina.ForeColor = SystemColors.Info;
            btnNomina.Location = new Point(380, 245);
            btnNomina.Name = "btnNomina";
            btnNomina.Size = new Size(165, 68);
            btnNomina.TabIndex = 6;
            btnNomina.Text = "Nómina";
            btnNomina.UseVisualStyleBackColor = false;
            btnNomina.Click += button1_Click_1;
            // 
            // btnParque
            // 
            btnParque.BackColor = SystemColors.Highlight;
            btnParque.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnParque.ForeColor = SystemColors.Info;
            btnParque.Location = new Point(581, 245);
            btnParque.Name = "btnParque";
            btnParque.Size = new Size(165, 68);
            btnParque.TabIndex = 7;
            btnParque.Text = "Parque";
            btnParque.UseVisualStyleBackColor = false;
            btnParque.Click += btnEj2Parqu_Click;
            // 
            // btnTotalAPagar
            // 
            btnTotalAPagar.BackColor = SystemColors.Highlight;
            btnTotalAPagar.Font = new Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTotalAPagar.ForeColor = SystemColors.Info;
            btnTotalAPagar.Location = new Point(779, 245);
            btnTotalAPagar.Name = "btnTotalAPagar";
            btnTotalAPagar.Size = new Size(165, 68);
            btnTotalAPagar.TabIndex = 8;
            btnTotalAPagar.Text = "Total a pagar";
            btnTotalAPagar.UseVisualStyleBackColor = false;
            btnTotalAPagar.Click += btnTotalAPagar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.LightCoral;
            btnSalir.Font = new Font("Century", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.Info;
            btnSalir.Location = new Point(182, 557);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(133, 73);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir ";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1178, 744);
            Controls.Add(btnSalir);
            Controls.Add(btnTotalAPagar);
            Controls.Add(btnParque);
            Controls.Add(btnNomina);
            Controls.Add(btnTotalTetra);
            Controls.Add(label1);
            Controls.Add(lblEncabezado);
            Name = "FrmPrincipal";
            Text = "Principal";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEncabezado;
        private Label label1;
        private Button btnTotalTetra;
        private Button btnNomina;
        private Button btnParque;
        private Button btnTotalAPagar;
        private Button btnSalir;
    }
}
