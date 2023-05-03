namespace controleestoque
{
    partial class recuperar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recuperar));
            txt_envemail = new TextBox();
            btn_recuperar = new Button();
            btn_fecharrecu = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txt_envemail
            // 
            txt_envemail.Location = new Point(45, 257);
            txt_envemail.Name = "txt_envemail";
            txt_envemail.Size = new Size(194, 27);
            txt_envemail.TabIndex = 0;
            // 
            // btn_recuperar
            // 
            btn_recuperar.BackColor = Color.Lime;
            btn_recuperar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_recuperar.Location = new Point(35, 336);
            btn_recuperar.Name = "btn_recuperar";
            btn_recuperar.Size = new Size(94, 29);
            btn_recuperar.TabIndex = 1;
            btn_recuperar.Text = "Recuperar";
            btn_recuperar.UseVisualStyleBackColor = false;
            btn_recuperar.Click += button1_Click;
            // 
            // btn_fecharrecu
            // 
            btn_fecharrecu.BackColor = Color.Red;
            btn_fecharrecu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_fecharrecu.ForeColor = SystemColors.ButtonFace;
            btn_fecharrecu.Location = new Point(145, 336);
            btn_fecharrecu.Name = "btn_fecharrecu";
            btn_fecharrecu.Size = new Size(94, 29);
            btn_fecharrecu.TabIndex = 2;
            btn_fecharrecu.Text = "Sair";
            btn_fecharrecu.UseVisualStyleBackColor = false;
            btn_fecharrecu.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.gmail;
            pictureBox1.Location = new Point(4, 254);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.ZKZx;
            pictureBox2.Location = new Point(75, 408);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // recuperar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(544, 517);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btn_fecharrecu);
            Controls.Add(btn_recuperar);
            Controls.Add(txt_envemail);
            FormBorderStyle = FormBorderStyle.None;
            Name = "recuperar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_envemail;
        private Button btn_recuperar;
        private Button btn_fecharrecu;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}