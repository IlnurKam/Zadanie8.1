using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HomeWork8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter f1 = new StreamWriter(@"G:\Автоматизация BIM проектирования\Задание 8.2\f1.txt");
            Random r = new Random();
            for (int i = 0; i < 10; i++) f1.WriteLine(r.Next(0, 100));
            f1.Close();
            StreamReader fr = new StreamReader(@"G:\Автоматизация BIM проектирования\Задание 8.2\f1.txt");
            string s = "";
            int max = Int32.Parse(fr.ReadLine()), num = 0;
            do
            {
                s = fr.ReadLine();
                if (int.TryParse(s, out num)) max = max < num ? num : max;
            } while (s != null);
            fr.Close();
            StreamWriter f2 = new StreamWriter(@"G:\Автоматизация BIM проектирования\Задание 8.2\f2.txt");
            f2.WriteLine(max);
            f2.Close();
            {
                string[] lines = File.ReadAllLines(@"G:\Автоматизация BIM проектирования\Задание 8.2\f2.txt"); 
                foreach (var line in lines)
                    Console.WriteLine(line);
            }
        }
    }
}