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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                    
        }

        private void tsSuperior_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        //eventos click dos botoes do form principal
        private void tsbtnClientes_Click(object sender, EventArgs e)
        {
            frmClientes objFrmClientes = new frmClientes();
            objFrmClientes.ShowDialog();
        }

        private void tsbtnFuncionarios_Click(object sender, EventArgs e)
        {
            frmFuncionarios objFrmFuncionarios = new frmFuncionarios();
            objFrmFuncionarios.ShowDialog();
        }

        private void tsbtnLivros_Click(object sender, EventArgs e)
        {
            frmLivros objFrmLivros = new frmLivros();
            objFrmLivros.ShowDialog();
        }

        //evento click botao sair
        private void tsbtnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Você tem certeza que deseja sair do sistema?", "Mensagem do Sistema",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
