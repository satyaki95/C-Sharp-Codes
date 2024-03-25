class Program
{
    public static void Main(){
        double radious,area;
        
        
        Console.Write("Enter Circle Radious = ");
        radious = Convert.ToDouble(Console.ReadLine());

        area = Math.PI * radious * radious;

        Console.WriteLine($"Circle Area = {area.ToString("F2")}");

    }
}