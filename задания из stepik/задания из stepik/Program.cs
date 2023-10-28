
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;



public class Selector
{
    public int[] Array;

    public Selector(int[] array)
    {
        Array = array;
    }

    public void PrintOdds()
    {
        for (int i = 0; i < Array.Length; i++)
        {
            if (Array[i]%2 != 0)
            {
                Console.Write(Array[i] + " ");
            }    
                   
        }
    }

    public void PrintEvens()
    {
        for (int i = 0; i < Array.Length; i++)
        {
            if (Array[i] % 2 == 0)
            {
                Console.Write(Array[i] + " ");
            }

        }
    }


}
class Program
    {

        static void Main()

        {

        int[] numbers = new int[] { -11, - 12, 13, 14 };
        Selector selector = new Selector(numbers);

        selector.PrintOdds(); // 1 3 5
        Console.WriteLine();
        selector.PrintEvens(); // 2 4 6

        Console.ReadKey();

        }


    }
