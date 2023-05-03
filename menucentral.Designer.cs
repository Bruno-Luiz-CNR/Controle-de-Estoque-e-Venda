namespace controleestoque
{
    partial class menucentral
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menucentral));
            btn_menuside = new Button();
            toolTip1 = new ToolTip(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            txt_valortotal = new Label();
            label2 = new Label();
            txt_pesquisar = new TextBox();
            btn_pesquisar = new Button();
            txt_valpro = new MaskedTextBox();
            dataGridView1 = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txt_quantpro = new TextBox();
            txt_codbar = new TextBox();
            textBox2 = new TextBox();
            txt_nompro = new TextBox();
            tabPage3 = new TabPage();
            btn_desconto = new Button();
            label5 = new Label();
            txt_desconto = new TextBox();
            txt_valtotven = new Label();
            txt_excluirvenda = new Button();
            btn_vender = new Button();
            txt_codbarvenda = new TextBox();
            txt_valvenda = new MaskedTextBox();
            txt_idvenda = new TextBox();
            btn_adcvenda = new Button();
            txt_qtdvenda = new TextBox();
            txt_adcnomvenda = new TextBox();
            txt_pesvenda = new TextBox();
            btn_pesvenda = new Button();
            dataGridView3 = new DataGridView();
            dataGridView2 = new DataGridView();
            tabPage4 = new TabPage();
            maskdatfim2 = new DateTimePicker();
            cmskdatini2 = new DateTimePicker();
            txt_valtotrel = new Label();
            label4 = new Label();
            label3 = new Label();
            btn_pesqrel = new Button();
            dataGridView4 = new DataGridView();
            btn_cadastrar = new Button();
            btn_relatorio = new Button();
            btn_configuracao = new Button();
            btn_vendadeprodutos = new Button();
            btn_sair = new Button();
            txt_usuario = new Label();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pictureBox2 = new PictureBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_menuside
            // 
            btn_menuside.BackColor = Color.Lime;
            btn_menuside.Location = new Point(472, 151);
            btn_menuside.Name = "btn_menuside";
            btn_menuside.Size = new Size(101, 29);
            btn_menuside.TabIndex = 2;
            btn_menuside.Text = "Menu";
            btn_menuside.UseVisualStyleBackColor = false;
            btn_menuside.Click += btn_menuside_Click;
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.ImeMode = ImeMode.NoControl;
            tabControl1.Location = new Point(0, 192);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(913, 530);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(905, 497);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.vend;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(899, 491);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = Properties.Resources.backpages;
            tabPage2.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage2.Controls.Add(txt_valortotal);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(txt_pesquisar);
            tabPage2.Controls.Add(btn_pesquisar);
            tabPage2.Controls.Add(txt_valpro);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(txt_quantpro);
            tabPage2.Controls.Add(txt_codbar);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(txt_nompro);
            tabPage2.Location = new Point(4, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(905, 497);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cadastro";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // txt_valortotal
            // 
            txt_valortotal.AutoSize = true;
            txt_valortotal.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txt_valortotal.Location = new Point(631, 470);
            txt_valortotal.Name = "txt_valortotal";
            txt_valortotal.Size = new Size(42, 20);
            txt_valortotal.TabIndex = 14;
            txt_valortotal.Text = "123";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(800, 17);
            label2.Name = "label2";
            label2.Size = new Size(39, 25);
            label2.TabIndex = 12;
            label2.Text = "R$:";
            // 
            // txt_pesquisar
            // 
            txt_pesquisar.Location = new Point(72, 68);
            txt_pesquisar.Name = "txt_pesquisar";
            txt_pesquisar.PlaceholderText = "PESQUISAR MERCADORIA";
            txt_pesquisar.Size = new Size(242, 27);
            txt_pesquisar.TabIndex = 5;
            txt_pesquisar.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_pesquisar
            // 
            btn_pesquisar.BackgroundImage = Properties.Resources.documento;
            btn_pesquisar.BackgroundImageLayout = ImageLayout.Zoom;
            btn_pesquisar.ForeColor = Color.Transparent;
            btn_pesquisar.Location = new Point(320, 62);
            btn_pesquisar.Name = "btn_pesquisar";
            btn_pesquisar.Size = new Size(46, 38);
            btn_pesquisar.TabIndex = 6;
            btn_pesquisar.UseVisualStyleBackColor = true;
            btn_pesquisar.Click += btn_pesquisar_Click;
            // 
            // txt_valpro
            // 
            txt_valpro.Location = new Point(840, 18);
            txt_valpro.Mask = "000.00";
            txt_valpro.Name = "txt_valpro";
            txt_valpro.Size = new Size(50, 27);
            txt_valpro.TabIndex = 4;
            txt_valpro.ValidatingType = typeof(int);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = "????";
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.GridColor = SystemColors.ActiveCaption;
            dataGridView1.Location = new Point(52, 106);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(798, 358);
            dataGridView1.TabIndex = 8;
            dataGridView1.ReadOnlyChanged += dataGridView1_ReadOnlyChanged;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button3
            // 
            button3.Location = new Point(736, 69);
            button3.Name = "button3";
            button3.Size = new Size(94, 31);
            button3.TabIndex = 9;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(636, 69);
            button2.Name = "button2";
            button2.Size = new Size(94, 31);
            button2.TabIndex = 8;
            button2.Text = "Alterar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(536, 69);
            button1.Name = "button1";
            button1.Size = new Size(94, 31);
            button1.TabIndex = 7;
            button1.Text = "Inseir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txt_quantpro
            // 
            txt_quantpro.Location = new Point(702, 18);
            txt_quantpro.Name = "txt_quantpro";
            txt_quantpro.PlaceholderText = "Quantidade";
            txt_quantpro.Size = new Size(92, 27);
            txt_quantpro.TabIndex = 3;
            txt_quantpro.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_codbar
            // 
            txt_codbar.Location = new Point(110, 18);
            txt_codbar.Name = "txt_codbar";
            txt_codbar.PlaceholderText = "Código de Barras";
            txt_codbar.Size = new Size(157, 27);
            txt_codbar.TabIndex = 1;
            txt_codbar.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(33, 18);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(71, 27);
            textBox2.TabIndex = 1;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // txt_nompro
            // 
            txt_nompro.Location = new Point(273, 18);
            txt_nompro.Name = "txt_nompro";
            txt_nompro.PlaceholderText = "Nome";
            txt_nompro.Size = new Size(423, 27);
            txt_nompro.TabIndex = 2;
            txt_nompro.TextAlign = HorizontalAlignment.Center;
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = Properties.Resources.backpages;
            tabPage3.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage3.Controls.Add(btn_desconto);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(txt_desconto);
            tabPage3.Controls.Add(txt_valtotven);
            tabPage3.Controls.Add(txt_excluirvenda);
            tabPage3.Controls.Add(btn_vender);
            tabPage3.Controls.Add(txt_codbarvenda);
            tabPage3.Controls.Add(txt_valvenda);
            tabPage3.Controls.Add(txt_idvenda);
            tabPage3.Controls.Add(btn_adcvenda);
            tabPage3.Controls.Add(txt_qtdvenda);
            tabPage3.Controls.Add(txt_adcnomvenda);
            tabPage3.Controls.Add(txt_pesvenda);
            tabPage3.Controls.Add(btn_pesvenda);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Location = new Point(4, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(905, 497);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Venda";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btn_desconto
            // 
            btn_desconto.Location = new Point(462, 466);
            btn_desconto.Name = "btn_desconto";
            btn_desconto.Size = new Size(94, 29);
            btn_desconto.TabIndex = 18;
            btn_desconto.Text = "Desconto";
            btn_desconto.UseVisualStyleBackColor = true;
            btn_desconto.Click += btn_desconto_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(270, 469);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 17;
            label5.Text = "Desconto %:";
            // 
            // txt_desconto
            // 
            txt_desconto.Location = new Point(398, 467);
            txt_desconto.Name = "txt_desconto";
            txt_desconto.PlaceholderText = "0";
            txt_desconto.Size = new Size(54, 27);
            txt_desconto.TabIndex = 16;
            txt_desconto.Text = "0";
            // 
            // txt_valtotven
            // 
            txt_valtotven.AutoSize = true;
            txt_valtotven.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txt_valtotven.Location = new Point(583, 469);
            txt_valtotven.Name = "txt_valtotven";
            txt_valtotven.Size = new Size(133, 20);
            txt_valtotven.TabIndex = 15;
            txt_valtotven.Text = "Valor Venda: ";
            // 
            // txt_excluirvenda
            // 
            txt_excluirvenda.BackColor = Color.Red;
            txt_excluirvenda.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txt_excluirvenda.ForeColor = SystemColors.ButtonHighlight;
            txt_excluirvenda.Location = new Point(815, 436);
            txt_excluirvenda.Name = "txt_excluirvenda";
            txt_excluirvenda.Size = new Size(81, 29);
            txt_excluirvenda.TabIndex = 11;
            txt_excluirvenda.Text = "Excluir";
            txt_excluirvenda.UseVisualStyleBackColor = false;
            txt_excluirvenda.Click += txt_excluirvenda_Click_1;
            // 
            // btn_vender
            // 
            btn_vender.BackColor = Color.Lime;
            btn_vender.Location = new Point(815, 401);
            btn_vender.Name = "btn_vender";
            btn_vender.Size = new Size(81, 29);
            btn_vender.TabIndex = 10;
            btn_vender.Text = "Vender";
            btn_vender.UseVisualStyleBackColor = false;
            btn_vender.Click += btn_vender_Click;
            // 
            // txt_codbarvenda
            // 
            txt_codbarvenda.Enabled = false;
            txt_codbarvenda.Location = new Point(86, 245);
            txt_codbarvenda.Name = "txt_codbarvenda";
            txt_codbarvenda.Size = new Size(118, 27);
            txt_codbarvenda.TabIndex = 9;
            // 
            // txt_valvenda
            // 
            txt_valvenda.Enabled = false;
            txt_valvenda.Location = new Point(667, 245);
            txt_valvenda.Mask = "000.00";
            txt_valvenda.Name = "txt_valvenda";
            txt_valvenda.Size = new Size(47, 27);
            txt_valvenda.TabIndex = 8;
            // 
            // txt_idvenda
            // 
            txt_idvenda.Enabled = false;
            txt_idvenda.Location = new Point(37, 245);
            txt_idvenda.Name = "txt_idvenda";
            txt_idvenda.Size = new Size(45, 27);
            txt_idvenda.TabIndex = 7;
            txt_idvenda.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_adcvenda
            // 
            btn_adcvenda.BackColor = Color.Lime;
            btn_adcvenda.Location = new Point(718, 244);
            btn_adcvenda.Name = "btn_adcvenda";
            btn_adcvenda.Size = new Size(94, 29);
            btn_adcvenda.TabIndex = 6;
            btn_adcvenda.Text = "Adicionar";
            btn_adcvenda.UseVisualStyleBackColor = false;
            btn_adcvenda.Click += btn_adcvenda_Click;
            // 
            // txt_qtdvenda
            // 
            txt_qtdvenda.Location = new Point(579, 245);
            txt_qtdvenda.Name = "txt_qtdvenda";
            txt_qtdvenda.Size = new Size(84, 27);
            txt_qtdvenda.TabIndex = 5;
            // 
            // txt_adcnomvenda
            // 
            txt_adcnomvenda.Enabled = false;
            txt_adcnomvenda.Location = new Point(207, 245);
            txt_adcnomvenda.Name = "txt_adcnomvenda";
            txt_adcnomvenda.Size = new Size(366, 27);
            txt_adcnomvenda.TabIndex = 4;
            // 
            // txt_pesvenda
            // 
            txt_pesvenda.Location = new Point(382, 9);
            txt_pesvenda.Name = "txt_pesvenda";
            txt_pesvenda.Size = new Size(380, 27);
            txt_pesvenda.TabIndex = 3;
            // 
            // btn_pesvenda
            // 
            btn_pesvenda.BackgroundImage = Properties.Resources.documento;
            btn_pesvenda.BackgroundImageLayout = ImageLayout.Stretch;
            btn_pesvenda.Location = new Point(768, 3);
            btn_pesvenda.Name = "btn_pesvenda";
            btn_pesvenda.Size = new Size(44, 35);
            btn_pesvenda.TabIndex = 2;
            btn_pesvenda.Text = "]";
            btn_pesvenda.UseVisualStyleBackColor = true;
            btn_pesvenda.Click += btn_pesvenda_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(36, 277);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.ReadOnly = true;
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.Size = new Size(776, 188);
            dataGridView3.TabIndex = 1;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.ColumnHeadersHeight = 29;
            dataGridView2.Location = new Point(36, 40);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(776, 188);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // tabPage4
            // 
            tabPage4.BackgroundImage = Properties.Resources.backpages;
            tabPage4.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage4.Controls.Add(maskdatfim2);
            tabPage4.Controls.Add(cmskdatini2);
            tabPage4.Controls.Add(txt_valtotrel);
            tabPage4.Controls.Add(label4);
            tabPage4.Controls.Add(label3);
            tabPage4.Controls.Add(btn_pesqrel);
            tabPage4.Controls.Add(dataGridView4);
            tabPage4.Location = new Point(4, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(905, 497);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Relatório";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // maskdatfim2
            // 
            maskdatfim2.CustomFormat = "";
            maskdatfim2.Format = DateTimePickerFormat.Custom;
            maskdatfim2.Location = new Point(631, 28);
            maskdatfim2.Name = "maskdatfim2";
            maskdatfim2.Size = new Size(101, 27);
            maskdatfim2.TabIndex = 15;
            maskdatfim2.Value = new DateTime(2023, 4, 5, 0, 0, 0, 0);
            // 
            // cmskdatini2
            // 
            cmskdatini2.CustomFormat = "";
            cmskdatini2.Format = DateTimePickerFormat.Custom;
            cmskdatini2.Location = new Point(524, 28);
            cmskdatini2.Name = "cmskdatini2";
            cmskdatini2.Size = new Size(101, 27);
            cmskdatini2.TabIndex = 14;
            cmskdatini2.Value = new DateTime(2023, 4, 5, 0, 0, 0, 0);
            // 
            // txt_valtotrel
            // 
            txt_valtotrel.AutoSize = true;
            txt_valtotrel.BackColor = Color.Transparent;
            txt_valtotrel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt_valtotrel.Location = new Point(562, 452);
            txt_valtotrel.Name = "txt_valtotrel";
            txt_valtotrel.Size = new Size(124, 28);
            txt_valtotrel.TabIndex = 13;
            txt_valtotrel.Text = "Valor Total :";
            txt_valtotrel.Click += txt_valtotrel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(642, 5);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 12;
            label4.Text = "Data Final";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(530, 5);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 11;
            label3.Text = "Data Inicial";
            label3.Click += label3_Click;
            // 
            // btn_pesqrel
            // 
            btn_pesqrel.BackgroundImageLayout = ImageLayout.Stretch;
            btn_pesqrel.ImageAlign = ContentAlignment.MiddleLeft;
            btn_pesqrel.Location = new Point(757, 26);
            btn_pesqrel.Name = "btn_pesqrel";
            btn_pesqrel.Size = new Size(94, 29);
            btn_pesqrel.TabIndex = 8;
            btn_pesqrel.Text = "Pesquisar";
            btn_pesqrel.TextAlign = ContentAlignment.MiddleRight;
            btn_pesqrel.UseVisualStyleBackColor = true;
            btn_pesqrel.Click += btn_pesqrel_Click;
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToDeleteRows = false;
            dataGridView4.AllowUserToResizeColumns = false;
            dataGridView4.AllowUserToResizeRows = false;
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(47, 61);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.ReadOnly = true;
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.RowTemplate.Height = 29;
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.Size = new Size(804, 378);
            dataGridView4.TabIndex = 1;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.BackgroundImageLayout = ImageLayout.Zoom;
            btn_cadastrar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cadastrar.Image = (Image)resources.GetObject("btn_cadastrar.Image");
            btn_cadastrar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cadastrar.Location = new Point(969, 334);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(213, 57);
            btn_cadastrar.TabIndex = 4;
            btn_cadastrar.Text = "Cadastrar Produto";
            btn_cadastrar.TextAlign = ContentAlignment.MiddleRight;
            btn_cadastrar.UseVisualStyleBackColor = false;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // btn_relatorio
            // 
            btn_relatorio.BackgroundImageLayout = ImageLayout.Zoom;
            btn_relatorio.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_relatorio.Image = (Image)resources.GetObject("btn_relatorio.Image");
            btn_relatorio.ImageAlign = ContentAlignment.MiddleLeft;
            btn_relatorio.Location = new Point(969, 475);
            btn_relatorio.Name = "btn_relatorio";
            btn_relatorio.Size = new Size(213, 54);
            btn_relatorio.TabIndex = 7;
            btn_relatorio.Text = "    Relátorio";
            btn_relatorio.UseVisualStyleBackColor = false;
            btn_relatorio.Click += btn_relatorio_Click;
            // 
            // btn_configuracao
            // 
            btn_configuracao.BackgroundImageLayout = ImageLayout.Zoom;
            btn_configuracao.Image = Properties.Resources.configusu;
            btn_configuracao.ImageAlign = ContentAlignment.MiddleLeft;
            btn_configuracao.Location = new Point(1007, 584);
            btn_configuracao.Name = "btn_configuracao";
            btn_configuracao.Size = new Size(157, 43);
            btn_configuracao.TabIndex = 6;
            btn_configuracao.Text = "Ajuste Usuário";
            btn_configuracao.TextAlign = ContentAlignment.MiddleRight;
            btn_configuracao.UseVisualStyleBackColor = true;
            btn_configuracao.Click += btn_configuracao_Click;
            // 
            // btn_vendadeprodutos
            // 
            btn_vendadeprodutos.BackgroundImageLayout = ImageLayout.Zoom;
            btn_vendadeprodutos.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_vendadeprodutos.Image = (Image)resources.GetObject("btn_vendadeprodutos.Image");
            btn_vendadeprodutos.ImageAlign = ContentAlignment.MiddleLeft;
            btn_vendadeprodutos.Location = new Point(969, 406);
            btn_vendadeprodutos.Name = "btn_vendadeprodutos";
            btn_vendadeprodutos.Size = new Size(213, 54);
            btn_vendadeprodutos.TabIndex = 5;
            btn_vendadeprodutos.Text = "Venda de Produtos";
            btn_vendadeprodutos.TextAlign = ContentAlignment.MiddleRight;
            btn_vendadeprodutos.UseVisualStyleBackColor = false;
            btn_vendadeprodutos.Click += btn_vendadeprodutos_Click;
            // 
            // btn_sair
            // 
            btn_sair.BackColor = Color.Red;
            btn_sair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_sair.ForeColor = SystemColors.ButtonHighlight;
            btn_sair.Location = new Point(599, 151);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(101, 29);
            btn_sair.TabIndex = 5;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = false;
            btn_sair.Click += btn_sair_Click;
            // 
            // txt_usuario
            // 
            txt_usuario.AutoSize = true;
            txt_usuario.BackColor = Color.Transparent;
            txt_usuario.Font = new Font("Trebuchet MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txt_usuario.Location = new Point(1051, 153);
            txt_usuario.MaximumSize = new Size(163, 23);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(73, 23);
            txt_usuario.TabIndex = 8;
            txt_usuario.Text = "usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(942, 151);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 9;
            label1.Text = "Usuário(a) :";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.lateral;
            pictureBox2.Location = new Point(930, 179);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(284, 514);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // menucentral
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Design_sem_nome;
            ClientSize = new Size(915, 695);
            Controls.Add(btn_configuracao);
            Controls.Add(btn_relatorio);
            Controls.Add(label1);
            Controls.Add(txt_usuario);
            Controls.Add(btn_vendadeprodutos);
            Controls.Add(btn_sair);
            Controls.Add(btn_cadastrar);
            Controls.Add(tabControl1);
            Controls.Add(btn_menuside);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1214, 695);
            MinimumSize = new Size(915, 695);
            Name = "menucentral";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += menucentral_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_menuside;
        private ToolTip toolTip1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btn_cadastrar;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txt_quantpro;
        private TextBox txt_codbar;
        private TextBox textBox2;
        private TextBox txt_nompro;
        private DataGridView dataGridView1;
        private Button btn_sair;
        private MaskedTextBox txt_valpro;
        private TextBox txt_pesquisar;
        private Button btn_pesquisar;
        private TextBox txt_name;

        private Label txt_usuario;
        private Label label2;
        private Label txt_valortotal;
        private Label label1;
        private Button btn_vendadeprodutos;
        private TabPage tabPage3;
        private DataGridView dataGridView2;
        private TextBox txt_pesvenda;
        private Button btn_pesvenda;
        private DataGridView dataGridView3;
        private Button btn_adcvenda;
        private TextBox txt_qtdvenda;
        private TextBox txt_adcnomvenda;
        private TextBox txt_idvenda;
        private MaskedTextBox txt_valvenda;
        private TextBox txt_codbarvenda;
        private Button btn_vender;
        private Button txt_excluirvenda;
        private Label txt_valtotven;
        private Button btn_configuracao;
        private PictureBox pictureBox1;
        private TabPage tabPage4;
        private Button btn_relatorio;
        private DataGridView dataGridView4;
        private Label label3;
        private Button btn_pesqrel;
        private Label label4;
        private Label txt_valtotrel;
        private DateTimePicker cmskdatini2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DateTimePicker maskdatfim2;
        private PictureBox pictureBox2;
        private Button btn_desconto;
        private Label label5;
        private TextBox txt_desconto;
    }
}