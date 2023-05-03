namespace controleestoque
{
    partial class formlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formlogin));
            btn_entrar = new Button();
            button2 = new Button();
            txt_name = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            linkLabel1 = new LinkLabel();
            txtmask = new MaskedTextBox();
            btn_cadastrarusuario = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_entrar
            // 
            resources.ApplyResources(btn_entrar, "btn_entrar");
            btn_entrar.BackColor = Color.Lime;
            btn_entrar.Name = "btn_entrar";
            btn_entrar.UseVisualStyleBackColor = false;
            btn_entrar.Click += button1_Click;
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.BackColor = Color.Red;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txt_name
            // 
            resources.ApplyResources(txt_name, "txt_name");
            txt_name.Name = "txt_name";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.icons8_usuário_50_removebg_preview;
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.icons8_senha_1_48;
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // linkLabel1
            // 
            resources.ApplyResources(linkLabel1, "linkLabel1");
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Name = "linkLabel1";
            linkLabel1.TabStop = true;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // txtmask
            // 
            resources.ApplyResources(txtmask, "txtmask");
            txtmask.Name = "txtmask";
            // 
            // btn_cadastrarusuario
            // 
            resources.ApplyResources(btn_cadastrarusuario, "btn_cadastrarusuario");
            btn_cadastrarusuario.BackColor = Color.Lime;
            btn_cadastrarusuario.Name = "btn_cadastrarusuario";
            btn_cadastrarusuario.UseVisualStyleBackColor = false;
            btn_cadastrarusuario.Click += btn_cadastrarusuario_Click_1;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.reconhecimento_de_olho;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // formlogin
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._20230325_220203_0000;
            Controls.Add(button1);
            Controls.Add(btn_cadastrarusuario);
            Controls.Add(txtmask);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txt_name);
            Controls.Add(button2);
            Controls.Add(btn_entrar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formlogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_entrar;
        private Button button2;
        private TextBox txt_name;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private LinkLabel linkLabel1;
        private MaskedTextBox txtmask;
        private Button btn_cadastrarusuario;
        private Button button1;
    }
}