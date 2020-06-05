namespace Sistema_Biblioteca
{
    partial class frmConsultarClientes
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
            this.gpbOpcoes = new System.Windows.Forms.GroupBox();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.rbtNome = new System.Windows.Forms.RadioButton();
            this.rbtCidade = new System.Windows.Forms.RadioButton();
            this.rbtStatus = new System.Windows.Forms.RadioButton();
            this.rbtAtivo = new System.Windows.Forms.RadioButton();
            this.rbtInativo = new System.Windows.Forms.RadioButton();
            this.lsvDados = new System.Windows.Forms.ListView();
            this.tsInferior = new System.Windows.Forms.ToolStrip();
            this.tsbtnVoltar = new System.Windows.Forms.ToolStripButton();
            this.nomeCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.enderecoCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cidadeCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.estadoCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefoneCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpbOpcoes.SuspendLayout();
            this.tsInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbOpcoes
            // 
            this.gpbOpcoes.Controls.Add(this.rbtNome);
            this.gpbOpcoes.Controls.Add(this.rbtCidade);
            this.gpbOpcoes.Controls.Add(this.rbtStatus);
            this.gpbOpcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOpcoes.Location = new System.Drawing.Point(12, 12);
            this.gpbOpcoes.Name = "gpbOpcoes";
            this.gpbOpcoes.Size = new System.Drawing.Size(200, 60);
            this.gpbOpcoes.TabIndex = 0;
            this.gpbOpcoes.TabStop = false;
            this.gpbOpcoes.Text = "Filtro:";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(218, 23);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(304, 20);
            this.txtConsulta.TabIndex = 0;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(447, 49);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // rbtNome
            // 
            this.rbtNome.AutoSize = true;
            this.rbtNome.Checked = true;
            this.rbtNome.Location = new System.Drawing.Point(6, 20);
            this.rbtNome.Name = "rbtNome";
            this.rbtNome.Size = new System.Drawing.Size(57, 17);
            this.rbtNome.TabIndex = 2;
            this.rbtNome.TabStop = true;
            this.rbtNome.Text = "Nome";
            this.rbtNome.UseVisualStyleBackColor = true;
            // 
            // rbtCidade
            // 
            this.rbtCidade.AutoSize = true;
            this.rbtCidade.Location = new System.Drawing.Point(65, 20);
            this.rbtCidade.Name = "rbtCidade";
            this.rbtCidade.Size = new System.Drawing.Size(64, 17);
            this.rbtCidade.TabIndex = 3;
            this.rbtCidade.Text = "Cidade";
            this.rbtCidade.UseVisualStyleBackColor = true;
            // 
            // rbtStatus
            // 
            this.rbtStatus.AutoSize = true;
            this.rbtStatus.Location = new System.Drawing.Point(129, 20);
            this.rbtStatus.Name = "rbtStatus";
            this.rbtStatus.Size = new System.Drawing.Size(61, 17);
            this.rbtStatus.TabIndex = 4;
            this.rbtStatus.Text = "Status";
            this.rbtStatus.UseVisualStyleBackColor = true;
            // 
            // rbtAtivo
            // 
            this.rbtAtivo.AutoSize = true;
            this.rbtAtivo.Checked = true;
            this.rbtAtivo.Location = new System.Drawing.Point(228, 55);
            this.rbtAtivo.Name = "rbtAtivo";
            this.rbtAtivo.Size = new System.Drawing.Size(49, 17);
            this.rbtAtivo.TabIndex = 2;
            this.rbtAtivo.TabStop = true;
            this.rbtAtivo.Text = "Ativo";
            this.rbtAtivo.UseVisualStyleBackColor = true;
            this.rbtAtivo.Visible = false;
            // 
            // rbtInativo
            // 
            this.rbtInativo.AutoSize = true;
            this.rbtInativo.Location = new System.Drawing.Point(337, 55);
            this.rbtInativo.Name = "rbtInativo";
            this.rbtInativo.Size = new System.Drawing.Size(57, 17);
            this.rbtInativo.TabIndex = 3;
            this.rbtInativo.Text = "Inativo";
            this.rbtInativo.UseVisualStyleBackColor = true;
            this.rbtInativo.Visible = false;
            // 
            // lsvDados
            // 
            this.lsvDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvDados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nomeCliente,
            this.enderecoCliente,
            this.cidadeCliente,
            this.estadoCliente,
            this.telefoneCliente,
            this.statusCliente,
            this.codCliente});
            this.lsvDados.FullRowSelect = true;
            this.lsvDados.GridLines = true;
            this.lsvDados.HideSelection = false;
            this.lsvDados.Location = new System.Drawing.Point(12, 89);
            this.lsvDados.MultiSelect = false;
            this.lsvDados.Name = "lsvDados";
            this.lsvDados.Size = new System.Drawing.Size(510, 214);
            this.lsvDados.TabIndex = 4;
            this.lsvDados.UseCompatibleStateImageBehavior = false;
            this.lsvDados.View = System.Windows.Forms.View.Details;
            this.lsvDados.SelectedIndexChanged += new System.EventHandler(this.lsvDados_SelectedIndexChanged);
            // 
            // tsInferior
            // 
            this.tsInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsInferior.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnVoltar});
            this.tsInferior.Location = new System.Drawing.Point(0, 306);
            this.tsInferior.Name = "tsInferior";
            this.tsInferior.Size = new System.Drawing.Size(534, 55);
            this.tsInferior.TabIndex = 5;
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
            // nomeCliente
            // 
            this.nomeCliente.Text = "Nome do Cliente";
            this.nomeCliente.Width = 121;
            // 
            // enderecoCliente
            // 
            this.enderecoCliente.Text = "Endereço";
            this.enderecoCliente.Width = 107;
            // 
            // cidadeCliente
            // 
            this.cidadeCliente.Text = "Cidade";
            this.cidadeCliente.Width = 92;
            // 
            // estadoCliente
            // 
            this.estadoCliente.Text = "Estado";
            this.estadoCliente.Width = 96;
            // 
            // telefoneCliente
            // 
            this.telefoneCliente.Text = "Telefone";
            // 
            // statusCliente
            // 
            this.statusCliente.Text = "Status";
            // 
            // codCliente
            // 
            this.codCliente.Text = "Código";
            // 
            // frmConsultarClientes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.tsInferior);
            this.Controls.Add(this.lsvDados);
            this.Controls.Add(this.rbtInativo);
            this.Controls.Add(this.rbtAtivo);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.gpbOpcoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Clientes";
            this.gpbOpcoes.ResumeLayout(false);
            this.gpbOpcoes.PerformLayout();
            this.tsInferior.ResumeLayout(false);
            this.tsInferior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbOpcoes;
        private System.Windows.Forms.RadioButton rbtNome;
        private System.Windows.Forms.RadioButton rbtCidade;
        private System.Windows.Forms.RadioButton rbtStatus;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.RadioButton rbtAtivo;
        private System.Windows.Forms.RadioButton rbtInativo;
        private System.Windows.Forms.ListView lsvDados;
        public System.Windows.Forms.ToolStrip tsInferior;
        public System.Windows.Forms.ToolStripButton tsbtnVoltar;
        public System.Windows.Forms.ColumnHeader nomeCliente;
        public System.Windows.Forms.ColumnHeader enderecoCliente;
        public System.Windows.Forms.ColumnHeader cidadeCliente;
        public System.Windows.Forms.ColumnHeader estadoCliente;
        public System.Windows.Forms.ColumnHeader telefoneCliente;
        public System.Windows.Forms.ColumnHeader statusCliente;
        public System.Windows.Forms.ColumnHeader codCliente;
    }
}