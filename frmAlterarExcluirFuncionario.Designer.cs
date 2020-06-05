namespace Sistema_Biblioteca
{
    partial class frmAlterarExcluirFuncionario
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
            this.tsInferior = new System.Windows.Forms.ToolStrip();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.tsbtnVoltar = new System.Windows.Forms.ToolStripButton();
            this.nomeFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tsInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // tsInferior
            // 
            this.tsInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsInferior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnVoltar});
            this.tsInferior.Location = new System.Drawing.Point(0, 306);
            this.tsInferior.Name = "tsInferior";
            this.tsInferior.Size = new System.Drawing.Size(534, 55);
            this.tsInferior.TabIndex = 9;
            this.tsInferior.Text = "toolStrip1";
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeFunc,
            this.enderecoFunc,
            this.cidadeFunc,
            this.estadoFunc,
            this.telFunc,
            this.cargoFunc,
            this.codFunc,
            this.editar,
            this.excluir});
            this.dgvDados.Location = new System.Drawing.Point(0, 55);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.Size = new System.Drawing.Size(534, 236);
            this.dgvDados.TabIndex = 8;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(53, 13);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(431, 16);
            this.lblMensagem.TabIndex = 7;
            this.lblMensagem.Text = "Selecione o Registro e clique nos botões para Alterar/Excluir";
            // 
            // tsbtnVoltar
            // 
            this.tsbtnVoltar.Image = global::Sistema_Biblioteca.Properties.Resources.voltar_pequeno;
            this.tsbtnVoltar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnVoltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnVoltar.Name = "tsbtnVoltar";
            this.tsbtnVoltar.Size = new System.Drawing.Size(89, 52);
            this.tsbtnVoltar.Text = "Voltar";
            // 
            // nomeFunc
            // 
            this.nomeFunc.HeaderText = "Nome do Funcionário";
            this.nomeFunc.Name = "nomeFunc";
            this.nomeFunc.ReadOnly = true;
            // 
            // enderecoFunc
            // 
            this.enderecoFunc.HeaderText = "Endereço";
            this.enderecoFunc.Name = "enderecoFunc";
            this.enderecoFunc.ReadOnly = true;
            // 
            // cidadeFunc
            // 
            this.cidadeFunc.HeaderText = "Cidade";
            this.cidadeFunc.Name = "cidadeFunc";
            this.cidadeFunc.ReadOnly = true;
            // 
            // estadoFunc
            // 
            this.estadoFunc.HeaderText = "Estado";
            this.estadoFunc.Name = "estadoFunc";
            this.estadoFunc.ReadOnly = true;
            // 
            // telFunc
            // 
            this.telFunc.HeaderText = "Telefone";
            this.telFunc.Name = "telFunc";
            this.telFunc.ReadOnly = true;
            // 
            // cargoFunc
            // 
            this.cargoFunc.HeaderText = "Cargo";
            this.cargoFunc.Name = "cargoFunc";
            this.cargoFunc.ReadOnly = true;
            // 
            // codFunc
            // 
            this.codFunc.HeaderText = "Código";
            this.codFunc.Name = "codFunc";
            this.codFunc.ReadOnly = true;
            // 
            // editar
            // 
            this.editar.HeaderText = "Editar";
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            // 
            // excluir
            // 
            this.excluir.HeaderText = "Excluir";
            this.excluir.Name = "excluir";
            this.excluir.ReadOnly = true;
            // 
            // frmAlterarExcluirFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.tsInferior);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.lblMensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlterarExcluirFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Excluir Funcionario";
            this.tsInferior.ResumeLayout(false);
            this.tsInferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip tsInferior;
        public System.Windows.Forms.ToolStripButton tsbtnVoltar;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn telFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn codFunc;
        private System.Windows.Forms.DataGridViewButtonColumn editar;
        private System.Windows.Forms.DataGridViewButtonColumn excluir;
    }
}