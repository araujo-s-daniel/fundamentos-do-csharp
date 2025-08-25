namespace Modulo10;

public class TrabalhandoComStrings
{
    public void ConverterParaLetrasMinusculas()
    {
        Console.Write("Favor digitar alguma informação: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha?.ToLower());
    }

    public void ConverterParaLetrasMaisculas()
    {
        Console.Write("Favor digitar alguma informação: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha?.ToUpper());
    }

    public void AulaSubstring()
    {
        Console.Write("Favor digitar alguma informação: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha?.Substring(0, 6));
        Console.WriteLine(linha?.Substring(6, 5));
        Console.WriteLine(linha?.Substring(6));
    }

    public void AulaRange()
    {
        string nomeArquivo = "2022_12_01_backup.bak";
        var ano = nomeArquivo[..4];
        Console.WriteLine(ano);
        var extensao = nomeArquivo[^3..];
        Console.WriteLine(extensao);

        var nome = nomeArquivo[11..^4];
        Console.WriteLine(nome);

        var apenasNome = nomeArquivo[..^4];
        Console.WriteLine(apenasNome);
    }

    public void AulaContains()
    {
        string nomeArquivo = "2022_12_01_backup.bak";
        // Console.WriteLine("Contém nome: " + nomeArquivo.Contains("backup"));

        if (nomeArquivo.Contains("backup"))
        {
            Console.WriteLine("Palavra Encontrada");
        }
        else
        {
            Console.WriteLine("Palavra Não Encontrada");
        }
    }

    public void AulaTrim()
    {
        string teste = "**RAFAEL ALMEIDA**";
        Console.WriteLine("TOTAL: " + teste.Trim('*'));
        Console.WriteLine("INICIO: " + teste.TrimStart('*'));
        Console.WriteLine("FINAL: " + teste.TrimEnd('*'));
    }
}