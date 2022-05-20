using static System.Console;
using System;
using System.Linq;
using System.Globalization;

namespace convertto;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            int n1;
            Int32 n2;
            Int64 n3;
            decimal preco;
            string texto1;
            string texto2;
            DateTime natal;
            bool valido;

            //Conversoes Convert.To
            WriteLine("-----------Convert Numeros");
            n1 = Convert.ToInt16("100");
            WriteLine($"{n1.GetType()} - {n1}");

            n2 = Convert.ToInt32("200500");
            WriteLine($"{n2.GetType()} - {n2}");

            n3 = Convert.ToInt64("10032321313211321");
            WriteLine($"{n3.GetType()} - {n3}");

            preco = Convert.ToDecimal("1420,50");
            WriteLine($"{preco.GetType()} - {preco:n2}");

            WriteLine("-------Convert String");

            texto1 = Convert.ToString(250.59M);
            WriteLine($"{texto1.GetType()} - {texto1} - resultado: {texto1 ?? "texto é nulo"} ");

            texto2 = Convert.ToString(DateTime.Today);
            WriteLine($"{texto2.GetType()} - {texto2}");

            WriteLine("-------Convert Boleano");
            valido = Convert.ToBoolean("false");
            WriteLine($"{valido.GetType()} - {valido}");
            WriteLine($"0 - {Convert.ToBoolean(0)}");
            WriteLine($"1 - {Convert.ToBoolean(1)}");
            WriteLine($"100 - {Convert.ToBoolean(100)}");

            WriteLine("-------Convert Data");

            natal = Convert.ToDateTime("25/12/2021");
            WriteLine($"Natal: {natal.GetType()} - {natal:dd/MMMMM/yyyy}");
            WriteLine($"Natal: {natal.Day} - {natal.Month} - {natal.Year}");

        }
        catch (Exception ex)
        {
            WriteLine(ex);
        }






    }
}