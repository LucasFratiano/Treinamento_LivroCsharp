using static System.Console;
namespace desafio1;

public class ProgramDesafio
{

    static void Main(string[] args)
    {

        for (int i = 1; i < 60; i++)
        {
            WriteLine($"Segundos: {i}");
            Thread.Sleep(1000);

            if (i >= 55)
            {
                WriteLine("O tempo está acabando, em breve a tela será limpa.");
            }

            Console.Clear();

        }

        //Console.Clear();

    }



}
