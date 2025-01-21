namespace WFA1FPOrtegaEder
{
    partial class FrmEj3TotalPagar
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
            btnRegresar.Location = new Point(74, 374);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(178, 34);
            btnRegresar.TabIndex = 0;
            btnRegresar.Text = "Regresar al menu Principal";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // FrmEj3TotalPagar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegresar);
            Name = "FrmEj3TotalPagar";
            Text = "FrmEj3TotalPagar";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegresar;
    }
}