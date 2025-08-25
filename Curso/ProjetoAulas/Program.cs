// Console.WriteLine("Primeiro Programa");

using System;

namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            // AulaClasses();
            // AulaPropriedadeSomenteLeitura();
            // AulaHeranca();
            // AulaClasseSelada();
            AulaClasseAbstrata();
        }

        private static void AulaClasseAbstrata()
        {
            var animal = new Cadastro.Cachorro();
            animal.Nome = "Totó";
            animal.ImprimirDados();
        }

        private static void AulaClasseSelada()
        {
            // var configuracao = new Cadastro.Configuracao();
            // configuracao.Host = "localhost";

            var configuracao = new Cadastro.Configuracao
            {
                Host = "localhost"
            };

            Console.WriteLine(configuracao.Host);
        }

        private static void AulaHeranca()
        {
            // var pessoaFisica = new Cadastro.PessoaFisica();
            // pessoaFisica.Cep = "12345678";
            // pessoaFisica.Cidade = "Cidade Teste";
            // pessoaFisica.Cpf = "12345678901";
            // pessoaFisica.Endereco = "Endereço Teste";
            // pessoaFisica.Id = 1;
            // pessoaFisica.ImprimirDados();
            // pessoaFisica.ImprimirCpf();

            var funcionario = new Cadastro.Funcionario();
            funcionario.Cep = "12345678";
            funcionario.Cidade = "Cidade Teste";
            funcionario.Cpf = "12345678901";
            funcionario.Endereco = "Endereço Teste";
            funcionario.Id = 10;
            funcionario.ImprimirDados();
            funcionario.ImprimirCpf();
        }

        private static void AulaPropriedadeSomenteLeitura()
        {
            var produto = new Cadastro.Produto();
            produto.Descricao = "Mouse";
            // produto.Estoque = 1;
            Console.WriteLine(produto.Estoque);
        }

        private static void AulaClasses()
        {
            // var produto = new Cadastro.Produto();
            // produto.SetId(1);
            // produto.Descricao = "Teclado";
            // produto.ImprimirDescricao();
            // Console.WriteLine(produto.GetId());

            var resultado = Cadastro.Calculos.SomarNumeros(2, 3);
            Console.WriteLine(resultado);
        }
    }
}

/*
namespace Cadastros
{
    public class Cliente
    {

    }

    public class Funcionario
    {

    }
}

namespace Financeiro
{
    public class ContaReceber
    {

    }
    
    public class Funcionario
    {
        
    }
}
*/
