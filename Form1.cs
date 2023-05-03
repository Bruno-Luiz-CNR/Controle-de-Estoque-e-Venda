using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace controleestoque
{
    public partial class formlogin : Form
    {
        public formlogin()
        {
            InitializeComponent();
            txtmask.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string usuario = txt_name.Text;
            string senhausu = txtmask.Text;
            string conexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Bruno\\source\\repos\\controleestoque\\Model1.mdf;Integrated Security=True";
            string comando = "select nome, senha from loginusuario where nome = '" + usuario + "'";
            SqlConnection? con = null;
            try
            {
                con = new SqlConnection(conexao);
                SqlCommand sqlCommand = new SqlCommand(comando, con);
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                con.Open();
                adapter.Fill(ds);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string nometabela = row.ItemArray[0].ToString();
                    string senhatabela = row.ItemArray[1].ToString();
                    if (nometabela == usuario && senhatabela == senhausu)
                    {
                        menucentral form2 = (menucentral)Application.OpenForms["xyzy"];

                        if (form2 == null)
                        {
                            form2 = new menucentral(txt_name.Text);
                            form2.Name = "xyzy";
                            form2.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Formalário há esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha incorretas !", "Ateção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_cadastrarusuario_Click_1(object sender, EventArgs e)
        {
            cadastro form2 = (cadastro)Application.OpenForms["xyz"];
            if (form2 == null)
            {
                form2 = new cadastro();
                form2.Name = "xyz";
                form2.Show();
                this.Hide();
            }
            else
            {
                form2 = new cadastro();
                form2.Name = "xyz";
                form2.Show();
                this.Hide();
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recuperar form2 = (recuperar)Application.OpenForms["xyz"];
            if (form2 == null)
            {
                form2 = new recuperar();
                form2.Name = "xyz";
                form2.Show();
                Hide();

            }
            else
            {
                MessageBox.Show("Formalário há esta aberto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtmask.PasswordChar == '*')
            {
                txtmask.PasswordChar = '\0';
            }
            else
            {
                txtmask.PasswordChar = '*';
            }
        }
    }
}