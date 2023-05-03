
using System.Data.SqlClient;

namespace controleestoque
{
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
            masksenhauser.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cadusu = txt_caduser.Text;
            string senha = masksenhauser.Text;
            string email = txt_emailuser.Text;
            if (email.Contains("@"))
            {
                string conexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Bruno\\source\\repos\\controleestoque\\Model1.mdf;Integrated Security=True";
                string comando = "insert loginusuario (nome, senha, email) values ('" + cadusu + "', '" + senha + "', '" + email + "')";
                string pesquisa = "select nome from loginusuario where nome = '" + cadusu + "'";
                SqlConnection? con = null;
                con = new SqlConnection(conexao);
                SqlCommand sqlCommand = new SqlCommand(pesquisa, con);
                con.Open();
                string nome = (string)sqlCommand.ExecuteScalar();
                if (nome != cadusu)
                {
                    SqlCommand sqlCommand2 = new SqlCommand(comando, con);
                    sqlCommand2.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_caduser.Text = string.Empty;
                    txt_emailuser.Text = string.Empty;
                    masksenhauser.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Usuario já cadastrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Favor digitar um e-mail valido", "Atenção", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            cadastro form1 = (cadastro)Application.OpenForms["xyz1"];
            formlogin form = new formlogin();
            form.Location = new Point(0, 0);
            form.Show();
            Close();
        }

        private void btn_versenha_Click(object sender, EventArgs e)
        {
            if (masksenhauser.PasswordChar == '*')
            {
                masksenhauser.PasswordChar = '\0';
            }
            else
            {
                masksenhauser.PasswordChar = '*';
            }
        }
    }
}
