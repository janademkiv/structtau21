using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {

        struct Abiturient
        {
            //фио и предмет
            
            public string sname;
            public string fname;
            public string name;

            public Abiturient(string a, string b, string c)
            {

                sname = a;
                fname = b;
                name = c;
            }

            public void DisplayInfo()
            {

                Console.WriteLine("Имя " + sname);
                Console.WriteLine("Имя " + fname);
                Console.WriteLine("Имя " + name);
            }
        }

        //оценка
        public struct Lesson {

            public int assessment;

        
        }

        struct Assessment {

            public Lesson[] mass;

        }

        static void Main(string[] args) {

            // ввод фио 
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();

            Console.WriteLine("Введите Отчество");
            string sname = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            string fname = Console.ReadLine();
            Abiturient user = new Abiturient(name, sname, fname);

            Console.WriteLine("Ваше ФИО");
            
            user.DisplayInfo();


            //вводи и расчет оценки
            Assessment student = new Assessment();
            student.mass = new Lesson[5];
            Console.WriteLine();
            Console.WriteLine("Введите 5 оценок по 5-ти бальной шкале");

           
            for (int i = 0; i < 5; i++)
            {
               


                Console.WriteLine("Введите отметку");
            
                student.mass[i].assessment = byte.Parse(Console.ReadLine());

            }
            
            double sredn = znach(student);
            Console.WriteLine(sredn);
            Console.ReadKey();
        }

        static double znach(Assessment assessment)
        {
            double sr = 0, sred = 0;
            for (int i = 0; i < 5; i++)
            {
                sr += assessment.mass[i].assessment;
            }
            sred = sr / 5;
            Console.WriteLine("Cредний балл " + sred);
            return sred;

        }
    }
}
