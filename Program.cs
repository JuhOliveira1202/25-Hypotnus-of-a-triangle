using System;

//Descobrir a hipotenusa de um triângulo
class Program
{
    public static void Main(string[] args)
    {

        Console.Write("Introduza o valor de A: ");
         double a = Convert.ToDouble(Console.ReadLine());

         Console.Write("Introduza o valor de B: ");
         double b = Convert.ToDouble(Console.ReadLine());

         double c = Math.Sqrt((a*a) + (b*b));
         Console.WriteLine("A hipotnusa é: " + c);

    }
}