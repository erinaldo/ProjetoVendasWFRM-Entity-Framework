using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Avancado
{
    public static class Defaults
    {
        // Mask
        public static string dataMask = "00/00/0000";
        public static string cepMask = "00000-000";
        public static string cpfMask = "000,000,000-00";
        public static string rgMask = "0000000-0";
        public static string cnpjMask = "00,000,000/0000-00";
        public static string telefoneMask = "(00)00000-0000";
        public static char senhaMask = '*';
        // Fonts
        public static Font microsoftSansSerif10 = new Font("Micrososft Sans Serif", 10f);
        public static Font microsoftSansSerif10Bold = new Font("Micrososft Sans Serif", 10f, FontStyle.Bold);
        public static Font microsoftSansSerif12 = new Font("Micrososft Sans Serif", 12f);
        public static Font microsoftSansSerif12Bold = new Font("Micrososft Sans Serif", 12f, FontStyle.Bold);
        public static Font fontPadraoTituloJanelas16Bold = new Font("Microsoft Sans Serif", 16f, FontStyle.Bold);
        // Picture Size
        public static PictureBoxSizeMode stretchImageStyle = PictureBoxSizeMode.StretchImage;
        // Form Start Position
        public static FormStartPosition frmStartPointAtCenterScreen = FormStartPosition.CenterScreen;
        public static FormStartPosition frmStartPointAtParentCenter = FormStartPosition.CenterParent;
        public static FormBorderStyle frmNoneBorderStyle = FormBorderStyle.None;

        // Resources
        static ResourceManager rm = CSharp_Avancado.Properties.Resources.ResourceManager;

        // Return Bitmap Image from project resources
        public static Bitmap getImageByName(string resourceImageName)
        {
            Bitmap imagem = (Bitmap)rm.GetObject(resourceImageName);
            Bitmap imagemPadrao = (Bitmap)rm.GetObject("imagem");
            return imagem != null ? imagem : imagemPadrao;
        }
        // Return Icon Image from project resources
        public static Icon getIconByName(string resourceIconName)
        {
            Icon icone = (Icon)rm.GetObject(resourceIconName);
            Icon iconePadrao = (Icon)rm.GetObject("link_quebrado");
            return icone != null ? icone : iconePadrao;
        }

        // Return Combo Box de estados
        public static string[] enumEstados()
        {
            string[] estados = { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB",
                                 "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" };
            return estados;
        }

        // Diretorios
        private static string RootPath = Path.GetPathRoot(Environment.SystemDirectory);
        public static string AppPath = $"{RootPath}/ProjetoVendas";
        public static string ImagesPath = $"{AppPath}/Imagens";
    }
}
