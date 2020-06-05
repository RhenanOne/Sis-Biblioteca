using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_Biblioteca
{
    public partial class frmCadastrarClientes : Form
    {
        public frmCadastrarClientes()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmCadastrarClientes_Load(object sender, EventArgs e)
        {

        }

        private void tsbtnVoltar_Click(object sender, EventArgs e)
        {

        }

        private void tsbtnGravar_Click(object sender, EventArgs e)
        {

            /*FALTA O BANCO DE DADOS

            
                private void Gravar()

            {
                //Crio uma variável booleana que irá verificar se os campos estão validados

                bool camposValidados = false;

                try

                {

                    //Instancio a classe de conexão passando como parâmetro a string de conexão ao DataBase LibrarySystem

                    SqlConnection objConexao = new SqlConnection(@"Data Source=WELLINGTON-PC\SQLEXPRESS;
 
Initial Catalog=LibrarySystem;Integrated Security=True");

                    //Armazeno em uma variável do tipo string minha instrução SQL referente à inserção do registro,

                    //concatenando os valores parametrizados, referentes aos campos que serão preenchidos no form

                    string strConn = @"INSERT INTO Clientes (Nome_Cliente, Endereco_Cliente, Cidade_Cliente, Estado_Cliente," +

                    "Telefone_Cliente, Status_Cliente) VALUES (@Nome, @Endereco, @Cidade, @Estado, @Telefone, @Status)";

                    //Uso o objeto instanciado passando como parâmetro a string criada anteriomente e o objeto de conexão ao banco

                    SqlCommand objCommand = new SqlCommand(strConn, objConexao);

                    #region Validações dos Campos

                    //Faço a verificação: se os campos do form estiverem diferentes de nulos uso o método AddWithValue passando como parâmetro

                    //o Value parametrizado do Insert acima. Se os campos estiverem vazios, chamo o ErrorProvider disparando o erro ao usuário

                    //Nome

                    if (!String.IsNullOrEmpty(txtNome.Text))

                    {

                        objCommand.Parameters.AddWithValue("@Nome", txtNome.Text);

                        camposValidados = true;

                    }

                    else

                    {

                        epErro.SetError(txtNome, "O campo Nome é obrigatório!");

                        camposValidados = false;

                    }

                    //Endereço

                    if (!String.IsNullOrEmpty(txtEndereco.Text))

                    {

                        objCommand.Parameters.AddWithValue("@Endereco", txtEndereco.Text);

                        camposValidados = true;

                    }

                    else

                    {

                        epErro.SetError(txtEndereco, "O campo Endereço é obrigatório!");

                        camposValidados = false;

                    }

                    //Cidade

                    if (!String.IsNullOrEmpty(txtCidade.Text))

                    {

                        objCommand.Parameters.AddWithValue("@Cidade", txtCidade.Text);

                        camposValidados = true;

                    }

                    else

                    {

                        epErro.SetError(txtCidade, "O campo Cidade é obrigatório!");

                        camposValidados = false;

                    }

                    //Status

                    if (rbtAtivo.Checked)

                    {

                        objCommand.Parameters.AddWithValue("@Status", "A");

                        camposValidados = true;

                    }

                    else

                    {

                        objCommand.Parameters.AddWithValue("@Status", "I");

                        camposValidados = true;

                    }

                    //Telefone

                    if (!String.IsNullOrEmpty(mtbTelefone.Text))

                    {

                        objCommand.Parameters.AddWithValue("@Telefone", mtbTelefone.Text);

                        camposValidados = true;

                    }

                    //Estado

                    if (ddlEstado.SelectedIndex > -1)

                    {

                        objCommand.Parameters.AddWithValue("@Estado", ddlEstado.SelectedItem);

                        camposValidados = true;

                    }

                    else

                    {

                        epErro.SetError(ddlEstado, "O campo Estado é obrigatório!");

                        camposValidados = false;

                    }

                    #endregion

                    //Verifico se o retorno de minha variável camposValidados é true

                    if (camposValidados)

                    {

                        //Abro a conexão

                        objConexao.Open();

                        //Uso o método ExecuteNonQuery para executar os comandos e realizar o Insert no banco

                        objCommand.ExecuteNonQuery();

                        //Fecho a conexão

                        objConexao.Close();

                        //Exibo a mensagem ao usuário de confirmação da inserção no banco

                        MessageBox.Show("Registro inserido com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Chamo o método para limpar os campos e dou o foco ao txtNome

                        LimparCampos();

                        txtNome.Focus();

                        //Habilito o botão Voltar para o usuário

                        tsbtnVoltar.Enabled = true;

                    }

                    else

                    {

                        //Exibo a mensagem ao usuário de erro

                        MessageBox.Show("Ops, ocorreram erros!\n\nPreencha os campos e tente novamente",

                        "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }

                catch (Exception ex)

                {

                    MessageBox.Show(ex.Message);

                }

            }
         */
        }
    }
}
