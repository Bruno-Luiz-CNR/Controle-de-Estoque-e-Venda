namespace controleestoque
{
    partial class cadastro
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
            txt_caduser = new TextBox();
            txt_emailuser = new TextBox();
            button1 = new Button();
            button2 = new Button();
            masksenhauser = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btn_versenha = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txt_caduser
            // 
            txt_caduser.Location = new Point(293, 228);
            txt_caduser.Name = "txt_caduser";
            txt_caduser.Size = new Size(196, 27);
            txt_caduser.TabIndex = 0;
            // 
            // txt_emailuser
            // 
            txt_emailuser.Location = new Point(293, 310);
            txt_emailuser.Name = "txt_emailuser";
            txt_emailuser.Size = new Size(196, 27);
            txt_emailuser.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(312, 362);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(414, 362);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // masksenhauser
            // 
            masksenhauser.Location = new Point(293, 268);
            masksenhauser.Name = "masksenhauser";
            masksenhauser.Size = new Size(196, 27);
            masksenhauser.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.icons8_usuário_50_removebg_preview;
            pictureBox1.Location = new Point(249, 223);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.icons8_senha_1_48;
            pictureBox2.Location = new Point(248, 266);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(39, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.gmail;
            pictureBox3.Location = new Point(249, 308);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // btn_versenha
            // 
            btn_versenha.BackColor = Color.Transparent;
            btn_versenha.BackgroundImage = Properties.Resources.reconhecimento_de_olho;
            btn_versenha.BackgroundImageLayout = ImageLayout.Stretch;
            btn_versenha.Location = new Point(492, 266);
            btn_versenha.Name = "btn_versenha";
            btn_versenha.Size = new Size(26, 30);
            btn_versenha.TabIndex = 9;
            btn_versenha.UseVisualStyleBackColor = false;
            btn_versenha.Click += btn_versenha_Click;
            // 
            // cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._20230325_220203_0000;
            ClientSize = new Size(520, 472);
            Controls.Add(btn_versenha);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(masksenhauser);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt_emailuser);
            Controls.Add(txt_caduser);
            FormBorderStyle = FormBorderStyle.None;
            Name = "cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "cadastro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_caduser;
        private TextBox txt_emailuser;
        private Button button1;
        private Button button2;
        private MaskedTextBox masksenhauser;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btn_versenha;
    }
}