using System;

namespace SampleSurveyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please fill the survey. Thanks!!\n");

            Console.WriteLine("What is the passcode you were given?");
            var pass = Console.ReadLine();
            if(pass == "secret")
            {
                Console.WriteLine("Access Granted\n");
                Console.WriteLine("What is your name?");
                var name = Console.ReadLine();
                Console.WriteLine("How old are you?");
                var age = Console.ReadLine();
                Console.WriteLine("What month were you born in?");
                var month = Console.ReadLine();

                Console.WriteLine("You are " + name + " and your age is " + age + " years old. Also you were born in " + month + ".");
            }
            else
            {
                Console.WriteLine("Access Denied");
                
            }
            
        }
    }
}
