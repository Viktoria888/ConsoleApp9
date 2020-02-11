using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Student
    {
        public string full_name;
        public int num;
        

        public Student()
        {

        }
        public Student(string full_name)
        {
            this.full_name = full_name;
        }
        public Student(int num)
        {
            this.num = num;
        }
       
        public void Mas()
        {
            
            int n = 5;
            int[] Mass = new int[n];
            int sum = 0;
            
            Random R = new Random();
            for (int i = 0; i < n; i++)
            {
                Mass[i] = R.Next(2, 6);
                sum = sum += Mass[i];
            }
            Console.WriteLine("Успеваемость: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Mass[i]+" ");
            }
            Console.WriteLine("\nСреднее арифметическое: ");
            Console.Write(sum / n);
        }

        public void MyInfo()
        {
            Console.WriteLine($"ФИО: {full_name}");
            Console.WriteLine($"Номер группы: {num}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student first = new Student();
            first.full_name = "Johnson G.B.";
            first.num = 5;
            first.MyInfo();
            first.Mas();


            Console.ReadKey();
        }
    }
}

