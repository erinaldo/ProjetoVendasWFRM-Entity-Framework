namespace CSharp_Avancado.Model
{
    public class Contato
    {
        public int Id { get; set; }
        public string Telefone { get; set; }
        public string Telefone2 { get; set; }
        public string Email { get; set; }
        //public string Email2 { get; set; }
        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}