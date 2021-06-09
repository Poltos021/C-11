using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR10
{
    class Student
    {
        public string Full_Name { get; set; }
        public byte Course { get; set; }
        public string Specialization { get; set; }
        public Student(string full, byte course, string specialization)
        {
            Full_Name = full;
            Course = course;
            Specialization = specialization;
        }
        public string Group()
        {
            string specialization = "";

            switch (Specialization)
            {
                case "09.02.03":
                    specialization = "ПКС";
                    break;
                case "09.02.01":
                    specialization = "КСК";
                    break;
            }
            return Course + specialization;
        }
    }
       class Student_2 : Student
       {
        public bool External { get; set; }
        public Student_2(string full_name, byte course ,string specialization, bool external) : base (full_name, course, specialization)
        {
            External = external;
            
        }
        public string Group()
        {
            string ex = (External) ? "О" : "З";
            return ex + base.Group();
        }
       }
        class Program
        { 
         static void Main(string[] args)
         {
            Console.WriteLine("Введите полное имя, курс, спициализацию");
            Student student = new Student(Console.ReadLine(),byte.Parse(Console.ReadLine()),Console.ReadLine());
            Console.WriteLine(student.Group());   

            Console.WriteLine("Введите полное имя, курс, спициализацию, и форму обучения 'true' - очная, 'false' - заочная");
           Student_2 student1 = new Student_2(Console.ReadLine(), byte.Parse(Console.ReadLine()), Console.ReadLine(),bool.Parse(Console.ReadLine()));
            Console.WriteLine(student1.Group());

            Console.ReadKey();
         }
        }
}
