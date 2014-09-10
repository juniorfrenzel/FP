namespace FP.Main
{
    partial class FinancasForm
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
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlTipoFinanca = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFileUpload = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtComprovante = new System.Windows.Forms.TextBox();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(30, 218);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(521, 29);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(30, 40);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(398, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtData
            // 
            this.txtData.CustomFormat = "dd/MM/yyyy";
            this.txtData.Location = new System.Drawing.Point(434, 40);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(117, 20);
            this.txtData.TabIndex = 3;
            this.txtData.Value = new System.DateTime(2014, 5, 3, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data";
            // 
            // ddlCategoria
            // 
            this.ddlCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCategoria.FormattingEnabled = true;
            this.ddlCategoria.Location = new System.Drawing.Point(30, 109);
            this.ddlCategoria.Name = "ddlCategoria";
            this.ddlCategoria.Size = new System.Drawing.Size(121, 21);
            this.ddlCategoria.TabIndex = 5;
            this.ddlCategoria.SelectedIndexChanged += new System.EventHandler(this.ddlCategoria_SelectedIndexChanged);
            this.ddlCategoria.SelectionChangeCommitted += new System.EventHandler(this.ddlCategoria_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo Finança";
            // 
            // ddlTipoFinanca
            // 
            this.ddlTipoFinanca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTipoFinanca.FormattingEnabled = true;
            this.ddlTipoFinanca.Location = new System.Drawing.Point(157, 108);
            this.ddlTipoFinanca.Name = "ddlTipoFinanca";
            this.ddlTipoFinanca.Size = new System.Drawing.Size(121, 21);
            this.ddlTipoFinanca.TabIndex = 7;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(284, 110);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(118, 20);
            this.txtValor.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnFileUpload);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtComprovante);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ddlTipoFinanca);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtData);
            this.panel1.Controls.Add(this.ddlCategoria);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 263);
            this.panel1.TabIndex = 11;
            // 
            // btnFileUpload
            // 
            this.btnFileUpload.Location = new System.Drawing.Point(434, 172);
            this.btnFileUpload.Name = "btnFileUpload";
            this.btnFileUpload.Size = new System.Drawing.Size(30, 20);
            this.btnFileUpload.TabIndex = 13;
            this.btnFileUpload.Text = "...";
            this.btnFileUpload.UseVisualStyleBackColor = true;
            this.btnFileUpload.Click += new System.EventHandler(this.btnFileUpload_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Comprovante";
            // 
            // txtComprovante
            // 
            this.txtComprovante.Location = new System.Drawing.Point(30, 172);
            this.txtComprovante.MaxLength = 50;
            this.txtComprovante.Name = "txtComprovante";
            this.txtComprovante.ReadOnly = true;
            this.txtComprovante.Size = new System.Drawing.Size(398, 20);
            this.txtComprovante.TabIndex = 11;
            // 
            // fileDialog
            // 
            this.fileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.fileDialog_FileOk);
            // 
            // FinancasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 285);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FinancasForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Novo Registro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FinancasForm_FormClosing);
            this.Load += new System.EventHandler(this.FinancasForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddlTipoFinanca;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtComprovante;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Button btnFileUpload;
    }
}