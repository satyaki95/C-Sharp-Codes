using System;

class Program
{
    public static void Main(string[] args)
    {
        int number1,number2,number3;

        Console.Write("Number 1 = ");
        number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Number 2 = ");
        number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Number 3 = ");
        number3 = Convert.ToInt32(Console.ReadLine());

        int check = number1 > number2 && number1 > number3 ? number1 : number2 > number3 ? number2 : number3;

        Console.WriteLine($"{check} is Greater Number");
    }
}