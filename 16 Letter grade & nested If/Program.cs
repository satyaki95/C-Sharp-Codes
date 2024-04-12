using System;

class Program
{
    public static void Main(string[] args){
        int number;
        string grade = "Wrong Input";
        Console.Write("Enter Your Marks = ");
        number = Convert.ToInt32(Console.ReadLine());

        if(number > 0 && number <= 100){
            if(number >= 90 && number <= 100){
                 grade = "A";
            }
            else if(number >= 80 && number < 90){
                 grade = "B";
            }
            else if(number >= 70 && number < 80){
                 grade = "C";
            }
            else if(number >= 60 && number < 70){
                 grade = "D";
            }else{
               grade = "F";
            }
            
        }
            Console.WriteLine(grade);
        
    }
}