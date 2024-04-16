using System;

class Program
{
    public static void Main(string[] args){
        char letter;

        Console.Write("Enter Any Letter = ");
        letter = Convert.ToChar(Console.ReadLine());

        if(letter >= 'A' && letter <= 'Z'){
            if (letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
            {
               Console.WriteLine($"{letter} is Capital Letter And Vowel"); 
            }
            
        }else
        {
             if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
               Console.WriteLine($"{letter} is Small Letter And Vowel"); 
            }else
            {
                Console.WriteLine($"{letter} is Small Letter And Consonant");
            }
             
        }
    }
}