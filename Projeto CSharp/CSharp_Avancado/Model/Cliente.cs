using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Avancado.Model
{
    public class Cliente : Pessoa
    {
        public int ContatoId { get; set; }
        public Contato Contato { get; set; }

        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
    }
}
