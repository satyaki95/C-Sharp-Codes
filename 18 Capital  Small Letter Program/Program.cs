using System;

class Program
{
    public static void Main(string[] args){
        char letter;

        Console.Write("Enter Any Letter = ");
        letter = Convert.ToChar(Console.ReadLine());

        if(letter >= 'A' && letter <= 'Z'){
            Console.WriteLine($"{letter} is Capital Letter");
        }else
        {
             Console.WriteLine($"{letter} is Small Letter");
        }
    }
}