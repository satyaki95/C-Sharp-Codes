using System;

class Program
{
    public static void Main(String[] args){
        int number;

        Console.Write("Enter A Year = ");

        number = Convert.ToInt32(Console.ReadLine());

        if(number % 400 == 0){
            Console.WriteLine($"{number} Leap Year");
        }
        else if(number % 400 == 0 && number % 100 != 0){
            Console.WriteLine($"{number} Leap Year");
        }
        else
        {
           Console.WriteLine($"{number} Is Not Leap Year"); 
        }
    }
}