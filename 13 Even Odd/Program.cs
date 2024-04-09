using System;

class Program
{
    public static void Main(string[] args){
        int number ;
        Console.Write("Enter A Number = ");
        number = Convert.ToInt32(Console.ReadLine());

        if(number/2 == 0){
            Console.WriteLine($"{number} Is Even Number");
        }else
        {
            Console.WriteLine($"{number} Is Odd Number");
        }
}
}