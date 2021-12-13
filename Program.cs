using System;
using System.Collections.Generic;

namespace QA_Project
{
    class Program
    {
        static Boolean YES(String result)
        {
            return new List<String> { "y", "yes", "j", "ja" }.Contains(result.ToLower());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the hitchhikers guide to the Galaxy Q&A Program :)");
            Memory memory = new Memory();
            do
            {
                Console.WriteLine("Do you want to enter some new Questions & Awnsers? (y/n)");
                if (YES(Console.ReadLine()))
                {
                    Console.WriteLine("Enter your new Questions & Awnsers:");
                    memory.Add(Console.ReadLine());
                }
                Console.WriteLine("Do you have any questions? (y/n)");
                if (YES(Console.ReadLine()))
                {
                    Console.WriteLine("Enter your questions:");
                    memory.Search(Console.ReadLine());
                }
                Console.WriteLine(memory.Count().ToString());
                Console.WriteLine("Exit Program? (y/n)");
            }
            while (!YES(Console.ReadLine()));
            System.Environment.Exit(1);
        }
    }
}
