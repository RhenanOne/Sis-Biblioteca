namespace Sistema_Biblioteca
{
    partial class frmCadastrarFuncionario
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.ddlEstado = new System.Windows.Forms.ComboBox();
            this.mtbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtbDataAdmissao = new System.Windows.Forms.MaskedTextBox();
            this.mtbDataDemissao = new System.Windows.Forms.MaskedTextBox();
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
            this.tsSuperior.Text = "tsSuperior";
            // 
            // tsbtnGravar
            // 
            this.tsbtnGravar.Image = global::Sistema_Biblioteca.Properties.Resources.gravar_pequeno;
            this.tsbtnGravar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnGravar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnGravar.Name = "tsbtnGravar";
            this.tsbtnGravar.Size = new System.Drawing.Size(212, 52);
            this.tsbtnGravar.Text = "Gravar Dados do Funcionário";
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
            this.tsInferior.Text = "tsInferior";
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
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(100, 67);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(341, 13);
            this.lbTitulo.TabIndex = 2;
            this.lbTitulo.Text = "Preencha os dados corretamente e clique em gravar dados";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome Completo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Endereço:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Telefone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cargo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Data Admissão:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Data Demissão:";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(122, 283);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(100, 20);
            this.txtCargo.TabIndex = 13;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(122, 188);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 20);
            this.txtCidade.TabIndex = 14;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(122, 155);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(100, 20);
            this.txtEndereco.TabIndex = 15;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(122, 125);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 16;
            // 
            // ddlEstado
            // 
            this.ddlEstado.FormattingEnabled = true;
            this.ddlEstado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.ddlEstado.Location = new System.Drawing.Point(122, 218);
            this.ddlEstado.Name = "ddlEstado";
            this.ddlEstado.Size = new System.Drawing.Size(121, 21);
            this.ddlEstado.TabIndex = 17;
            // 
            // mtbTelefone
            // 
            this.mtbTelefone.Location = new System.Drawing.Point(122, 249);
            this.mtbTelefone.Mask = "(99) 99999-9999";
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.Size = new System.Drawing.Size(100, 20);
            this.mtbTelefone.TabIndex = 18;
            // 
            // mtbDataAdmissao
            // 
            this.mtbDataAdmissao.Location = new System.Drawing.Point(419, 199);
            this.mtbDataAdmissao.Mask = "00/00/0000";
            this.mtbDataAdmissao.Name = "mtbDataAdmissao";
            this.mtbDataAdmissao.Size = new System.Drawing.Size(100, 20);
            this.mtbDataAdmissao.TabIndex = 19;
            this.mtbDataAdmissao.ValidatingType = typeof(System.DateTime);
            // 
            // mtbDataDemissao
            // 
            this.mtbDataDemissao.Location = new System.Drawing.Point(419, 249);
            this.mtbDataDemissao.Mask = "00/00/0000";
            this.mtbDataDemissao.Name = "mtbDataDemissao";
            this.mtbDataDemissao.Size = new System.Drawing.Size(100, 20);
            this.mtbDataDemissao.TabIndex = 20;
            this.mtbDataDemissao.ValidatingType = typeof(System.DateTime);
            // 
            // frmCadastrarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.mtbDataDemissao);
            this.Controls.Add(this.mtbDataAdmissao);
            this.Controls.Add(this.mtbTelefone);
            this.Controls.Add(this.ddlEstado);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.tsInferior);
            this.Controls.Add(this.tsSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Funcionários";
            this.Load += new System.EventHandler(this.frmCadastrarFuncionario_Load);
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
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox ddlEstado;
        private System.Windows.Forms.MaskedTextBox mtbTelefone;
        private System.Windows.Forms.MaskedTextBox mtbDataAdmissao;
        private System.Windows.Forms.MaskedTextBox mtbDataDemissao;
        public System.Windows.Forms.ToolStripButton tsbtnVoltar;
        public System.Windows.Forms.ToolStripButton tsbtnGravar;
        public System.Windows.Forms.ToolStripButton tsbtnCancelar;
    }
}