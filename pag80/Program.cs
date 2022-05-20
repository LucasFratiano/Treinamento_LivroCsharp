using static System.Console;
using System;
using System.Linq;
using System.Globalization;
namespace pag80;

public class Program
{
    static void Main(string[] args)
    {

        string fodase1 = "150";
        string fodase2 = "50000";
        string fodase3 = "-200";
        string fodase4 = "13123123123";
        string fodase5 = "06/05/2021";
        
        try
        {
            //conversao usando parse
            WriteLine("----.Parse");
            WriteLine($"{int.Parse(fodase1)}");
            WriteLine($"{int.Parse($"({fodase1})", NumberStyles.AllowParentheses)}");//retorna -150, os () represantam o valor negativo

            WriteLine($"{int.Parse(fodase2, NumberStyles.AllowThousands)}");

            WriteLine($"Cultura atual: {CultureInfo.CurrentCulture.Name}");

            WriteLine($"Símbolo da moeda: {NumberFormatInfo.CurrentInfo.CurrencySymbol}");

            WriteLine($"{int.Parse(fodase2, NumberStyles.AllowCurrencySymbol)}");

            //WriteLine($"{int.Parse("R$50000", NumberStyles.AllowCurrencySymbol)}");

            WriteLine($"{int.Parse(fodase3, NumberStyles.AllowLeadingSign)}");

            WriteLine($"{Int64.Parse(fodase4)}");

            WriteLine($"Data:{DateTime.Parse(fodase5): dd/MMMM/yyyy}");
        }

        catch (Exception ex)
        {
            WriteLine(ex);
        }

    }
}
