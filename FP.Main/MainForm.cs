using System;
using System.Windows.Forms;
using FP.Data;
using System.Linq;
using System.Collections.Generic;
using FP.Entity;



namespace FP.Main
{
    public partial class MainForm : Form
    {
        private bool _ascTipoFinanca = false;
        private bool _ascCodigo = false;
        private bool _ascCategoria = false;
        private bool _ascDescricao = false;
        private bool _ascValor = false;
        private bool _ascData = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PreencheValorInicialCampoData();
            PreencheTipoFinanca();
            PreencheCategoria();
            PreencheGrid(true);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PreencheGrid(false);
        }

        private void dgvResultado_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            using (DB_FINANCASEntities ctx = new DB_FINANCASEntities())
            {
                //if (e.RowCount > 1)
                {
                    //for (int i = 0; i <= e.RowCount; i++)
                    for (int i = e.RowIndex; i < e.RowCount + e.RowIndex; i++)
                    {
                        DataGridViewCellCollection cells = dgvResultado.Rows[i].Cells;

                        TipoFinanca tipoFinanca = new TipoFinanca();
                        Categoria categoria = new Categoria();

                        double valor = double.Parse(cells[7].Value.ToString());
                        int idCategoria = int.Parse(cells[8].Value.ToString());

                        var queryCategoria = from c in ctx.Categorias where c.IdCategoria == idCategoria select c;
                        categoria = queryCategoria.First();

                        var query = from t in ctx.TipoFinancas where t.IdTipoFinanca == categoria.IdTipoFinanca select t;
                        tipoFinanca = query.First();

                        dgvResultado.Rows[i].Cells[5].Value = tipoFinanca.Descricao;
                        dgvResultado.Rows[i].Cells[4].Value = valor.ToString("C2");
                        dgvResultado.Rows[i].Cells[4].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
                        dgvResultado.Rows[i].Cells[1].Value = categoria.Descricao.ToString();

                        switch (tipoFinanca.IdTipoFinanca)
                        {
                            case 2:
                                foreach (DataGridViewCell c in dgvResultado.Rows[i].Cells)
                                {
                                    c.Style.ForeColor = System.Drawing.Color.Red;
                                }
                                break;

                            case 1:
                                foreach (DataGridViewCell c in dgvResultado.Rows[i].Cells)
                                {
                                    c.Style.ForeColor = System.Drawing.Color.Blue;
                                }
                                break;
                        }
                    }
                }
            }
        }

        private void dgvResultado_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip1.Show(dgvResultado, e.X, e.Y);
            }
        }

        public void PreencheGrid(bool load)
        {

            List<Financa> listFin = ObtemDados(load);

            dgvResultado.AutoGenerateColumns = false;
            dgvResultado.DataSource = listFin;

            CriaRodape(listFin);
        }

        private void CriaRodape(List<Financa> listFin)
        {
            double valorTotalDespesa = 0;
            double valorTotalReceita = 0;
            double valorTotal;

            valorTotalDespesa = listFin.Where(f => f.Categoria.IdTipoFinanca == 2).Sum(f => f.Valor);
            valorTotalReceita = listFin.Where(f => f.Categoria.IdTipoFinanca == 1).Sum(f => f.Valor);

            lblSaldo.ForeColor = System.Drawing.Color.Red;
            valorTotal = valorTotalReceita - valorTotalDespesa;

            if (valorTotal > 0)
                lblSaldo.ForeColor = System.Drawing.Color.Blue;

            lblSaldo.Text = "Saldo Atual: " + valorTotal.ToString("C2").Replace("-", string.Empty);
            lblTotaRegistros.Text = "Total de Registros: " + listFin.Count;
        }

        private List<Financa> ObtemDados(bool load)
        {

            List<Financa> listFin = new List<Financa>();

            using (DB_FINANCASEntities ctx = new DB_FINANCASEntities())
            {
                var query = ctx.Financas.Include("Categoria").Where(f => f.Fechada == false);

                if (!load)
                {
                    FinancaFiltro fin = PreencheObjetoFiltro();

                    if (fin.IdCategoria != 0)
                        query = query.Where(c => c.IdCategoria == fin.IdCategoria);

                    if (fin.IdTipoFinanca != 0)
                        query = query.Where(t => t.Categoria.IdTipoFinanca == fin.IdTipoFinanca);

                    query = query.Where(f => (f.Data >= fin.DataInicial && f.Data <= fin.DataFinal));
                }

                listFin = query.OrderByDescending(x => x.Data).ToList();

            }
            return listFin;
        }

        private FinancaFiltro PreencheObjetoFiltro()
        {
            FinancaFiltro fin = new FinancaFiltro();
            fin.IdCategoria = 0;
            fin.IdTipoFinanca = 0;

            if (ddlCategoria.SelectedValue != null)
                if (!ddlCategoria.SelectedValue.ToString().Equals("0"))
                    fin.IdCategoria = int.Parse(ddlCategoria.SelectedValue.ToString());

            if (ddlTipoFinanca.SelectedValue != null)
                if (!ddlTipoFinanca.SelectedValue.ToString().Equals("0"))
                    fin.IdTipoFinanca = int.Parse(ddlTipoFinanca.SelectedValue.ToString());

            fin.DataFinal = DateTime.Parse(txtDataFinal.Text);
            fin.DataInicial = DateTime.Parse(txtDataInicial.Text);


            return fin;
        }

        private void PreencheValorInicialCampoData()
        {
            txtDataInicial.Text = DateTime.Parse("01/01/" + DateTime.Today.Year.ToString()).ToString("dd/MM/yyyy");
            txtDataFinal.Text = DateTime.Parse("31/12/" + DateTime.Today.Year.ToString()).ToString("dd/MM/yyyy");
        }

        private void PreencheTipoFinanca()
        {

            List<TipoFinanca> tipo = new List<TipoFinanca>();

            using (DB_FINANCASEntities ctx = new DB_FINANCASEntities())
            {
                var query = from t in ctx.TipoFinancas select t;
                tipo = query.ToList();
            }

            tipo.Add(new TipoFinanca { IdTipoFinanca = 0, Descricao = "Todas" });

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

            cat.Add(new Categoria { IdCategoria = 0, Descricao = "Todas" });
            ddlCategoria.DataSource = cat.OrderBy(x => x.IdCategoria).ToList();
            ddlCategoria.DisplayMember = "Descricao";
            ddlCategoria.ValueMember = "IdCategoria";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza de que deseja excluir os selecionados?", "Alerta de exclusão", MessageBoxButtons.OKCancel);

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                if (dgvResultado.SelectedRows.Count == 0)
                {
                    MessageBox.Show("É necessário selecionar as linhas que se deseja excluir.");
                }
                else
                {
                    using (DB_FINANCASEntities ctx = new DB_FINANCASEntities())
                    {
                        for (int i = 0; i < dgvResultado.SelectedRows.Count; i++)
                        {
                            Financa fin = new Financa();
                            int id = int.Parse(dgvResultado.SelectedRows[i].Cells[0].Value.ToString());
                            var query = from f in ctx.Financas where f.IdFinanca == id select f;
                            fin = query.First();
                            ctx.Financas.Remove(fin);
                            ctx.SaveChanges();
                        }
                    }

                    PreencheGrid(false);
                }
            }
        }

        private void menuFinancas_Click(object sender, EventArgs e)
        {
            FinancasForm finForm = new FinancasForm(this);
            finForm.ShowDialog();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            switch (dgvResultado.SelectedRows.Count)
            {
                case 0:
                    MessageBox.Show("É necessário selecionar a linha que se deseja alterar.");
                    break;

                case 1:
                    int id = int.Parse(dgvResultado.SelectedRows[0].Cells[0].Value.ToString());
                    FinancasForm finForm = new FinancasForm(id, this);
                    finForm.ShowDialog();
                    break;
                default:
                    MessageBox.Show("Só é permitido realizar a alteração em um registro por vez.");
                    break;
            }
        }

        private void dgvResultado_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<Financa> listFin = ObtemDados(false);
            List<Financa> listFinOrdered = new List<Financa>();

            switch (e.ColumnIndex)
            {
                case 0:
                    if (_ascCodigo)
                        listFinOrdered = listFin.OrderBy(x => x.IdFinanca).ToList();
                    else
                        listFinOrdered = listFin.OrderByDescending(x => x.IdFinanca).ToList();

                    _ascCodigo = !_ascCodigo;
                    break;
                case 1:
                    if (_ascCategoria)
                        listFinOrdered = listFin.OrderBy(x => x.IdCategoria).ToList();
                    else
                        listFinOrdered = listFin.OrderByDescending(x => x.IdCategoria).ToList();

                    _ascCategoria = !_ascCategoria;
                    break;
                case 2:
                    if (_ascDescricao)
                        listFinOrdered = listFin.OrderBy(x => x.Descricao).ToList();
                    else
                        listFinOrdered = listFin.OrderByDescending(x => x.Descricao).ToList();

                    _ascDescricao = !_ascDescricao;
                    break;
                case 3:
                    if (_ascData)
                        listFinOrdered = listFin.OrderBy(x => x.Data).ToList();
                    else
                        listFinOrdered = listFin.OrderByDescending(x => x.Data).ToList();

                    _ascData = !_ascData;
                    break;
                case 4:
                    if (_ascValor)
                        listFinOrdered = listFin.OrderBy(x => x.Valor).ToList();
                    else
                        listFinOrdered = listFin.OrderByDescending(x => x.Valor).ToList();

                    _ascValor = !_ascValor;
                    break;
                case 5:
                    if (_ascTipoFinanca)
                        listFinOrdered = listFin.OrderBy(x => x.Categoria.IdTipoFinanca).ToList();
                    else
                        listFinOrdered = listFin.OrderByDescending(x => x.Categoria.IdTipoFinanca).ToList();

                    _ascTipoFinanca = !_ascTipoFinanca;
                    break;
            }

            dgvResultado.AutoGenerateColumns = false;
            dgvResultado.DataSource = listFinOrdered;
        }

        private void visualizarComprovanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (dgvResultado.SelectedRows.Count)
            {
                case 0:
                    MessageBox.Show("É necessário selecionar a linha que se deseja visualizar o comprovante.");
                    break;

                case 1:
                    int id = int.Parse(dgvResultado.SelectedRows[0].Cells[0].Value.ToString());
                    frmPreview finForm = new frmPreview(id);
                    finForm.ShowDialog();
                    break;
                default:
                    MessageBox.Show("Só é permitido visualizar um comprovante por vez.");
                    break;
            }
        }

    }
}
