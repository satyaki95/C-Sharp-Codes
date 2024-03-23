using System;
class Program
{
    public static void Main(string[] args){
        int result = 25 + 30;
        Console.WriteLine(result);
        Console.WriteLine(4*9+6);
        Console.WriteLine(7500/30);


        int number1 = 10;
        int number2 = 3;

        Console.WriteLine(number1+number2);
        Console.WriteLine(number1-number2);
        Console.WriteLine(number1*number2);
        Console.WriteLine(number1/number2);
        Console.WriteLine(number1%number2);

    int result2 = number1+number2;

        Console.WriteLine($"{number1} + {number2} = {result2}");

        double div = (double)number1 / number2;
        // Format Spesifier
        Console.WriteLine($"{number1} / {number2} = {div.ToString("F2")}");
    }
}