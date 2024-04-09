using System;

class Program
{
    public static void Main(string[] args){
        int number1, number2;

        Console.Write("Enter 2 Number ");

        number1 = Convert.ToInt32(Console.ReadLine());
        number2 = Convert.ToInt32(Console.ReadLine());

        if(number1 > number2){
            Console.WriteLine($"{number1} is Gater Then {number2}");
        }
        else if(number2 > number1){
            Console.WriteLine($"{number2} is Gater Then {number1}");
        }else
    {
        Console.WriteLine($"{number1} is equel to {number2}");
    }
    }
}