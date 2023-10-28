using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_int_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name, SurName, Section;
            int Average, Divide,S1,S2,S3;
            Name = "Mehmet";
            SurName = "Ciftci";
            Section = "Computer Programming";


            S1 = 50;
            S2 = 90;
            S3 = 70;
            Divide = 3;
            Average = (S1 + S2+ S3) / Divide;
            Console.WriteLine();
            Console.WriteLine("Section"); 
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Surname: "+SurName);
            Console.WriteLine("Section: "+Section);

            Console.WriteLine();
            Console.WriteLine("Exam Grade ");        
            Console.WriteLine("Exam1: "+ S1);
            Console.WriteLine("Exam2: "+ S2);
            Console.WriteLine("Exam3: " + S3);
            Console.WriteLine("Divide: "+ Divide);
            Console.WriteLine("Avarage: "+Average);
            Console.Read();


        }
    }
}
