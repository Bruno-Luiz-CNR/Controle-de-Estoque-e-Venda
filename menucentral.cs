
using System.Data;
using System.Data.SqlClient;


namespace controleestoque
{
    public partial class menucentral : Form
    {
        bool siderbarabrir;
        public menucentral()
        {
            InitializeComponent();

            string conexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Bruno\\source\\repos\\controleestoque\\Model1.mdf;Integrated Security=True";
            string comando = "select idpro, codbar, nompro, qtpro, valpro from cadaspro";
            SqlConnection? con = null;

            con = new SqlConnection(conexao);
            SqlCommand sqlCommand = new SqlCommand(comando, con);
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            con.Open();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
            decimal soma = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                soma += Convert.ToDecimal(row.Cells[4].Value);
                txt_valortotal.Text = "Valor Total: " + soma.ToString("F2") + "R$";
            }


        }


        public menucentral(string parametros) : this()
        {
            txt_usuario.Text = parametros;
            string name = txt_usuario.Text;
            string conexao2 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Bruno\\source\\repos\\controleestoque\\Model1.mdf;Integrated Security=True";
            string pesquisa = "select credencial from loginusuario where nome = '" + name + "'";
            SqlConnection? con2 = null;
            con2 = new SqlConnection(conexao2);
            SqlCommand sqlCommand2 = new SqlCommand(pesquisa, con2);
            con2.Open();
            object idcre = sqlCommand2.ExecuteScalar();
            string resultado = Convert.ToString(idcre);
            if (resultado == "" || resultado == "usu")
            {

                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                btn_configuracao.Enabled = false;
                btn_pesqrel.Enabled = false;

            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                btn_configuracao.Enabled = true;
                btn_pesqrel.Enabled = true;
            }
            con2.Close();
        }
        private void btn_menuside_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            if (Size.Width == 1214)
            {
                Size = new Size(915, Size.Width);
            }
            else
            {
                Size = new Size(1214, Size.Width);
            }
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nomeproduto = txt_nompro.Text;
            string codigobar = txt_codbar.Text;
            string quantpro = txt_quantpro.Text;
            string valpro = txt_valpro.Text.Replace(",", ".");
            string conexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Bruno\\source\\repos\\controleestoque\\Model1.mdf;Integrated Security=True";
            string comando = "insert cadaspro (codbar, nompro, qtpro, valpro) values (" + codigobar + ", '" + nomeproduto + "', " + quantpro + ",'" + valpro + "')";

            SqlConnection? con = null;
            con = new SqlConnection(conexao);
            SqlCommand sqlCommand = new SqlCommand(comando, con);
            con.Open();
            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Cadastro realizado com sucesso !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txt_nompro.Text = string.Empty;
            txt_codbar.Text = string.Empty;
            txt_quantpro.Text = string.Empty;
            txt_valpro.Text = string.Empty;
            con.Close();
            connectar(sender, e);
            con.Close();
            somartabela(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menucentral_Load(object sender, EventArgs e)
        {

        }
        private void connectar(object sender, EventArgs e)
        {
            string conexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Bruno\\source\\repos\\controleestoque\\Model1.mdf;Integrated Security=True";
            string comando = "select idpro, codbar, nompro, qtpro, valpro from cadaspro";
            SqlConnection? con = null;

            con = new SqlConnection(conexao);
            SqlCommand sqlCommand = new SqlCommand(comando, con);
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            con.Open();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            somartabela(sender, e);
        }
        private void connectarvenda(object sender, EventArgs e)
        {
            string conexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Bruno\\source\\repos\\controleestoque\\Model1.mdf;Integrated Security=True";
            string comando = "select idpro, codbar, nompro, qtpro, valpro, vtotla from vendapro";
            SqlConnection? con = null;

            con = new SqlConnection(conexao);
            SqlCommand sqlCommand = new SqlCommand(comando, con);
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            con.Open();
            adapter.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                row.Cells[5].Value = Math.Round(Convert.ToDouble(row.Cells[3].Value) * Convert.ToDouble(row.Cells[4].Value), 2);
                decimal soma2 = Convert.ToDecimal(row.Cells[5].Value);

            }

            somartabela(sender, e);
            con.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_ReadOnlyChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox2.Text = row.Cells[0].Value.ToString();
                txt_codbar.Text = row.Cells[1].Value.ToString();
                txt_nompro.Text = row.Cells[2].Value.ToString();
                txt_quantpro.Text = row.Cells[3].Value.ToString();
                txt_valpro.Text = row.Cells[4].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idpro = textBox2.Text;
            string nomeproduto = txt_nompro.Text;
            string codigobar = txt_codbar.Text;
            string quantpro = txt_quantpro.Text;
            string valpro = txt_valpro.Text.Replace(",", ".");
            string conexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Bruno\\source\\repos\\controleestoque\\Model1.mdf;Integrated Security=True";
            string comando = "update cadaspro set codbar = " + codigobar + ", nompro = '" + nomeproduto + "', qtpro = " + quantpro + ", valpro = '" + valpro + "' where idpro = " + idpro + "";
            SqlConnection? con = null;
            con = new SqlConnection(conexao);
            SqlCommand sqlCommand = new SqlCommand(comando, con);
            con.Open();
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Alteração realizado com sucesso !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            txt_nompro.Text = string.Empty;
            txt_codbar.Text = string.Empty;
            txt_quantpro.Text = string.Empty;
            txt_valpro.Text = string.Empty;
            connectar(sender, e);
            somartabela(sender, e);
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = "%" + txt_pesquisar.Text + "%";
            string conexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Bruno\\source\\repos\\controleestoque\\Model1.mdf;Integrated Security=True";
            string comando = "select idpro, codbar, nompro, qtpro, valpro from cadaspro where nompro like '" + pesquisa + "' order by idpro";
            SqlConnection? con = null;

            con = new SqlConnection(conexao);
            SqlCommand sqlCommand = new SqlCommand(comando, con);
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            con.Open();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            somartabela(sender, e);
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }
        private void somartabela(object sender, EventArgs e)
        {
            decimal soma = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                soma += Convert.ToDecimal(row.Cells[4].Value);
                txt_valortotal.Text = "Valor Total: " + soma.ToString("F2") + "R$";
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            string id = textBox2.Text;
            string comando = "delete from cadaspro where idpro = " + id + "";
            string conexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Bruno\\source\\repos\\controleestoque\\Model1.mdf;Integrated Security=True";
            SqlConnection? con = null;
            con = new SqlConnection(conexao);
            SqlCommand sqlCommand = new SqlCommand(comando, con);
            con.Open();
            sqlCommand.ExecuteNonQuery();
            somartabela(sender, e);
            connectar(sender, e);
        }

        private void btn_vendadeprodutos_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void btn_pesvenda_Click(object sender, EventArgs e)
        {
            string pesquisa = "%" + txt_pesvenda.Text + "%";
            string conexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Bruno\\source\\repos\\controleestoque\\Model1.mdf;Integrated Security=True";
            string comando = "select idpro, codbar, nompro, qtpro, valpro from cadaspro where nompro like '" + pesquisa + "' order by idpro";
            SqlConnection? con = null;

            con = new SqlConnection(conexao);
            SqlCommand sqlCommand = new SqlCommand(comando, con);
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            con.Open();
            adapter.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                txt_idvenda.Text = row.Cells[0].Value.ToString();
                txt_codbarvenda.Text = row.Cells[1].Value.ToString();
                txt_adcnomvenda.Text = row.Cells[2].Value.ToString();
                txt_qtdvenda.Text = row.Cells[3].Value.ToString();
                txt_valvenda.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btn_adcvenda_Click(object sender, EventArgs e)
        {
            if (txt_adcnomvenda.Text == string.Empty)
            {
                MessageBox.Show("Favor selecionar mercadoria", "Seleção de Mercadoria");
            }
            else
            {
                string idpro = txt_idvenda.Text;
                string nomeproduto = txt_adcnomvenda.Text;
                string codigobar = txt_codbarvenda.Text;
                string quantpro = txt_qtdvenda.Text;
                string valpro = txt_valvenda.Text.Replace(",", ".");
                string conexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Bruno\\source\\repos\\controleestoque\\Model1.mdf;Integrated Security=True";
                string comando = "insert vendapro (idpro, codbar, nompro, qtpro, valpro) values (" + idpro + "," + codigobar + ", '" + nomeproduto + "', " + quantpro + ",'" + valpro + "')";

                SqlConnection? con = null;
                con = new SqlConnection(conexao);
                SqlCommand sqlCommand = new SqlCommand(comando, con);
                con.Open();
                sqlCommand.ExecuteNonQuery();
                con.Close();
                connectarvenda(sender, e);
                con.Close();
                decimal soma = 0;
                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    soma += Convert.ToDecimal(row.Cells[5].Value);
                    txt_valtotven.Text = "Valor Total: " + soma.ToString("F2") + "R$";
                }
            }

        }

        private void btn_vender_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                SqlConnection conexao6 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Bruno\\source\\repos\\controleestoque\\Model1.mdf;Integrated Security=True");
                conexao6.Open();
                int id = Convert.ToInt32(row.Cells["idpro"].Value);
                string consulta = "SELECT qtpro FROM cadaspro WHERE idpro = " + id + "";
                SqlCommand comando = new SqlCommand(consulta, conexao6);

                comando.Parameters.AddWithValue("idpro", consulta);
                SqlDataReader leitor = comando.ExecuteReader();
                if (leitor.Read())
                {
                    SqlConnection conexao7 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Bruno\\source\\repos\\controleestoque\\Model1.mdf;Integrated Security=True");
                    conexao7.Open();
                    int numero_do_banco_de_dados = Convert.ToInt32(leitor.GetValue(0));
                    int variavel_do_datagridview = Convert.ToInt32(row.Cells["qtpro"].Value);
                    int resultado2 = numero_do_banco_de_dados - variavel_do_datagridview;
                    string resultado = resultado2.ToString().Replace(",", ".");
                    string query = "update cadaspro set qtpro = " + resultado + " where idpro = " + id + " ";
                    SqlCommand comando2 = new SqlCommand(query, conexao7);
                    comando2.ExecuteReader();
                    conexao7.Close();

                }
                leitor.Close();
                conexao6.Close();
                string dataatual = DateTime.Now.ToString("dd/MM/yyyy");
                int ids = Convert.ToInt32(row.Cells["idpro"].Value);
                string codigobar = Convert.ToString(row.Cells["codbar"].Value);
                string nomeproduto = Convert.ToString(row.Cells["nompro"].Value);
                int quantpro = Convert.ToInt32(row.Cells["qtpro"].Value);
                string valpro2 = Convert.ToString(row.Cells["valpro"].Value);
                string valpro = valpro2.Replace(",", ".");
                string soma2 = Convert.ToString(row.Cells[5].Value);
                string soma3 = soma2.Replace(",", ".");

                string conexao4 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Bruno\\source\\repos\\controleestoque\\Model1.mdf;Integrated Security=True";
                string comando8 = "insert relvenda (idpro, codbar, nompro, qtpro, valpro, data, vtotla) values (" + ids + "," + codigobar + ", '" + nomeproduto + "', " + quantpro + ",'" + valpro + "', '" + dataatual + "', '" + soma3 + "')";
                SqlConnection? con2 = null;
                con2 = new SqlConnection(conexao4);
                SqlCommand sqlCommand4 = new SqlCommand(comando8, con2);
                con2.Open();
                sqlCommand4.ExecuteNonQuery();
                con2.Close();
            }
            connectarvenda(sender, e);
            string conexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Bruno\\source\\repos\\controleestoque\\Model1.mdf;Integrated Security=True";
            string comando3 = "delete from vendapro";
            SqlConnection? con = null;
            con = new SqlConnection(conexao);
            SqlCommand sqlCommand = new SqlCommand(comando3, con);
            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();
            connectarvenda(sender, e);
            string valortotalvenda = txt_valtotven.Text;
            MessageBox.Show("Venda concluida com sucesso ! \r\n" + valortotalvenda, "Venda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_excluirvenda_Click_1(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView3.SelectedRows)
                {
                    int idvenda = Convert.ToInt32(row.Cells["idpro"].Value);
                    string vendaproex = "delete from vendapro where idpro = " + idvenda + "";
                    string conexaovenda = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Bruno\\source\\repos\\controleestoque\\Model1.mdf;Integrated Security=True";
                    SqlConnection conexao = new SqlConnection(conexaovenda);
                    conexao.Open();
                    SqlCommand command = new SqlCommand(vendaproex, conexao);
                    command.ExecuteNonQuery();
                    conexao.Close();
                    connectarvenda(sender, e);
                }

            }
        }

        private void btn_configuracao_Click(object sender, EventArgs e)
        {
            controleusu form3 = (controleusu)Application.OpenForms["xyzyz"];

            if (form3 == null)
            {
                form3 = new controleusu();
                form3.Name = "xyzyz";
                form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Formulário já esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_pesqrel_Click(object sender, EventArgs e)
        {
            string datainicial = cmskdatini2.Text;
            string datafinal = maskdatfim2.Text;

            if (datainicial.CompareTo(datafinal) > 0)
            {
                MessageBox.Show("A data inicial não pode ser maior que a data final.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                string consulta = "select * from relvenda WHERE data BETWEEN '" + datainicial + "' AND '" + datafinal + "'";
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Bruno\\source\\repos\\controleestoque\\Model1.mdf;Integrated Security=True";
                SqlConnection conexao = new SqlConnection(connectionString);

                SqlCommand comando = new SqlCommand(consulta, conexao);

                SqlDataAdapter adapter = new SqlDataAdapter(comando);

                DataTable tabela = new DataTable();

                adapter.Fill(tabela);

                dataGridView4.DataSource = tabela;

                decimal soma = 0;
                foreach (DataGridViewRow row in dataGridView4.Rows)
                {
                    soma += Convert.ToDecimal(row.Cells[6].Value);
                    txt_valtotrel.Text = "Valor Total: " + soma.ToString("N2") + "R$";
                }
            }


        }

        private void btn_relatorio_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void txt_valtotrel_Click(object sender, EventArgs e)
        {

        }

        private void btn_desconto_Click(object sender, EventArgs e)
        {
            if (txt_desconto.Text == string.Empty)
            {
                string semdados = "0";
                txt_desconto.Text = Convert.ToString(semdados);
            }
            else
            {
                decimal soma = 0;
                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    soma += Convert.ToDecimal(row.Cells[5].Value);
                }
                decimal porcentualdesc = Convert.ToDecimal(txt_desconto.Text) / 100.0m;
                decimal valor_final = soma - (soma * porcentualdesc);
                txt_valtotven.Text = $"Valor Total: {valor_final:F2} R$";
            }
        }
    }
}

