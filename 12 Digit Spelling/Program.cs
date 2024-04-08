using System;

class Program
{
    public static void Main(String[] args){
        Console.Write("Enter Any Digit Between 0 to 9 : ");

        int digit = Convert.ToInt32(Console.ReadLine());
        var check = false;
        string[] words = ["ZERO","ONE","TWO","THREE","FOUR","FIVE","SIX","SEVEN","EIGHT","NINE"];
        for (int i = 0; i < words.Length; i++)
        {
            if(digit == i){
                Console.WriteLine(words[i]);
                check = true;
            }
            
        }
        if (!check)
        {
            Console.WriteLine("Not A Valid Digit");
        }
    }
}