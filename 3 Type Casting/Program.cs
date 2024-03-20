class Test{
    public static void Main(string[] args){
        double salary = 2700.56;
        Console.WriteLine(salary);

        int salary2 = (int)salary;
        Console.WriteLine(salary2);

        // Implicit / Automatic Conversion
// char -> int -> long -> float -> double ->
            int number = 2700.56;
            double number2 = number;
            Console.WriteLine(number2);

        // Explicit / Manual Conversion
// double -> float -> long -> int -> char

            int chracter = 2700;
            
            Console.WriteLine(Convert.ToString(chracter));
            Console.WriteLine(Convert.ToDouble(chracter));
            Console.WriteLine(Convert.ToChar(chracter));
    }
}
