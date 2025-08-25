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
}