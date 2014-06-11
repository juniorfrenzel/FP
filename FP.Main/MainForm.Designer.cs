namespace FP.Main
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.ID_FINANCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTipoRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoFinanca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFinancas = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblTipoFinanca = new System.Windows.Forms.Label();
            this.ddlTipoFinanca = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.ddlCategoria = new System.Windows.Forms.ComboBox();
            this.lblate = new System.Windows.Forms.Label();
            this.txtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.txtDataInicial = new System.Windows.Forms.DateTimePicker();
            this.StRodape = new System.Windows.Forms.StatusStrip();
            this.lblTotaRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.visualizarComprovanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.StRodape.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_FINANCA,
            this.categoria,
            this.DESCRICAO,
            this.DATA,
            this.dgvValor,
            this.dgvTipoRegistro,
            this.tipoFinanca,
            this.valor,
            this.cat});
            this.dgvResultado.Location = new System.Drawing.Point(12, 99);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.Size = new System.Drawing.Size(593, 279);
            this.dgvResultado.TabIndex = 4;
            this.dgvResultado.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvResultado_ColumnHeaderMouseClick);
            this.dgvResultado.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvResultado_RowsAdded);
            this.dgvResultado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvResultado_MouseClick);
            // 
            // ID_FINANCA
            // 
            this.ID_FINANCA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_FINANCA.DataPropertyName = "IdFinanca";
            this.ID_FINANCA.FillWeight = 20F;
            this.ID_FINANCA.HeaderText = "Código";
            this.ID_FINANCA.Name = "ID_FINANCA";
            this.ID_FINANCA.ReadOnly = true;
            this.ID_FINANCA.Visible = false;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DESCRICAO.DataPropertyName = "Descricao";
            this.DESCRICAO.HeaderText = "Descrição";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.ReadOnly = true;
            this.DESCRICAO.Width = 80;
            // 
            // DATA
            // 
            this.DATA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DATA.DataPropertyName = "Data";
            this.DATA.HeaderText = "Data de Registro";
            this.DATA.Name = "DATA";
            this.DATA.ReadOnly = true;
            this.DATA.Width = 103;
            // 
            // dgvValor
            // 
            this.dgvValor.HeaderText = "Valor";
            this.dgvValor.Name = "dgvValor";
            this.dgvValor.ReadOnly = true;
            // 
            // dgvTipoRegistro
            // 
            this.dgvTipoRegistro.HeaderText = "Tipo do Registro";
            this.dgvTipoRegistro.Name = "dgvTipoRegistro";
            this.dgvTipoRegistro.ReadOnly = true;
            // 
            // tipoFinanca
            // 
            this.tipoFinanca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tipoFinanca.DataPropertyName = "IdTipoFinanca";
            this.tipoFinanca.HeaderText = "Tipo de Registro (invisivel)";
            this.tipoFinanca.Name = "tipoFinanca";
            this.tipoFinanca.ReadOnly = true;
            this.tipoFinanca.Visible = false;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "Valor";
            this.valor.HeaderText = "Valor (invisivel)";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Visible = false;
            // 
            // cat
            // 
            this.cat.DataPropertyName = "IdCategoria";
            this.cat.HeaderText = "Categoria (Invisivel)";
            this.cat.Name = "cat";
            this.cat.ReadOnly = true;
            this.cat.Visible = false;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(617, 24);
            this.menu.TabIndex = 5;
            this.menu.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFinancas});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // menuFinancas
            // 
            this.menuFinancas.Name = "menuFinancas";
            this.menuFinancas.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuFinancas.Size = new System.Drawing.Size(163, 22);
            this.menuFinancas.Text = "Financas";
            this.menuFinancas.Click += new System.EventHandler(this.menuFinancas_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.lblTipoFinanca);
            this.panel1.Controls.Add(this.ddlTipoFinanca);
            this.panel1.Controls.Add(this.lblCategoria);
            this.panel1.Controls.Add(this.ddlCategoria);
            this.panel1.Controls.Add(this.lblate);
            this.panel1.Controls.Add(this.txtDataFinal);
            this.panel1.Controls.Add(this.lblDataFinal);
            this.panel1.Controls.Add(this.lblDataInicial);
            this.panel1.Controls.Add(this.txtDataInicial);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 66);
            this.panel1.TabIndex = 6;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(513, 28);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblTipoFinanca
            // 
            this.lblTipoFinanca.AutoSize = true;
            this.lblTipoFinanca.Location = new System.Drawing.Point(379, 14);
            this.lblTipoFinanca.Name = "lblTipoFinanca";
            this.lblTipoFinanca.Size = new System.Drawing.Size(72, 13);
            this.lblTipoFinanca.TabIndex = 10;
            this.lblTipoFinanca.Text = "Tipo Finança:";
            // 
            // ddlTipoFinanca
            // 
            this.ddlTipoFinanca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTipoFinanca.FormattingEnabled = true;
            this.ddlTipoFinanca.Location = new System.Drawing.Point(382, 30);
            this.ddlTipoFinanca.Name = "ddlTipoFinanca";
            this.ddlTipoFinanca.Size = new System.Drawing.Size(121, 21);
            this.ddlTipoFinanca.TabIndex = 9;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(247, 14);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Categoria:";
            // 
            // ddlCategoria
            // 
            this.ddlCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCategoria.FormattingEnabled = true;
            this.ddlCategoria.Location = new System.Drawing.Point(250, 30);
            this.ddlCategoria.Name = "ddlCategoria";
            this.ddlCategoria.Size = new System.Drawing.Size(121, 21);
            this.ddlCategoria.TabIndex = 7;
            // 
            // lblate
            // 
            this.lblate.AutoSize = true;
            this.lblate.Location = new System.Drawing.Point(114, 33);
            this.lblate.Name = "lblate";
            this.lblate.Size = new System.Drawing.Size(22, 13);
            this.lblate.TabIndex = 6;
            this.lblate.Text = "até";
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.CustomFormat = "dd/MM/yyyy";
            this.txtDataFinal.Location = new System.Drawing.Point(142, 29);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(102, 20);
            this.txtDataFinal.TabIndex = 5;
            this.txtDataFinal.Value = new System.DateTime(2014, 12, 31, 0, 0, 0, 0);
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.AutoSize = true;
            this.lblDataFinal.Location = new System.Drawing.Point(142, 13);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(58, 13);
            this.lblDataFinal.TabIndex = 4;
            this.lblDataFinal.Text = "Data Final:";
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.AutoSize = true;
            this.lblDataInicial.Location = new System.Drawing.Point(3, 13);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(63, 13);
            this.lblDataInicial.TabIndex = 3;
            this.lblDataInicial.Text = "Data Inicial:";
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.CausesValidation = false;
            this.txtDataInicial.CustomFormat = "dd/MM/yyyy";
            this.txtDataInicial.Location = new System.Drawing.Point(6, 29);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Size = new System.Drawing.Size(102, 20);
            this.txtDataInicial.TabIndex = 1;
            this.txtDataInicial.Value = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            // 
            // StRodape
            // 
            this.StRodape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTotaRegistros});
            this.StRodape.Location = new System.Drawing.Point(0, 421);
            this.StRodape.Name = "StRodape";
            this.StRodape.Size = new System.Drawing.Size(617, 22);
            this.StRodape.TabIndex = 7;
            this.StRodape.Text = "statusStrip1";
            // 
            // lblTotaRegistros
            // 
            this.lblTotaRegistros.Name = "lblTotaRegistros";
            this.lblTotaRegistros.Size = new System.Drawing.Size(118, 17);
            this.lblTotaRegistros.Text = "toolStripStatusLabel1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.btnAlterar,
            this.visualizarComprovanteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(200, 70);
            this.contextMenuStrip1.Text = "Ações";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.toolStripMenuItem1.Text = "Deletar Selecionados";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(199, 22);
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoEllipsis = true;
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSaldo.Location = new System.Drawing.Point(12, 381);
            this.lblSaldo.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblSaldo.MinimumSize = new System.Drawing.Size(590, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSaldo.Size = new System.Drawing.Size(590, 13);
            this.lblSaldo.TabIndex = 8;
            this.lblSaldo.Text = "label1";
            this.lblSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // visualizarComprovanteToolStripMenuItem
            // 
            this.visualizarComprovanteToolStripMenuItem.Name = "visualizarComprovanteToolStripMenuItem";
            this.visualizarComprovanteToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.visualizarComprovanteToolStripMenuItem.Text = "Visualizar Comprovante";
            this.visualizarComprovanteToolStripMenuItem.Click += new System.EventHandler(this.visualizarComprovanteToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(617, 443);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.StRodape);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Financas Pessoal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.StRodape.ResumeLayout(false);
            this.StRodape.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuFinancas;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.Label lblDataInicial;
        private System.Windows.Forms.DateTimePicker txtDataInicial;
        private System.Windows.Forms.Label lblate;
        private System.Windows.Forms.DateTimePicker txtDataFinal;
        private System.Windows.Forms.ComboBox ddlCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblTipoFinanca;
        private System.Windows.Forms.ComboBox ddlTipoFinanca;
        private System.Windows.Forms.StatusStrip StRodape;
        private System.Windows.Forms.ToolStripStatusLabel lblTotaRegistros;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnAlterar;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_FINANCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTipoRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoFinanca;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cat;
        private System.Windows.Forms.ToolStripMenuItem visualizarComprovanteToolStripMenuItem;
    }
}

