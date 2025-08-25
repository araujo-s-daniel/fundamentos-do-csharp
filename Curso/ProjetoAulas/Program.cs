// Console.WriteLine("Primeiro Programa");

using System;

namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            // AulaClasses();
            AulaPropriedadeSomenteLeitura();
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
