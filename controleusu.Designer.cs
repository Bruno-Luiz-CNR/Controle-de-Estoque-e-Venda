namespace controleestoque
{
    partial class controleusu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controleusu));
            dataGridView1 = new DataGridView();
            txt_nomusu = new TextBox();
            com_cred = new ComboBox();
            btn_alterar = new Button();
            btn_excluir = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 142);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(316, 206);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txt_nomusu
            // 
            txt_nomusu.Enabled = false;
            txt_nomusu.Location = new Point(3, 354);
            txt_nomusu.Name = "txt_nomusu";
            txt_nomusu.Size = new Size(181, 27);
            txt_nomusu.TabIndex = 1;
            // 
            // com_cred
            // 
            com_cred.FormattingEnabled = true;
            com_cred.Items.AddRange(new object[] { "", "adm", "usu" });
            com_cred.Location = new Point(221, 353);
            com_cred.Name = "com_cred";
            com_cred.Size = new Size(98, 28);
            com_cred.TabIndex = 2;
            // 
            // btn_alterar
            // 
            btn_alterar.BackColor = Color.Lime;
            btn_alterar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_alterar.Location = new Point(105, 421);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(94, 29);
            btn_alterar.TabIndex = 3;
            btn_alterar.Text = "Alterar";
            btn_alterar.UseVisualStyleBackColor = false;
            btn_alterar.Click += btn_alterar_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.BackColor = Color.Red;
            btn_excluir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_excluir.ForeColor = SystemColors.Control;
            btn_excluir.Location = new Point(215, 421);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(94, 29);
            btn_excluir.TabIndex = 4;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = false;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(215, 461);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // controleusu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.lateral;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(321, 493);
            Controls.Add(button1);
            Controls.Add(btn_excluir);
            Controls.Add(btn_alterar);
            Controls.Add(com_cred);
            Controls.Add(txt_nomusu);
            Controls.Add(dataGridView1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "controleusu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Configuração de Usuário";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txt_nomusu;
        private ComboBox com_cred;
        private Button btn_alterar;
        private Button btn_excluir;
        private Button button1;
    }
}