// namespace Cadastro;

namespace Cadastro
{
    public static class Calculos
    {
        public static int SomarNumeros(int a, int b)
        {
            return a + b;
        }
    }

    public class Produto
    {
        private int Id;
        public string? Descricao { get; set; }
        public int Estoque { get; }
        // public readonly int Estoque;

        public Produto()
        {
            Estoque = 1;
        }

        public void ImprimirDescricao()
        {
            Console.WriteLine(GetId() + " - " + Descricao);
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public int GetId()
        {
            return Id;
        }
    }

    public class Pessoa
    {
        public int Id { get; set; }
        public string? Endereco { get; set; }
        public string? Cidade { get; set; }
        public string? Cep { get; set; }

        public void ImprimirDados()
        {
            Console.WriteLine("Código: " + Id);
            Console.WriteLine("Endereço: " + Endereco);
            Console.WriteLine("Cidade: " + Cidade);
            Console.WriteLine("CEP: " + Cep);
        }
    }

    public class PessoaFisica : Pessoa
    {
        public string? Cpf { get; set; }

        public void ImprimirCpf()
        {
            Console.WriteLine("CPF: " + Cpf);
        }
    }

    public class Funcionario : PessoaFisica
    {
        public string? Matricula { get; set; }
    }

    public sealed class Configuracao
    {
        public string? Host { get; set; }
    }
}