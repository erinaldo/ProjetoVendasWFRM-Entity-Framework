using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Avancado.Model
{
    public class Venda
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public int FuncionarioId { get; set; }
        public Funcionario Funcionario { get; set; }

        public double ValorTotalProdutos { get; set; }
        public double ValorDocumento { get; set; }
        public double Acrescimo { get; set; }
        public double Desconto { get; set; }
        public string Observacao { get; set; }
        public Compra Compra { get; set; }
    }
}
