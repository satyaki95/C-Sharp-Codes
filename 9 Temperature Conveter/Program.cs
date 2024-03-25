class Program
{
    public static void Main(){

        Console.WriteLine("F to C Conveter");

        double farI,celI,far,cel;

        Console.Write("Enter Your F = ");
        farI = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Your C = ");
        celI = Convert.ToDouble(Console.ReadLine());
        // Celsius To Fahrenheit
        cel = (farI - 32) / 1.8;
        // Fahrenheit To Celsius
        far = (celI * 1.8) + 32;

        Console.WriteLine($"C = {cel.ToString("F2")}");
        Console.WriteLine($"F = {far.ToString("F2")}");
    }
}