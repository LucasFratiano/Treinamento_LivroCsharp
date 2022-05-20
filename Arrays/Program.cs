using static System.Console;
using System;
using System.Linq;
using System.Globalization;

namespace ArraysEx{

public class Program
{
    static void Main()
    {
        int[] primeiroArray = new int[100]; //array int com 100 
        int[] segundoArray = new int[] {1,3,5,7,9}; //array já atribuindo valores
        int[] terceiroArray = { 1, 2, 3, 4, 5, 6 }; //sem informar o tipo da info do array
        int[,] arrayMultiDimensional = new int[2, 3]; //array multidimensional
        int[,] arrayMultiDimensional2 = { { 1, 2, 3 }, { 4, 5, 6 } };

        WriteLine("Valor da array pos 0 -> {0}\nPosicao 1 -> {1}", segundoArray[0], segundoArray[1]);
        WriteLine();


        }

    }
}