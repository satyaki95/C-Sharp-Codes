using System;

class Program
{
    public static void Main(string[] args){

        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine("Positive Number");
        }
        else if(number < 0){
            Console.WriteLine("Negative Number");
        }
        else
        {
           Console.WriteLine("Zero Number"); 
        }

    }
}