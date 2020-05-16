using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Avancado.Controller
{
    public class Uteis
    {
        public static string GeraJSONCEP(string CEP)
        {
            try
            {
                System.Net.HttpWebRequest requisicao = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + CEP + "/json/");
                HttpWebResponse resposta = (HttpWebResponse)requisicao.GetResponse();
                int count;
                byte[] buffer = new byte[1000];
                StringBuilder sb = new StringBuilder();
                string temp;
                Stream stream = resposta.GetResponseStream();
                do
                {
                    count = stream.Read(buffer, 0, buffer.Length);
                    //temp = Encoding.Default.GetString(buffer, 0, count).Trim();
                    temp = Encoding.UTF8.GetString(buffer, 0, count).Trim();
                    sb.Append(temp);

                } while (count > 0);
                return sb.ToString();
            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("Ocorreu um erro ao buscar CEP, tente novamente.");
                return "";
            }
        }

        public string AbrirPasta()
        {
            OpenFileDialog Db = new OpenFileDialog();
            Db.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);

            var caminhoDoArquivoEscolhido = "";

            Db.Filter = "All|*.*|PNG|*.PNG|JPG|*.JPG";
            Db.Title = "Escolha a Imagem";

            if (Db.ShowDialog() == DialogResult.OK)
            {
                caminhoDoArquivoEscolhido = Db.FileName;
            }

            return caminhoDoArquivoEscolhido != "" ? caminhoDoArquivoEscolhido : null;
        }

        public static void CriarDiretorios()
        {
            Directory.CreateDirectory(Defaults.AppPath);
            Directory.CreateDirectory(Defaults.ImagesPath);
        }

        public static void CriarArquivoDeConfiguracao(string nomeInstancia)
        {
            using (var fs = new FileStream($"{Defaults.AppPath}/config.txt", FileMode.Create))
            using (var sw = new StreamWriter(fs))
            {
                sw.Write(nomeInstancia);
            }
        }

        public static string RecuperarNomeInstancia()
        {
            var instancia = "";
            var arquivoConfig = $"{Defaults.AppPath}/config.txt";

            if (File.Exists(arquivoConfig))
            {
                using (var fs = new FileStream(arquivoConfig, FileMode.Open))
                using (var sw = new StreamReader(fs))
                {
                    instancia = sw.ReadLine();
                }
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao recuperar o banco de dados, por favor verifique a aba de configurações antes de tentar acessar.", "ERRO");
            }

            return instancia;
        }
    }
}
