// Console.WriteLine("Primeiro Programa");

using System;
using Modulo10;

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
            // AulaClasseAbstrata();
            // AulaRecord();
            // AulaInterface();
            // Conversores();
            // AulaTryParse();
            TrabalhandoComStrings();
        }

        private static void TrabalhandoComStrings()
        {
            var trabalhandoComStrings = new Modulo10.TrabalhandoComStrings();
            //trabalhandoComStrings.ConverterParaLetrasMinusculas();
            //trabalhandoComStrings.ConverterParaLetrasMaisculas();
            trabalhandoComStrings.AulaSubstring();
        }

        private static void AulaTryParse()
        {
            var numero = "abc";
            int numeroConvertido;

            if (int.TryParse(numero, out numeroConvertido))
            {
                Console.WriteLine("Número foi convertido com sucesso");
            }

            Console.WriteLine(numeroConvertido);
        }

        private static void Conversores()
        {
            var conversores = new Conversores.Conversor();
            conversores.ConvertAndParse();
        }

        private static void AulaInterface()
        {
            var notificacaoCliente = new Cadastro.NotificacaoCliente();
            notificacaoCliente.Notificar();
            notificacaoCliente.NotificarOutros();

            Cadastro.INotificacao notificacao = new Cadastro.NotificacaoFuncionario();
            notificacao.Notificar();
        }

        private static void AulaRecord()
        {
            // var curso1 = new Cadastro.Curso { Id = 1, Descricao = "Curso" };
            // var curso2 = new Cadastro.Curso { Id = 1, Descricao = "Curso" };
            var curso1 = new Cadastro.Curso(1, "Curso");
            var curso2 = curso1 with { Descricao = "Teste Novo" };

            // Console.WriteLine(curso1.Equals(curso2));
            // Console.WriteLine(curso1 == curso2);

            // var curso1 = new Cadastro.CursoTeste { Id = 1, Descricao = "Curso" };
            // var curso2 = curso1;
            // curso2.Descricao = "Teste Teste";
            // var curso2 = new Cadastro.CursoTeste();
            // curso2.Id = curso1.Id;
            // curso2.Descricao = "Nova descrição";
            Console.WriteLine(curso1.Descricao);
            Console.WriteLine(curso2.Descricao);
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
