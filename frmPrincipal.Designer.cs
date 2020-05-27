namespace Sistema_Biblioteca
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tsSuperior = new System.Windows.Forms.ToolStrip();
            this.tsbtnClientes = new System.Windows.Forms.ToolStripButton();
            this.tsbtnFuncionarios = new System.Windows.Forms.ToolStripButton();
            this.tsbtnLivros = new System.Windows.Forms.ToolStripButton();
            this.tsInferior = new System.Windows.Forms.ToolStrip();
            this.tsbtnSair = new System.Windows.Forms.ToolStripButton();
            this.tsSuperior.SuspendLayout();
            this.tsInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsSuperior
            // 
            this.tsSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnClientes,
            this.tsbtnFuncionarios,
            this.tsbtnLivros});
            this.tsSuperior.Location = new System.Drawing.Point(0, 0);
            this.tsSuperior.Name = "tsSuperior";
            this.tsSuperior.Size = new System.Drawing.Size(634, 55);
            this.tsSuperior.TabIndex = 0;
            this.tsSuperior.Text = "toolStrip1";
            this.tsSuperior.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsSuperior_ItemClicked);
            // 
            // tsbtnClientes
            // 
            this.tsbtnClientes.Image = global::Sistema_Biblioteca.Properties.Resources.cliente_pequeno;
            this.tsbtnClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClientes.Name = "tsbtnClientes";
            this.tsbtnClientes.Size = new System.Drawing.Size(101, 52);
            this.tsbtnClientes.Text = "Clientes";
            this.tsbtnClientes.Click += new System.EventHandler(this.tsbtnClientes_Click);
            // 
            // tsbtnFuncionarios
            // 
            this.tsbtnFuncionarios.Image = global::Sistema_Biblioteca.Properties.Resources.funcionario_pequeno;
            this.tsbtnFuncionarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnFuncionarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnFuncionarios.Name = "tsbtnFuncionarios";
            this.tsbtnFuncionarios.Size = new System.Drawing.Size(127, 52);
            this.tsbtnFuncionarios.Text = "Funcionários";
            this.tsbtnFuncionarios.Click += new System.EventHandler(this.tsbtnFuncionarios_Click);
            // 
            // tsbtnLivros
            // 
            this.tsbtnLivros.Image = global::Sistema_Biblioteca.Properties.Resources.livros_pequeno;
            this.tsbtnLivros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnLivros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLivros.Name = "tsbtnLivros";
            this.tsbtnLivros.Size = new System.Drawing.Size(90, 52);
            this.tsbtnLivros.Text = "Livros";
            this.tsbtnLivros.Click += new System.EventHandler(this.tsbtnLivros_Click);
            // 
            // tsInferior
            // 
            this.tsInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsInferior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnSair});
            this.tsInferior.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsInferior.Location = new System.Drawing.Point(0, 406);
            this.tsInferior.Name = "tsInferior";
            this.tsInferior.Size = new System.Drawing.Size(634, 55);
            this.tsInferior.TabIndex = 1;
            this.tsInferior.Text = "toolStrip1";
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
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.tsInferior);
            this.Controls.Add(this.tsSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SisGen. Biblioteca v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tsSuperior.ResumeLayout(false);
            this.tsSuperior.PerformLayout();
            this.tsInferior.ResumeLayout(false);
            this.tsInferior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsSuperior;
        private System.Windows.Forms.ToolStripButton tsbtnClientes;
        private System.Windows.Forms.ToolStripButton tsbtnFuncionarios;
        private System.Windows.Forms.ToolStripButton tsbtnLivros;
        private System.Windows.Forms.ToolStrip tsInferior;
        private System.Windows.Forms.ToolStripButton tsbtnSair;
    }
}

