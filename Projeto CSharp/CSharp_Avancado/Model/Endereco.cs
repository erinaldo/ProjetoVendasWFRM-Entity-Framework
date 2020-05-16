namespace CSharp_Avancado.Model
{
    public class Endereco
    {
        public int Id { get; set; }
        public string CEP { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Logradouro { get; set; }
        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}