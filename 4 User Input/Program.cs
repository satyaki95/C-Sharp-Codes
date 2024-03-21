// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args){

        string? studentName;
        int studentAge;
        double gpa;
        bool isRegister;

        Console.Write("Enter Your Name : ");
        studentName =  Console.ReadLine();

        Console.Write("Enter Your Age : ");
        studentAge =  Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Your GPA : ");
        gpa =  Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Your Registation : ");
        isRegister =  Convert.ToBoolean(Console.ReadLine());

       Console.WriteLine("Name : " + studentName);
       Console.WriteLine("Age : " + studentAge);
       Console.WriteLine("GPA : " + gpa);
       Console.WriteLine("Registation : " + isRegister);

    }
}
