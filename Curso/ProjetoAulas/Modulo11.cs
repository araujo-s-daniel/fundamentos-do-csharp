namespace Modulo11;

public class TrabalhandoComDatas
{
    public void AulaDateTime()
    {
        var date1 = new DateTime(2012, 12, 02, 19, 22, 23);
        var date2 = DateTime.Parse("2012/12/22 19:25:23");
        var date3 = DateTime.Now;
        var date4 = DateTime.Today;

        Console.WriteLine(date1);
        Console.WriteLine(date2);
        Console.WriteLine(date3);
        Console.WriteLine(date4);

        Console.WriteLine(date1.ToString("dd-MM-yyyy HH:mm:ss"));

        var dateOffset1 = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));
        Console.WriteLine(dateOffset1.LocalDateTime);
        Console.WriteLine(dateOffset1.UtcDateTime);
    }

    public void AulaSubtraindoDatas()
    {
        var data1 = DateTime.Now;
        var data2 = DateTime.Parse("2022-01-01");

        // var diff = data1 - data2;
        var diff = data1.Subtract(data2);
        Console.WriteLine((int)diff.TotalDays);
        Console.WriteLine((int)diff.TotalHours);
    }

    public void AulaAdicionandoDiasMesEAno()
    {
        var data1 = DateTime.Now;
        Console.WriteLine(data1.AddDays(3).ToString("dd/MM/yyyy HH:mm:ss"));
        Console.WriteLine(data1.AddMonths(1).ToString("dd/MM/yyyy HH:mm:ss"));
        Console.WriteLine(data1.AddYears(2).ToString("dd/MM/yyyy HH:mm:ss"));
    }

    public void AulaAdicionandoHorasMinutosESegundos()
    {
        var data1 = DateTime.Now;
        Console.WriteLine(data1.ToString("HH:mm:ss"));
        Console.WriteLine(data1.AddHours(3).ToString("HH:mm:ss"));
        Console.WriteLine(data1.AddMinutes(1).ToString("HH:mm:ss"));
        Console.WriteLine(data1.AddSeconds(2).ToString("HH:mm:ss"));
    }

    public void AulaDiaDaSemana()
    {
        var data1 = DateTime.Now;
        Console.WriteLine(data1.DayOfWeek);
    }

    public void AulaDateOnly()
    {
        //var somenteData = new DateOnly(2022, 12, 2);
        var somenteData = DateOnly.Parse("2022-12-02");
        Console.WriteLine(somenteData.ToString("dd/MM/yyyy"));
    }

    public void AulaTimeOnly()
    {
        //var somenteHora = new TimeOnly(12, 23, 25);
        var somenteHora = TimeOnly.Parse("23:01:23");
        Console.WriteLine(somenteHora.ToString("hh:mm:ss"));
    }
}
