namespace Sistema_Biblioteca
{
    partial class frmCadastrarLivros
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
            this.tsbtnGravar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsInferior = new System.Windows.Forms.ToolStrip();
            this.tsbtnVoltar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.txtPaginas = new System.Windows.Forms.TextBox();
            this.rbtDisponivel = new System.Windows.Forms.RadioButton();
            this.rbtIndiponivel = new System.Windows.Forms.RadioButton();
            this.tsSuperior.SuspendLayout();
            this.tsInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsSuperior
            // 
            this.tsSuperior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnGravar,
            this.tsbtnCancelar});
            this.tsSuperior.Location = new System.Drawing.Point(0, 0);
            this.tsSuperior.Name = "tsSuperior";
            this.tsSuperior.Size = new System.Drawing.Size(534, 55);
            this.tsSuperior.TabIndex = 0;
            this.tsSuperior.Text = "toolStrip1";
            // 
            // tsbtnGravar
            // 
            this.tsbtnGravar.Image = global::Sistema_Biblioteca.Properties.Resources.gravar_pequeno;
            this.tsbtnGravar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnGravar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnGravar.Name = "tsbtnGravar";
            this.tsbtnGravar.Size = new System.Drawing.Size(175, 52);
            this.tsbtnGravar.Text = "Gravar Dados do Livro";
            // 
            // tsbtnCancelar
            // 
            this.tsbtnCancelar.Image = global::Sistema_Biblioteca.Properties.Resources.cancelar_pequeno;
            this.tsbtnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCancelar.Name = "tsbtnCancelar";
            this.tsbtnCancelar.Size = new System.Drawing.Size(155, 52);
            this.tsbtnCancelar.Text = "Cancelar Cadastro";
            // 
            // tsInferior
            // 
            this.tsInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsInferior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnVoltar});
            this.tsInferior.Location = new System.Drawing.Point(0, 306);
            this.tsInferior.Name = "tsInferior";
            this.tsInferior.Size = new System.Drawing.Size(534, 55);
            this.tsInferior.TabIndex = 1;
            this.tsInferior.Text = "toolStrip1";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do livro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Autor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ano:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gênero:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Editora:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(294, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Número de páginas:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(95, 68);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(341, 13);
            this.lbTitulo.TabIndex = 10;
            this.lbTitulo.Text = "Preencha os dados corretamente e clique em gravar dados";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.Location = new System.Drawing.Point(95, 92);
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(100, 20);
            this.txtNomeLivro.TabIndex = 11;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(95, 120);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(100, 20);
            this.txtAutor.TabIndex = 12;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(95, 155);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(100, 20);
            this.txtAno.TabIndex = 13;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(95, 184);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(100, 20);
            this.txtGenero.TabIndex = 14;
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(95, 216);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(100, 20);
            this.txtEditora.TabIndex = 15;
            // 
            // txtPaginas
            // 
            this.txtPaginas.Location = new System.Drawing.Point(402, 165);
            this.txtPaginas.Name = "txtPaginas";
            this.txtPaginas.Size = new System.Drawing.Size(100, 20);
            this.txtPaginas.TabIndex = 16;
            // 
            // rbtDisponivel
            // 
            this.rbtDisponivel.AutoSize = true;
            this.rbtDisponivel.Location = new System.Drawing.Point(98, 253);
            this.rbtDisponivel.Name = "rbtDisponivel";
            this.rbtDisponivel.Size = new System.Drawing.Size(76, 17);
            this.rbtDisponivel.TabIndex = 17;
            this.rbtDisponivel.TabStop = true;
            this.rbtDisponivel.Text = "Disponível";
            this.rbtDisponivel.UseVisualStyleBackColor = true;
            // 
            // rbtIndiponivel
            // 
            this.rbtIndiponivel.AutoSize = true;
            this.rbtIndiponivel.Location = new System.Drawing.Point(208, 253);
            this.rbtIndiponivel.Name = "rbtIndiponivel";
            this.rbtIndiponivel.Size = new System.Drawing.Size(83, 17);
            this.rbtIndiponivel.TabIndex = 18;
            this.rbtIndiponivel.TabStop = true;
            this.rbtIndiponivel.Text = "Indisponível";
            this.rbtIndiponivel.UseVisualStyleBackColor = true;
            // 
            // frmCadastrarLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.rbtIndiponivel);
            this.Controls.Add(this.rbtDisponivel);
            this.Controls.Add(this.txtPaginas);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtNomeLivro);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsInferior);
            this.Controls.Add(this.tsSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Livros";
            this.tsSuperior.ResumeLayout(false);
            this.tsSuperior.PerformLayout();
            this.tsInferior.ResumeLayout(false);
            this.tsInferior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip tsSuperior;
        private System.Windows.Forms.ToolStrip tsInferior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.TextBox txtPaginas;
        private System.Windows.Forms.RadioButton rbtDisponivel;
        private System.Windows.Forms.RadioButton rbtIndiponivel;
        public System.Windows.Forms.ToolStripButton tsbtnGravar;
        public System.Windows.Forms.ToolStripButton tsbtnCancelar;
        public System.Windows.Forms.ToolStripButton tsbtnVoltar;
    }
}