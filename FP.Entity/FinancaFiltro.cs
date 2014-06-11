using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP.Entity
{
    public class FinancaFiltro
    {
        public int IdFinanca { get; set; }
        public int IdCategoria { get; set; }
        public int IdTipoFinanca { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public bool Fechada { get; set; }
        public bool Paga { get; set; }
        public System.DateTime DataInicial { get; set; }
        public System.DateTime DataFinal { get; set; }
    
    }
}
