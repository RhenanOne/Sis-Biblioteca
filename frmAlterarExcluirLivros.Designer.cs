namespace Sistema_Biblioteca
{
    partial class frmAlterarExcluirLivros
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
            this.nomeLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editoraLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tsInferior.TabIndex = 12;
            this.tsInferior.Text = "toolStrip1";
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeLivro,
            this.autorLivro,
            this.anoLivro,
            this.generoLivro,
            this.editoraLivro,
            this.statusLivro,
            this.codFunc,
            this.editar,
            this.excluir});
            this.dgvDados.Location = new System.Drawing.Point(0, 49);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.Size = new System.Drawing.Size(534, 236);
            this.dgvDados.TabIndex = 11;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(53, 7);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(431, 16);
            this.lblMensagem.TabIndex = 10;
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
            // nomeLivro
            // 
            this.nomeLivro.HeaderText = "Nome do Livro";
            this.nomeLivro.Name = "nomeLivro";
            this.nomeLivro.ReadOnly = true;
            // 
            // autorLivro
            // 
            this.autorLivro.HeaderText = "Autor";
            this.autorLivro.Name = "autorLivro";
            this.autorLivro.ReadOnly = true;
            // 
            // anoLivro
            // 
            this.anoLivro.HeaderText = "Ano";
            this.anoLivro.Name = "anoLivro";
            this.anoLivro.ReadOnly = true;
            // 
            // generoLivro
            // 
            this.generoLivro.HeaderText = "Gênero";
            this.generoLivro.Name = "generoLivro";
            this.generoLivro.ReadOnly = true;
            // 
            // editoraLivro
            // 
            this.editoraLivro.HeaderText = "Editora";
            this.editoraLivro.Name = "editoraLivro";
            this.editoraLivro.ReadOnly = true;
            // 
            // statusLivro
            // 
            this.statusLivro.HeaderText = "Status";
            this.statusLivro.Name = "statusLivro";
            this.statusLivro.ReadOnly = true;
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
            // frmAlterarExcluirLivros
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
            this.Name = "frmAlterarExcluirLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Excluir Livros";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn editoraLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn codFunc;
        private System.Windows.Forms.DataGridViewButtonColumn editar;
        private System.Windows.Forms.DataGridViewButtonColumn excluir;
    }
}