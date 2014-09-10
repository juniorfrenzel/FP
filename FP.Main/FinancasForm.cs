using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FP.Data;

namespace FP.Main
{
    public partial class FinancasForm : Form
    {
        private byte[] _comprovante = null;
        private int _id = 0;
        private MainForm _parent;

        public FinancasForm()
        {
            InitializeComponent();
        }

        public FinancasForm(MainForm form)
        {
            this._parent = form;
            InitializeComponent();
        }

        public FinancasForm(int id, MainForm form)
        {
            this._id = id;
            this._parent = form;
            InitializeComponent();
        }

        private void FinancasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._parent.PreencheGrid(false);
        }

        private void FinancasForm_Load(object sender, EventArgs e)
        {
            PreencheTipoFinanca();
            PreencheCategoria();
            txtData.Value = DateTime.Today;
            ddlTipoFinanca.Enabled = false;

            if (_id != 0)
                PreencheCampos();

            AlteraTipoFinanca();
        }

        private void PreencheCampos()
        {
            using (DB_FINANCASEntities ctx = new DB_FINANCASEntities())
            {
                Financa fin = ctx.Financas.Where(f => f.IdFinanca == _id).SingleOrDefault();
                Categoria categoria = ctx.Categorias.Where(c => c.IdCategoria == fin.IdCategoria).SingleOrDefault(); 
                if (fin != null)
                {

                    txtNome.Text = fin.Descricao;
                    txtValor.Text = fin.Valor.ToString();
                    txtData.Text = fin.Data.ToString();
                    ddlCategoria.SelectedValue = fin.IdCategoria;
                    ddlTipoFinanca.SelectedValue = categoria.IdTipoFinanca;
                    _comprovante = fin.Comprovante;
                }
            }
        }

        private void PreencheTipoFinanca()
        {

            List<TipoFinanca> tipo = new List<TipoFinanca>();

            using (DB_FINANCASEntities ctx = new DB_FINANCASEntities())
            {
                var query = from t in ctx.TipoFinancas select t;
                tipo = query.ToList();
            }

            ddlTipoFinanca.DataSource = tipo.OrderBy(x => x.IdTipoFinanca).ToList();
            ddlTipoFinanca.DisplayMember = "Descricao";
            ddlTipoFinanca.ValueMember = "IdTipoFinanca";
        }

        private void PreencheCategoria()
        {
            List<Categoria> cat = new List<Categoria>();

            using (DB_FINANCASEntities ctx = new DB_FINANCASEntities())
            {
                var query = from t in ctx.Categorias select t;
                cat = query.ToList();
            }

            ddlCategoria.DataSource = cat.OrderBy(x => x.IdCategoria).ToList();
            ddlCategoria.DisplayMember = "Descricao";
            ddlCategoria.ValueMember = "IdCategoria";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCampos();

                using (DB_FINANCASEntities ctx = new DB_FINANCASEntities())
                {
                    Financa fin = new Financa()
                    {
                        IdCategoria = int.Parse(ddlCategoria.SelectedValue.ToString()),
                        Data = DateTime.Parse(txtData.Text.ToString()),
                        Descricao = txtNome.Text,
                        Paga = true,
                        Valor = double.Parse(txtValor.Text)
                    };

                    byte[] comprovante = ObterComprovante();

                    if (comprovante != null)
                        fin.Comprovante = comprovante;

                    if (_id == 0)
                    {
                        ctx.Financas.Add(fin);
                    }
                    else
                    {
                        fin.IdFinanca = _id;
                        if (fin.Comprovante == null)
                            fin.Comprovante = _comprovante;
                        ctx.Entry(fin).State = EntityState.Modified;
                    }

                    ctx.SaveChanges();

                    MessageBox.Show("Operação realizada com sucesso.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private byte[] ObterComprovante()
        {

            if (!string.IsNullOrEmpty(fileDialog.FileName.Trim()))
            {
                return  File.ReadAllBytes(fileDialog.FileName.Trim());
            }
            else
                return null;
        }

        private void ValidarCampos()
        {
            double valor = 0;

            if (string.IsNullOrEmpty(txtNome.Text.Trim()))
                throw new Exception("Campo nome é obrigatório");

            if (string.IsNullOrEmpty(txtValor.Text.Trim()))
                throw new Exception("Campo valor é obrigatório");
            else
            {
                if (!double.TryParse(txtValor.Text, out valor))
                    throw new Exception("Campo valor deve possuir um valor válido.");
            }
        }


        private void btnFileUpload_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();
        }

        private void fileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string arquivoComprovante = string.Empty;
            if (!e.Cancel)
                arquivoComprovante = fileDialog.FileName;

            txtComprovante.Text = arquivoComprovante;
        }

        private void ddlCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void AlteraTipoFinanca()
        {
           int tipoFinanca = ObterFinancaSelecionada(int.Parse(ddlCategoria.SelectedValue.ToString()));
           ddlTipoFinanca.SelectedValue = tipoFinanca;
        } 

        private int ObterFinancaSelecionada(int tipoSelecionado)
        {
            int retorno = 0;

            using (DB_FINANCASEntities financas = new DB_FINANCASEntities())
            {
                retorno = financas.Categorias.Where(c => c.IdCategoria == tipoSelecionado).Single().IdTipoFinanca.Value;
            }

            return retorno;

        }

        private void ddlCategoria_SelectionChangeCommitted(object sender, EventArgs e)
        {
            AlteraTipoFinanca();
        }

    }
}
