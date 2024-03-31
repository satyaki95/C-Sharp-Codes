class Program
{
    public static void Main(string[] args){

        int number1,number2,number3;

        number1 = 20;
        number2 = 30;
        number3 = 50;
        // Assignment Operator

        number1 += number2;
        Console.WriteLine($"{number1}");

        number1 -= number2;
        Console.WriteLine($"{number1}");

        // Relation Operator

        Console.WriteLine($"{number1 > number2}");
        Console.WriteLine($"{number1 >= number2}");
        Console.WriteLine($"{number1 < number2}");
        Console.WriteLine($"{number1 <= number2}");
        Console.WriteLine($"{number1 == number2}");
        Console.WriteLine($"{number1 != number2}");

        // Logical Operator

        Console.WriteLine(8 > 9 && 8 < 9 && 13 > 9);
        Console.WriteLine(8 > 9 || 8 < 9 || 13 > 9);
        Console.WriteLine(!(8 > 9 && 8 < 9 && 13 > 9));

    }
}