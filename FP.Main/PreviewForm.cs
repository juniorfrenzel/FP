using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FP.Data;

namespace FP.Main
{
    public partial class frmPreview : Form
    {
        private int _id = 0;
        public frmPreview()
        {
            InitializeComponent();
        }

        public frmPreview(int id)
        {
            _id = id;
            InitializeComponent();
        }

        private void frmPreview_Load(object sender, EventArgs e)
        {
            if (_id == 0)
            {
                MessageBox.Show("Comprovante não encontrado.");
                this.Close();
            }

            using (DB_FINANCASEntities context = new DB_FINANCASEntities())
            {
                byte[] comprovante = (from c in context.Financas where c.IdFinanca == _id select c.Comprovante).First();
                string path = Path.GetTempFileName();
                File.WriteAllBytes(path, comprovante);

                PrintDocument p = new PrintDocument();
                p.DocumentName = path;
                pdfView.LoadFile(path);
                File.Delete(path);
            }


        }
    }
}
