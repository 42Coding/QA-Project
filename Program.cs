using System;
using System.Collections.Generic;

namespace QA_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the hitchhikers guide to the Galaxy Q&A Program :)");
            Memory memory = new Memory();
            String result = String.Empty;
            do
            {
                Console.WriteLine("Do you want to add some Questions & Awnsers? (y/n)");
                result = Console.ReadLine();
                if (result.Equals("y"))
                {
                    memory.Add(result);
                }
                Console.WriteLine("Do you have any questions? (y/n)");
                result = Console.ReadLine();
                if(result.Equals("y"))
                {
                    memory.Search(result);
                }
                Console.WriteLine("Exit Program? (y/n)");
                result = Console.ReadLine();
            }
            while (result.Equals("y"));
        }
        
    }
}
