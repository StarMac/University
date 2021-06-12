using System;
using System.IO;
using System.Runtime.Remoting;
using struct_lab_student;

namespace Lab5
{
    class Program
    {
        static Student[] ReadData(string fileName)
        {
            // TODO   implement this method.
            // It should read the file whose fileName has been passed and fill 
            //Вивести прізвища, ім'я, по батькові студентів чоловічої статі, що не здали більше двох іспитів.
            //вивести прізвище, ім'я, по батькові, середній бал і стипендію Для студентів, що мають "5" з фізики, .
            string path = "C:\\Users\\StarMac\\Desktop\\";
            string newPath = path.Insert(path.Length, fileName);
            int count = System.IO.File.ReadAllLines(newPath).Length;
            Student[] students = new Student[count];
            var stream = File.Open(newPath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(stream, System.Text.Encoding.Default);
            for (int i = 0; i < count; i++)
            {
                var str = sr.ReadLine();
                Student student = new Student(str);
                students[i] = student;
            }

            return students;

        }
        
        static void runMenu(Student[] studs)
        {
            int count = 0;
            for (int i = 0; i < studs.Length; i++)
            {
                count = 0;
                if (studs[i].physicsMark == '2'|| studs[i].physicsMark == '-')
                {
                    count++;

                }
                if (studs[i].informaticsMark == '2'|| studs[i].informaticsMark == '-')
                {
                    count++;

                }
                if (studs[i].mathematicsMark == '2'|| studs[i].mathematicsMark == '-')
                {
                    count++;
                }

                if (count >= 2 && studs[i].sex == 'M')
                {
                    Console.WriteLine(studs[i].surName + " " + studs[i].firstName + " " + studs[i].patronymic);
                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            Student[] studs = ReadData("input.txt");
            runMenu(studs);
        }

    }
}
