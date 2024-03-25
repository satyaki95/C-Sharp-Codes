class Program
{
    public static void Main(){

        Console.WriteLine("F to C Conveter");

        int far;
        double cel;

        Console.Write("Enter Your F = ");
        far = Convert.ToInt32(Console.ReadLine());

        cel = (far - 32) / 1.8;

        Console.WriteLine($"C = {cel.ToString("F2")}");
    }
}