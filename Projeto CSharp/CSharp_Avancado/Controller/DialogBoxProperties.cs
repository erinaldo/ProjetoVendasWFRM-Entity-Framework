using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Avancado.Controller
{
    public static class DialogBoxProperties
    {
        public static Image imagemPergunta { get; set; }
        public static string tituloPergunta { get; set; }
        public static string pergunta { get; set; }
        public static string nomeBotaoAfirmacao { get; set; }
        public static string nomeBotaoNegacao { get; set; }
        public static bool resposta { get; set; }
    }
}
