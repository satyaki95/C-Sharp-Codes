class Program
{
    public static void Main(string[] args)
    {
        int number1,number2,number3;
        double sum;

        Console.Write("Enter 1st No = ");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 2nd No = ");
        number2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter 3rd No = ");
        number3 = Convert.ToInt32(Console.ReadLine());

        sum = (number1+number2+number3)/3.0;
        Console.WriteLine($"avg = {sum1.ToString("F2")}");
    }
}