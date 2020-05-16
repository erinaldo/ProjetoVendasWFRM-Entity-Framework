using System;
using System.Drawing;

namespace CSharp_Avancado.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public int Quantidade { get; set; }
        public double PrecoCompra { get; set; }
        public double PrecoVenda { get; set; }
        public string Imagem { get; set; }
    }
}
