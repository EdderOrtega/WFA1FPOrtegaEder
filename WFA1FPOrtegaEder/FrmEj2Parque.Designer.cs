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
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.IndianRed;
            btnRegresar.ForeColor = SystemColors.Info;
            btnRegresar.Location = new Point(67, 357);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(234, 34);
            btnRegresar.TabIndex = 0;
            btnRegresar.Text = "Regresar al menu principal";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // FrmEj2Parque
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegresar);
            Name = "FrmEj2Parque";
            Text = "FrmEj2Parque";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegresar;
    }
}