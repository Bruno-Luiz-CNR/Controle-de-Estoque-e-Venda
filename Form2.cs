using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace controleestoque
{
    public partial class recuperar : Form
    {
        public recuperar()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string emailtela = txt_envemail.Text;
            if (emailtela.Contains("@"))
            {
                string conexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Bruno\\source\\repos\\controleestoque\\Model1.mdf;Integrated Security=True";
                string comando = "select email, nome, senha from loginusuario where email = '" + emailtela + "'";
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
                        string emailrecebido = row.ItemArray[0].ToString();
                        string nomerecebido = row.ItemArray[1].ToString();
                        string senharecebida = row.ItemArray[2].ToString();
                        if (emailrecebido == emailtela)
                        {
                            string from = "bruthasistems@hotmail.com";
                            string password = "bruno1234";
                            string to = emailrecebido;
                            string subject = "BruTha Recuperação SENHA";
                            string body = "Ola,usuário(a). \r\n Segue LOGIN:" + nomerecebido + "\r\n Segue SENHA:" + senharecebida;

                            SmtpClient client = new SmtpClient("smtp.office365.com", 587);
                            client.EnableSsl = true;
                            client.DeliveryMethod = SmtpDeliveryMethod.Network;
                            client.UseDefaultCredentials = false;
                            client.Credentials = new NetworkCredential(from, password);
                            MailMessage mail = new MailMessage(from, to, subject, body);
                            mail.BodyEncoding = System.Text.Encoding.UTF8;
                            mail.IsBodyHtml = true;
                            mail.Priority = MailPriority.High;

                            try
                            {
                                client.Send(mail);
                                MessageBox.Show("E-mail enviado com sucesso!", "Recuperar acesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Falha ao enviar e-mail: " + ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Email não cadastrado", "Recuper acesso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            else
            {
                MessageBox.Show("Favor digitar um e-mail valido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            recuperar form1 = (recuperar)Application.OpenForms["xyz"];
            formlogin form = new formlogin();
            form.Location = new Point(0, 0);
            form.Show();
            Close();


        }
    }
}
