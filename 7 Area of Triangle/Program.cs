class Program
{
    public static void Main(){
        double baseLength,height,area;

        Console.Write("Enter Base Of Triangle = ");
        baseLength = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Height Of Triangle = ");
        height = Convert.ToDouble(Console.ReadLine());

        area = 0.5 * baseLength * height;

        Console.WriteLine($"AREA = {area.ToString("F2")}");
        
    }
}