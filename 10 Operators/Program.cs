class Program
{
    public static void Main(string[] args){

        int number1,number2,number3,result;

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

        // Birwise Operator

        result = number1 & number2;
        Console.WriteLine($"bit-and --> {number1} & {number2} = {result}");

        result = number1 | number2;
        Console.WriteLine($"bit-or --> {number1} | {number2} = {result}");

        result = number1 ^ number2;
        Console.WriteLine($"bit-xor --> {number1} ^ {number2} = {result}");

        result = number1 >> 2;
        Console.WriteLine($"bit-right shift --> {number1} >> {2} = {result}");

        result = number1 << 2;
        Console.WriteLine($"bit-left shift --> {number1} << {2} = {result}");

        // Unary Operator

        Console.WriteLine(number1++);
        Console.WriteLine(number1);
        Console.WriteLine(++number1);
        Console.WriteLine(number1--);
        Console.WriteLine(--number1);

        // Ternary Operators

        string check = number1>number2 ? "Number1":"number2";
        Console.WriteLine($"Check = {check}");
    }
}