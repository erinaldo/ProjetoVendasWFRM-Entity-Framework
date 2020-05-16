using CSharp_Avancado.Model;
using CSharp_Avancado.View;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_Avancado.Controller
{
    public class DBC
    {
        // gloabal var
        Frm_BOX_DialogBox dialogBox = new Frm_BOX_DialogBox();

        public DBC()
        {
            dialogBox
            .DialogBox(
                 Defaults.getImageByName("informacao"),
                 "Operação Concluída",
                 "Operação realizada com sucesso.",
                 true,
                 false,
                 "Ok",
                 ""
            );
        }


        private static void DisplayStates(IEnumerable<EntityEntry> entries)
        {
            foreach (var entry in entries)
            {
                Console.WriteLine($"Entity: {entry.Entity.GetType().Name}, State: { entry.State.ToString()}");
            }
        }

        public void InserirProduto(Produto produto)
        {
            using (var contexto = new DBCContext())
            {
                contexto.Produtos.Add(produto);                
                contexto.SaveChanges();
                dialogBox.Show();
            }
        }

        public void InserirCliente(Cliente cliente)
        {
            using (var contexto =  new DBCContext())
            {
                contexto.Clientes.Add(cliente);
                contexto.SaveChanges();
                dialogBox.Show();
            }
        }

        public void InserirFuncionario(Funcionario funcionario)
        {
            using (var contexto = new DBCContext())
            {
                contexto.Vendedores.Add(funcionario);
                contexto.SaveChanges();
                dialogBox.Show();
            }
        }

        public void InserirFornecedor(Fornecedor fornecedor)
        {
            using (var contexto = new DBCContext())
            {
                contexto.Fornecedores.Add(fornecedor);
                contexto.SaveChanges();
                dialogBox.Show();
            }
        }


        public void InserirVenda(Venda venda, List<Produto> produtos, List<int> quantidades)
        {
            List<Compra> produtosDaCompra = new List<Compra>();

            using (var contexto = new DBCContext())
            {
                contexto.Vendas.Add(venda);
                contexto.SaveChanges();

                int i = 0;
                foreach (var produto in produtos)
                {
                    produtosDaCompra.Add(new Compra { VendaId = Convert.ToString(venda.Id), ProdutoId = Convert.ToString(produto.Id), QuantidadeProduto = quantidades[i] });
                    i++;
                }

                if (produtosDaCompra != null)
                {
                    contexto.Compras.AddRange(produtosDaCompra);
                    contexto.SaveChanges();
                }

                dialogBox.Show();
            }
        }

        public void InserirUsuario(Usuario usuario)
        {
            using (var contexto = new DBCContext())
            {
                contexto.Usuarios.Add(usuario);

                contexto.SaveChanges();
                dialogBox.Show();
            }
        }

        public Usuario RecuperaLogin(string usuario, string senha)
        {
            Usuario us = null;

            using (var contexto = new DBCContext())
            {
                var login = contexto.Usuarios
                    .FromSqlInterpolated($"SELECT * FROM Usuarios WHERE usuario = {usuario} AND senha = {senha}")
                    .ToList();

                if (login.Count > 0)
                {
                    us = new Usuario { Id = login[0].Id, usuario = login[0].usuario, senha = login[0].senha };
                }
            }

            return us;
        }

        public string RecuperarUsuario(string usuario)
        {
            string nomeUsuario = "";

            using (var contexto = new DBCContext())
            {
                var login = contexto.Usuarios
                    .FromSqlInterpolated($"SELECT * FROM Usuarios WHERE usuario = {usuario}")
                    .ToList();

                if (login.Count > 0)
                {
                    nomeUsuario = login[0].usuario;
                }
            }

            return nomeUsuario;
        }

        public List<Produto> RecuperarProdutos()
        {
            using (var contexto = new DBCContext())
            {
                var resultado = contexto.Produtos
                    .ToList();

                return resultado;
            }
        }

        public List<Produto> RecuperarProdutosPeloID(int idVenda)
        {
            using (var contexto = new DBCContext())
            {
                var resultado = contexto.Compras
                    .Where(c => c.VendaId == Convert.ToString(idVenda))
                    .ToList();

                List<int> listaDeIds = new List<int>();

                foreach (var item in resultado)
                {
                    listaDeIds.Add(Convert.ToInt32(item.ProdutoId));
                }

                var produtos = contexto.Produtos
                    .Where(p => listaDeIds.Contains(p.Id))
                    .OrderByDescending(p => p.Id)
                    .ToList();

                return produtos;
            }
        }


        public List<Compra> RecuperarQuantidadesProdutosPeloID(int idVenda)
        {
            using (var contexto = new DBCContext())
            {
                var resultado = contexto.Compras
                    .Where(c => c.VendaId == Convert.ToString(idVenda))
                    .OrderByDescending(c => c.ProdutoId)
                    .ToList();

                return resultado;
            }
        }

        public Cliente RecuperarUnicoCliente(int id)
        {
            using (var contexto = new DBCContext())
            {
                var resultado = contexto.Clientes
                    .Where(c => c.Id == id)
                    .ToList();

                return resultado[0];
            }
        }

        public Funcionario RecuperarUnicoFuncionario(int id)
        {
            using (var contexto = new DBCContext())
            {
                var resultado = contexto.Vendedores
                    .Where(v => v.Id == id)
                    .ToList();

                return resultado[0];
            }
        }

        public List<Fornecedor> RecuperarFornecedores()
        {
            using (var contexto = new DBCContext())
            {
                var resultado = (from f in contexto.Fornecedores
                                 join cc in contexto.Contatos on f.ContatoId equals cc.Id
                                 join e in contexto.Enderecos on f.EnderecoId equals e.Id
                                 select new Fornecedor {
                                     Id = f.Id,
                                     NomeFantasia = f.NomeFantasia,
                                     RamoAtuacao = f.RamoAtuacao,
                                     CNPJ = f.CNPJ,
                                     Contato = new Contato
                                     {
                                         Id = cc.Id,
                                         Telefone = cc.Telefone,
                                         Telefone2 = cc.Telefone2,
                                         Email = cc.Email
                                     },
                                     Endereco = new Endereco
                                     {
                                         Id = e.Id,
                                         CEP = e.CEP,
                                         UF = e.UF,
                                         Cidade = e.Cidade,
                                         Bairro = e.Bairro,
                                         Logradouro = e.Logradouro
                                     }
                                 })
                                 .ToList();

                return resultado;
            }
        }


        public List<Cliente> RecuperarClientes()
        {
            using (var contexto = new DBCContext())
            {
                var resultado = (from c in contexto.Clientes
                         join cc in contexto.Contatos on c.ContatoId equals cc.Id
                         join e in contexto.Enderecos on c.EnderecoId equals e.Id
                         select new Cliente {
                             Id = c.Id,
                             Nome = c.Nome,
                             DataNascimento = c.DataNascimento,
                             CPF = c.CPF,
                             Contato = new Contato
                             {
                                 Id = cc.Id,
                                 Telefone = cc.Telefone,
                                 Telefone2 = cc.Telefone2,
                                 Email = cc.Email
                             },
                             Endereco = new Endereco {
                                 Id = e.Id,
                                 CEP = e.CEP,
                                 UF = e.UF,
                                 Cidade = e.Cidade,
                                 Bairro = e.Bairro,
                                 Logradouro = e.Logradouro
                             }
                         })
                         .ToList();

                return resultado;
            }
        }
        
        public List<Funcionario> RecuperarFuncionarios()
        {
            using (var contexto = new DBCContext())
            {
                var resultado = (from f in contexto.Vendedores
                                 join cc in contexto.Contatos on f.ContatoId equals cc.Id
                                 join e in contexto.Enderecos on f.EnderecoId equals e.Id
                                 select new Funcionario {
                                     Id = f.Id,
                                     Nome = f.Nome,
                                     DataNascimento = f.DataNascimento,
                                     CPF = f.CPF,
                                     Salario = f.Salario,
                                     Cargo = f.Cargo,
                                     RG = f.RG,
                                     Contato = new Contato
                                     {
                                         Id = cc.Id,
                                         Telefone = cc.Telefone,
                                         Telefone2 = cc.Telefone2,
                                         Email = cc.Email
                                     },
                                     Endereco = new Endereco
                                     {
                                         Id = e.Id,
                                         CEP = e.CEP,
                                         UF = e.UF,
                                         Cidade = e.Cidade,
                                         Bairro = e.Bairro,
                                         Logradouro = e.Logradouro
                                     }
                                 })
                    .ToList();

                return resultado;
            }
        }
        
        public List<Venda> RecuperarVendas()
        {
            using (var contexto = new DBCContext())
            {
                var resultado = (from v in contexto.Vendas
                                 join c in contexto.Clientes on v.ClienteId equals c.Id
                                 join f in contexto.Vendedores on v.FuncionarioId equals f.Id
                                 select new Venda {
                                     Id = v.Id,
                                     ValorDocumento = v.ValorDocumento,
                                     ValorTotalProdutos = v.ValorTotalProdutos,
                                     Acrescimo = v.Acrescimo,
                                     Desconto = v.Desconto,
                                     Observacao = v.Observacao,
                                     Cliente = new Cliente {
                                         Id = c.Id,
                                         Nome = c.Nome,
                                         CPF = c.CPF,
                                         DataNascimento = c.DataNascimento
                                     },
                                     Funcionario = new Funcionario {
                                         Id = f.Id,
                                         Nome = f.Nome,
                                         CPF = f.CPF,
                                         RG = f.RG,
                                         DataNascimento = f.DataNascimento,
                                         Cargo = f.Cargo,
                                         Salario = f.Salario
                                     },
                                 })
                                 .ToList();

                return resultado;
            }
        }

        public void AtualizarProduto(Produto produto)
        {
            using (var contexto = new DBCContext())
            {
                var prod = contexto.Produtos
                    .First(p => p.Id == produto.Id);
                
                prod.Descricao = produto.Descricao;
                prod.Tipo = produto.Tipo;
                prod.Marca = produto.Marca;
                //prod.Validade = produto.Validade;
                prod.Quantidade = produto.Quantidade;
                prod.PrecoCompra = produto.PrecoCompra;
                prod.PrecoVenda = produto.PrecoVenda;
                prod.Imagem = produto.Imagem;
                
                contexto.SaveChanges();
                dialogBox.Show();
            }
        }

        public void AtualizarFornecedor(Fornecedor fornecedor)
        {
            using (var contexto = new DBCContext())
            {
                var fornec = contexto.Fornecedores
                    .Include(f => f.Contato)
                    .Include(f => f.Endereco)
                    .Where(f => f.Id == fornecedor.Id)
                    .FirstOrDefault();

                fornec.NomeFantasia = fornecedor.NomeFantasia;
                fornec.RamoAtuacao = fornecedor.RamoAtuacao;
                fornec.CNPJ = fornecedor.CNPJ;
                // Contato
                fornec.Contato.Telefone = fornecedor.Contato.Telefone;
                fornec.Contato.Telefone2 = fornecedor.Contato.Telefone2;
                fornec.Contato.Email = fornecedor.Contato.Email;
                // Endereco
                fornec.Endereco.CEP = fornecedor.Endereco.CEP;
                fornec.Endereco.UF = fornecedor.Endereco.UF;
                fornec.Endereco.Cidade = fornecedor.Endereco.Cidade;
                fornec.Endereco.Bairro = fornecedor.Endereco.Bairro;
                fornec.Endereco.Logradouro = fornecedor.Endereco.Logradouro;

                contexto.SaveChanges();
                dialogBox.Show();
            }
        }

        public void AtualizarCliente(Cliente cliente)
        {
            using (var contexto = new DBCContext())
            {
                var cli = contexto.Clientes
                    .Include(c => c.Contato)
                    .Include(c => c.Endereco)
                    .Where(c => c.Id == cliente.Id)
                    .FirstOrDefault();

                cli.Nome = cliente.Nome;
                cli.DataNascimento = cliente.DataNascimento;
                cli.CPF = cliente.CPF;
                // Contato
                cli.Contato.Telefone = cliente.Contato.Telefone;
                cli.Contato.Telefone2 = cliente.Contato.Telefone2;
                cli.Contato.Email = cliente.Contato.Email;
                // Endereco
                cli.Endereco.CEP = cliente.Endereco.CEP;
                cli.Endereco.UF = cliente.Endereco.UF;
                cli.Endereco.Cidade = cliente.Endereco.Cidade;
                cli.Endereco.Bairro = cliente.Endereco.Bairro;
                cli.Endereco.Logradouro = cliente.Endereco.Logradouro;

                contexto.SaveChanges();
                dialogBox.Show();
            }
        }
        
        public void AtualizarFuncionario(Funcionario funcionario)
        {
            using (var contexto = new DBCContext())
            {
                var func = contexto.Vendedores
                    .Include(v => v.Endereco)
                    .Include(v => v.Contato)
                    .Where(v => v.Id == funcionario.Id)
                    .FirstOrDefault();

                func.Nome = funcionario.Nome;
                func.DataNascimento = funcionario.DataNascimento;
                func.CPF = funcionario.CPF;
                func.Salario = funcionario.Salario;
                func.Cargo = funcionario.Cargo;
                func.RG = funcionario.RG;
                // Contato
                func.Contato.Telefone = funcionario.Contato.Telefone;
                func.Contato.Telefone2 = funcionario.Contato.Telefone2;
                func.Contato.Email = funcionario.Contato.Email;
                // Endereco
                func.Endereco.CEP = funcionario.Endereco.CEP;
                func.Endereco.UF = funcionario.Endereco.UF;
                func.Endereco.Cidade = funcionario.Endereco.Cidade;
                func.Endereco.Bairro = funcionario.Endereco.Bairro;
                func.Endereco.Logradouro = funcionario.Endereco.Logradouro;

                contexto.SaveChanges();
                dialogBox.Show();
            }
        }
        
        public void AtualizarVenda(Venda venda, List<Produto> produtos, List<int> quantidadeVendida)
        {
            using (var contexto = new DBCContext())
            {
                var ven = contexto.Vendas
                    .Include(v => v.Funcionario)
                    .Include(v => v.Cliente)
                    .FirstOrDefault(v => v.Id == venda.Id);

                var com = contexto.Compras
                    .Where(c => Convert.ToInt32(c.VendaId) == venda.Id);

                // Vendas
                ven.ClienteId = venda.ClienteId;
                ven.FuncionarioId = venda.FuncionarioId;
                ven.ValorDocumento = venda.ValorDocumento;
                ven.ValorTotalProdutos = venda.ValorTotalProdutos;
                ven.Acrescimo = venda.Acrescimo;
                ven.Desconto = venda.Desconto;
                ven.Observacao = venda.Observacao;
                // Compras
                int i = 0;
                foreach (var item in com)
                {
                    item.ProdutoId = produtos[i].Id.ToString();
                    item.QuantidadeProduto = quantidadeVendida[i];
                    i++;
                }

                List<Compra> diferencas = new List<Compra>();
                var itensExistentes = com.Select(c => c.ProdutoId).ToList();

                for (int j = 0; j < produtos.Count; j++)
                {
                    if (!( itensExistentes.Contains(produtos[j].Id.ToString()) ))
                        diferencas.Add(new Compra { ProdutoId = produtos[j].Id.ToString(), VendaId = ven.Id.ToString(), QuantidadeProduto = quantidadeVendida[j] });
                }

                if (diferencas.Count > 0)
                {
                    contexto.AddRange(diferencas);
                }
                
                contexto.SaveChanges();
            }
        }

        public void ExcluirProduto(Produto produto)
        {
            using (var contexto = new DBCContext())
            {
                var prod = contexto.Produtos
                    .First(p => p.Id == produto.Id);

                contexto.Remove(prod);
                contexto.SaveChanges();
                dialogBox.Show();
            }
        }

        public void ExcluirFornecedor(Fornecedor fornecedor)
        {
            using (var contexto = new DBCContext())
            {
                var fornec = contexto.Fornecedores
                    .Include(f => f.Contato)
                    .Include(f => f.Endereco)
                    .First(f => f.Id == fornecedor.Id);

                contexto.Remove(fornec);
                contexto.Remove(fornec.Endereco);
                contexto.Remove(fornec.Contato);
                contexto.SaveChanges();
                dialogBox.Show();
            }
        }
        
        public void ExcluirCliente(Cliente cliente)
        {
            using (var contexto = new DBCContext())
            {
                var cli = contexto.Clientes
                    .Include(c => c.Contato)
                    .Include(c => c.Endereco)
                    .Where(c => c.Id == cliente.Id)
                    .FirstOrDefault();

                contexto.Remove(cli);
                contexto.Remove(cli.Endereco);
                contexto.Remove(cli.Contato);
                contexto.SaveChanges();
                dialogBox.Show();
            }
        }

        public void ExcluirFuncionario(Funcionario funcionario)
        {
            using (var contexto = new DBCContext())
            {
                var func = contexto.Vendedores
                    .Include(v => v.Endereco)
                    .Include(v => v.Contato)
                    .Where(v => v.Id == funcionario.Id)
                    .FirstOrDefault();

                contexto.Remove(func);
                contexto.Remove(func.Endereco);
                contexto.Remove(func.Contato);
                contexto.SaveChanges();
                dialogBox.Show();
            }
        }
        
        public void ExcluirVenda(Venda venda, List<Produto> produtos, List<int> quantidadeVendida)
        {
            using (var contexto = new DBCContext())
            {
                var ven = contexto.Vendas
                    .Include(v => v.Funcionario)
                    .Include(v => v.Cliente)
                    .FirstOrDefault(v => v.Id == venda.Id);

                var com = contexto.Compras
                    .Where(c => Convert.ToInt32(c.VendaId) == venda.Id);

                // Vendas
                contexto.Remove(ven);
                // Compras
                int i = 0;
                foreach (var item in com)
                {
                    contexto.Remove(item);
                    i++;
                }

                contexto.SaveChanges();
            }
        }
    }
}
