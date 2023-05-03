using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace controleestoque
{
    public partial class controleusu : Form
    {
        public controleusu()
        {
            InitializeComponent();
            string conexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Bruno\\source\\repos\\controleestoque\\Model1.mdf;Integrated Security=True";
            string comando = "select id, nome, credencial from loginusuario";
            SqlConnection? con = null;

            con = new SqlConnection(conexao);
            SqlCommand sqlCommand = new SqlCommand(comando, con);
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            con.Open();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_nomusu.Text = row.Cells[1].Value.ToString();
                com_cred.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            string nome = txt_nomusu.Text;
            string cred = com_cred.Text;
            string conexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Bruno\\source\\repos\\controleestoque\\Model1.mdf;Integrated Security=True";
            string comando = "update loginusuario set credencial = '" + cred + "' where nome = '" + nome + "'";
            SqlConnection? con = null;
            con = new SqlConnection(conexao);
            SqlCommand sqlCommand = new SqlCommand(comando, con);
            con.Open();
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Credencial alterada com sucesso !", "alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();

            string conexao2 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Bruno\\source\\repos\\controleestoque\\Model1.mdf;Integrated Security=True";
            string comando2 = "select id, nome, credencial from loginusuario";
            SqlConnection? con2 = null;

            con2 = new SqlConnection(conexao2);
            SqlCommand sqlCommand2 = new SqlCommand(comando2, con2);
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand2);
            con.Open();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            string nome = txt_nomusu.Text;
            string conexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Bruno\\source\\repos\\controleestoque\\Model1.mdf;Integrated Security=True";
            string comando = "delete from loginusuario where nome = '" + nome + "'";
            SqlConnection? con = null;
            con = new SqlConnection(conexao);
            SqlCommand sqlCommand = new SqlCommand(comando, con);
            con.Open();
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Usuário excluido com sucesso2", "alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
            string conexao2 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Bruno\\source\\repos\\controleestoque\\Model1.mdf;Integrated Security=True";
            string comando2 = "select id, nome, credencial from loginusuario";
            SqlConnection? con2 = null;

            con2 = new SqlConnection(conexao2);
            SqlCommand sqlCommand2 = new SqlCommand(comando2, con2);
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand2);
            con.Open();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menucentral form = new menucentral();
            form.Location = new Point(0, 0);
            form.Show();
            Close();
        }
    }
}
