using CSharp_Avancado.Model;
using CSharp_Avancado.View;
using Microsoft.EntityFrameworkCore;

namespace CSharp_Avancado.Controller
{
    internal class DBCContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Funcionario> Vendedores { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Contato> Contatos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Compra> Compras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-SQRS0ER\SQLEXPRESS;Database=ProjetoVendas;Trusted_Connection=true;");
            //optionsBuilder.UseSqlServer($@"Server=DEVPARTNER03\PARTNERSQL;Database=ProjetoVendas;Trusted_Connection=true;");
            optionsBuilder.UseSqlServer($@"Server={Frm_Principal.nomeInstancia};Database=ProjetoVendas;Trusted_Connection=true;");
        }
    }
}
