namespace Modulo12;

public class TrabalhandoComExcecoes
{
    public void AulaGerandoException()
    {
        while (true)
        {
            Console.Write("Informe um número: ");
            var numero = Console.ReadLine();
            var resultado = 500 / int.Parse(numero);
            Console.WriteLine("Resultado: " + resultado);
        }
    }

    public void AulaTratandoException()
    {
        while (true)
        {
            Console.Write("Informe um número: ");
            var numero = Console.ReadLine();

            try
            {
                var resultado = 500 / int.Parse(numero);
                Console.WriteLine("Resultado: " + resultado);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Ocorreu um erro de divisão: " + e.Message);
                Console.WriteLine("Stack: " + e.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
                Console.WriteLine("Stack: " + e.StackTrace);
            }
        }
    }
}
