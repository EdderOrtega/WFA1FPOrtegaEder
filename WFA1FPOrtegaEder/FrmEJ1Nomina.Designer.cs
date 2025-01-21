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
            btnregresar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnregresar
            // 
            btnregresar.BackColor = Color.IndianRed;
            btnregresar.ForeColor = SystemColors.Info;
            btnregresar.Location = new Point(102, 371);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new Size(180, 34);
            btnregresar.TabIndex = 0;
            btnregresar.Text = "Regresar al menu principal";
            btnregresar.UseVisualStyleBackColor = false;
            btnregresar.Click += btnregresar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._1b3439272614867efae272ed60b08697;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(543, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 189);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FrmEJ1Nomina
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnregresar);
            Name = "FrmEJ1Nomina";
            Text = "FrmEJ1Nomina";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnregresar;
        private PictureBox pictureBox1;
    }
}