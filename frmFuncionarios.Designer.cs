namespace Sistema_Biblioteca
{
    partial class frmFuncionarios
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
            this.tsSuperior = new System.Windows.Forms.ToolStrip();
            this.tsInferior = new System.Windows.Forms.ToolStrip();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAlterarExcluir = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCadastrar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnConsultar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnVoltar = new System.Windows.Forms.ToolStripButton();
            this.tsSuperior.SuspendLayout();
            this.tsInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsSuperior
            // 
            this.tsSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAlterarExcluir,
            this.tsbtnCadastrar,
            this.tsbtnConsultar,
            this.tsbtnVoltar});
            this.tsSuperior.Location = new System.Drawing.Point(0, 0);
            this.tsSuperior.Name = "tsSuperior";
            this.tsSuperior.Size = new System.Drawing.Size(634, 55);
            this.tsSuperior.TabIndex = 1;
            this.tsSuperior.Text = "toolStrip1";
            // 
            // tsInferior
            // 
            this.tsInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsInferior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSair});
            this.tsInferior.Location = new System.Drawing.Point(0, 406);
            this.tsInferior.Name = "tsInferior";
            this.tsInferior.Size = new System.Drawing.Size(634, 55);
            this.tsInferior.TabIndex = 2;
            this.tsInferior.Text = "toolStrip2";
            // 
            // tsbtnSair
            // 
            this.tsbtnSair.Image = global::Sistema_Biblioteca.Properties.Resources.sair_pequeno;
            this.tsbtnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSair.Name = "tsbtnSair";
            this.tsbtnSair.Size = new System.Drawing.Size(78, 52);
            this.tsbtnSair.Text = "Sair";
            this.tsbtnSair.Click += new System.EventHandler(this.tsbtnSair_Click);
            // 
            // tsbtnAlterarExcluir
            // 
            this.tsbtnAlterarExcluir.Image = global::Sistema_Biblioteca.Properties.Resources.alterar_excluir_pequeno;
            this.tsbtnAlterarExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnAlterarExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAlterarExcluir.Name = "tsbtnAlterarExcluir";
            this.tsbtnAlterarExcluir.Size = new System.Drawing.Size(134, 52);
            this.tsbtnAlterarExcluir.Text = "Alterar/Excluir";
            // 
            // tsbtnCadastrar
            // 
            this.tsbtnCadastrar.Image = global::Sistema_Biblioteca.Properties.Resources.cadastrar_pequeno;
            this.tsbtnCadastrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCadastrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCadastrar.Name = "tsbtnCadastrar";
            this.tsbtnCadastrar.Size = new System.Drawing.Size(109, 52);
            this.tsbtnCadastrar.Text = "Cadastrar";
            // 
            // tsbtnConsultar
            // 
            this.tsbtnConsultar.Image = global::Sistema_Biblioteca.Properties.Resources.consultar_pequeno;
            this.tsbtnConsultar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnConsultar.Name = "tsbtnConsultar";
            this.tsbtnConsultar.Size = new System.Drawing.Size(110, 52);
            this.tsbtnConsultar.Text = "Consultar";
            // 
            // tsbtnVoltar
            // 
            this.tsbtnVoltar.Image = global::Sistema_Biblioteca.Properties.Resources.voltar_pequeno;
            this.tsbtnVoltar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnVoltar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnVoltar.Name = "tsbtnVoltar";
            this.tsbtnVoltar.Size = new System.Drawing.Size(89, 52);
            this.tsbtnVoltar.Text = "Voltar";
            this.tsbtnVoltar.Click += new System.EventHandler(this.tsbtnVoltar_Click);
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.tsInferior);
            this.Controls.Add(this.tsSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "frmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionarios";
            this.tsSuperior.ResumeLayout(false);
            this.tsSuperior.PerformLayout();
            this.tsInferior.ResumeLayout(false);
            this.tsInferior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsSuperior;
        private System.Windows.Forms.ToolStrip tsInferior;
        public System.Windows.Forms.ToolStripButton tsbtnAlterarExcluir;
        public System.Windows.Forms.ToolStripButton tsbtnCadastrar;
        public System.Windows.Forms.ToolStripButton tsbtnConsultar;
        public System.Windows.Forms.ToolStripButton tsbtnVoltar;
        public System.Windows.Forms.ToolStripButton tsbtnSair;
    }
}