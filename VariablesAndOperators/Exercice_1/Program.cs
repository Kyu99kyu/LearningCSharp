using System;
using System.Collections.Generic;
using System.Text;


namespace Exercice_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] questions = new string[3] { "Plese, enter your name", "Please, enter your ID", "Please, enter the day you born" };
            string[] fields = new string[3] { "Name: ", "ID: ", "Birthday: " };
            List<string> answer = new List<string>();

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                answer.Add(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < fields.Length; i++)
            {
                Console.WriteLine("{0}: {1}\n", fields[i], answer[i]);
            }
        }
    }
}