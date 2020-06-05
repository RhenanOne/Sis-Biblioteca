namespace Sistema_Biblioteca
{
    partial class frmConsultarFuncionario
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
            this.tsbtnVoltar = new System.Windows.Forms.ToolStripButton();
            this.lsvDados = new System.Windows.Forms.ListView();
            this.nomeFunc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endFunc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cidFunc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.estadoFunc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telFunc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cargoFunc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codFunc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbtInativo = new System.Windows.Forms.RadioButton();
            this.rbtAtivo = new System.Windows.Forms.RadioButton();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.gpbOpcoes = new System.Windows.Forms.GroupBox();
            this.rbtNome = new System.Windows.Forms.RadioButton();
            this.rbtEstado = new System.Windows.Forms.RadioButton();
            this.rbtCargo = new System.Windows.Forms.RadioButton();
            this.tsInferior.SuspendLayout();
            this.gpbOpcoes.SuspendLayout();
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
            this.tsInferior.TabIndex = 19;
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
            // lsvDados
            // 
            this.lsvDados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvDados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nomeFunc,
            this.endFunc,
            this.cidFunc,
            this.estadoFunc,
            this.telFunc,
            this.cargoFunc,
            this.codFunc});
            this.lsvDados.FullRowSelect = true;
            this.lsvDados.GridLines = true;
            this.lsvDados.HideSelection = false;
            this.lsvDados.Location = new System.Drawing.Point(12, 80);
            this.lsvDados.MultiSelect = false;
            this.lsvDados.Name = "lsvDados";
            this.lsvDados.Size = new System.Drawing.Size(510, 214);
            this.lsvDados.TabIndex = 18;
            this.lsvDados.UseCompatibleStateImageBehavior = false;
            this.lsvDados.View = System.Windows.Forms.View.Details;
            // 
            // nomeFunc
            // 
            this.nomeFunc.Text = "Nome do Funcionário";
            this.nomeFunc.Width = 121;
            // 
            // endFunc
            // 
            this.endFunc.Text = "Endereço";
            this.endFunc.Width = 107;
            // 
            // cidFunc
            // 
            this.cidFunc.Text = "Cidade";
            this.cidFunc.Width = 92;
            // 
            // estadoFunc
            // 
            this.estadoFunc.Text = "Estado";
            this.estadoFunc.Width = 96;
            // 
            // telFunc
            // 
            this.telFunc.Text = "Telefone";
            this.telFunc.Width = 86;
            // 
            // cargoFunc
            // 
            this.cargoFunc.Text = "Cargo";
            // 
            // codFunc
            // 
            this.codFunc.Text = "Código";
            // 
            // rbtInativo
            // 
            this.rbtInativo.AutoSize = true;
            this.rbtInativo.Location = new System.Drawing.Point(337, 46);
            this.rbtInativo.Name = "rbtInativo";
            this.rbtInativo.Size = new System.Drawing.Size(57, 17);
            this.rbtInativo.TabIndex = 17;
            this.rbtInativo.Text = "Inativo";
            this.rbtInativo.UseVisualStyleBackColor = true;
            this.rbtInativo.Visible = false;
            // 
            // rbtAtivo
            // 
            this.rbtAtivo.AutoSize = true;
            this.rbtAtivo.Checked = true;
            this.rbtAtivo.Location = new System.Drawing.Point(228, 46);
            this.rbtAtivo.Name = "rbtAtivo";
            this.rbtAtivo.Size = new System.Drawing.Size(49, 17);
            this.rbtAtivo.TabIndex = 16;
            this.rbtAtivo.TabStop = true;
            this.rbtAtivo.Text = "Ativo";
            this.rbtAtivo.UseVisualStyleBackColor = true;
            this.rbtAtivo.Visible = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(447, 40);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 15;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(218, 14);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(304, 20);
            this.txtConsulta.TabIndex = 13;
            // 
            // gpbOpcoes
            // 
            this.gpbOpcoes.Controls.Add(this.rbtNome);
            this.gpbOpcoes.Controls.Add(this.rbtEstado);
            this.gpbOpcoes.Controls.Add(this.rbtCargo);
            this.gpbOpcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOpcoes.Location = new System.Drawing.Point(12, 3);
            this.gpbOpcoes.Name = "gpbOpcoes";
            this.gpbOpcoes.Size = new System.Drawing.Size(200, 60);
            this.gpbOpcoes.TabIndex = 14;
            this.gpbOpcoes.TabStop = false;
            this.gpbOpcoes.Text = "Filtro:";
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
            // rbtEstado
            // 
            this.rbtEstado.AutoSize = true;
            this.rbtEstado.Location = new System.Drawing.Point(65, 20);
            this.rbtEstado.Name = "rbtEstado";
            this.rbtEstado.Size = new System.Drawing.Size(64, 17);
            this.rbtEstado.TabIndex = 3;
            this.rbtEstado.Text = "Estado";
            this.rbtEstado.UseVisualStyleBackColor = true;
            // 
            // rbtCargo
            // 
            this.rbtCargo.AutoSize = true;
            this.rbtCargo.Location = new System.Drawing.Point(133, 20);
            this.rbtCargo.Name = "rbtCargo";
            this.rbtCargo.Size = new System.Drawing.Size(58, 17);
            this.rbtCargo.TabIndex = 4;
            this.rbtCargo.Text = "Cargo";
            this.rbtCargo.UseVisualStyleBackColor = true;
            // 
            // frmConsultarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "frmConsultarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Funcionários";
            this.tsInferior.ResumeLayout(false);
            this.tsInferior.PerformLayout();
            this.gpbOpcoes.ResumeLayout(false);
            this.gpbOpcoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip tsInferior;
        public System.Windows.Forms.ToolStripButton tsbtnVoltar;
        private System.Windows.Forms.ListView lsvDados;
        public System.Windows.Forms.ColumnHeader nomeFunc;
        public System.Windows.Forms.ColumnHeader endFunc;
        public System.Windows.Forms.ColumnHeader cidFunc;
        public System.Windows.Forms.ColumnHeader estadoFunc;
        public System.Windows.Forms.ColumnHeader telFunc;
        public System.Windows.Forms.ColumnHeader cargoFunc;
        public System.Windows.Forms.ColumnHeader codFunc;
        private System.Windows.Forms.RadioButton rbtInativo;
        private System.Windows.Forms.RadioButton rbtAtivo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.GroupBox gpbOpcoes;
        private System.Windows.Forms.RadioButton rbtNome;
        private System.Windows.Forms.RadioButton rbtEstado;
        private System.Windows.Forms.RadioButton rbtCargo;
    }
}