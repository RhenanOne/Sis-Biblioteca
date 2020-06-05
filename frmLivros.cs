using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Biblioteca
{
    public partial class frmLivros : Form
    {
        public frmLivros()
        {
            InitializeComponent();
        }

        //evento do botao voltar
        private void tsbtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //evento do botao sair
        private void tsbtnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza que deseja sair do sistema?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void DesabilitaBotoes(object sender, EventArgs e)

        {

            tsbtnAlterarExcluir.Enabled = false;

            tsbtnCadastrar.Enabled = false;

            tsbtnConsultar.Enabled = false;

            tsbtnVoltar.Enabled = false;

            tsbtnSair.Enabled = false;

        }

        private void HabilitaBotoes(object sender, EventArgs e)

        {

            tsbtnAlterarExcluir.Enabled = true;

            tsbtnCadastrar.Enabled = true;

            tsbtnConsultar.Enabled = true;

            tsbtnVoltar.Enabled = true;

            tsbtnSair.Enabled = true;

        }


        private void tsbtnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastrarLivros objFrmCadastrarLivros = new frmCadastrarLivros();

            //Informo a aplicação que o frmCadastrarClientes é o form filho do frmClientes
            objFrmCadastrarLivros.MdiParent = this;

            //Chamo o método que desativa os botões do formulário pai
            this.DesabilitaBotoes(sender, e);

            //Vinculo ao botão Cancelar Cadastro, do form filho, o método para ativar os botões do formulário pai, por meio de delegate
            objFrmCadastrarLivros.tsbtnCancelar.Click += new EventHandler(this.HabilitaBotoes);

            //Verifico se o form já está aberto. Se estiver impeço a abertura de um novo e exibo uma mensagem ao usuário
            if (objFrmCadastrarLivros.Visible == false)
            {
                objFrmCadastrarLivros.Show();
            }
            else
            {
                MessageBox.Show("O formulário já está aberto com a gravação dos dados em andamento! Feche este formulário para abrir outro!",
                "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tsbtnConsultar_Click(object sender, EventArgs e)
        {

            {

                frmConsultarLivros objFrmConsultarLivros = new frmConsultarLivros();

                //Informo a aplicação que o frmConsultarClientes é o form filho do frmClientes

                objFrmConsultarLivros.MdiParent = this;

                //Chamo o método que desativa os botões do formulário pai

                this.DesabilitaBotoes(sender, e);

                //Vinculo ao botão Cancelar Cadastro, do form filho o método para ativar os botões do formulário pai, por meio de delegate

                objFrmConsultarLivros.tsbtnVoltar.Click += new EventHandler(this.HabilitaBotoes);

                //Verifico se o form já está aberto. Se estiver impeço a abertura de um novo e exibo uma mensagem ao usuário

                if (objFrmConsultarLivros.Visible == false)

                {

                    objFrmConsultarLivros.Show();

                }

                else

                {

                    MessageBox.Show("O formulário já está aberto com a gravação dos dados em andamento! Feche este formulário para abrir outro!",

                    "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            }

        }

        private void tsbtnAlterarExcluir_Click(object sender, EventArgs e)
        {

            {

                frmAlterarExcluirLivros objFrmAlterarExcluirLivros = new frmAlterarExcluirLivros();

                //Informo a aplicação que o frmAlterarExcluirClientes é o form filho do frmClientes

                objFrmAlterarExcluirLivros.MdiParent = this;

                //Chamo o método que desativa os botões do formulário pai

                this.DesabilitaBotoes(sender, e);

                //Vinculo ao botão Cancelar Cadastro, do form filho o método para ativar os botões do formulário pai, por meio de delegate

                objFrmAlterarExcluirLivros.tsbtnVoltar.Click += new EventHandler(this.HabilitaBotoes);

                //Verifico se o form já está aberto. Se estiver impeço a abertura de um novo e exibo uma mensagem ao usuário

                if (objFrmAlterarExcluirLivros.Visible == false)

                {

                    objFrmAlterarExcluirLivros.Show();

                }

                else

                {

                    MessageBox.Show("O formulário já está aberto com a gravação dos dados em andamento! Feche este formulário para abrir outro!",

                    "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            }
        }
    }
}
