using System.Collections.Generic;

namespace CSharp_Avancado.Model
{
    public class Compra
    {
        public int Id { get; set; }

        public string VendaId { get; set; }
        public string ProdutoId { get; set; }
        public int QuantidadeProduto { get; set; }
        //public int VendaId { get; set; }
        //public Venda Venda { get; set; }
        //public int ProdutoId { get; set; }
        //public Produto Produto { get; set; }
    }
}