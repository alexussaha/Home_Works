using System;
using System.Collections.Generic;
using System.IO;

namespace Task_3
{
    delegate bool Is(Student s);
    class Program
    {
        static int AgeCompare(Student st1, Student st2)
        {
            return String.Compare(st1.age.ToString(), st2.age.ToString());
        }

        static int CourceAndAgeCompare(Student st1, Student st2)
        {
            if (st1.course > st2.course)
                return 1;
            if (st1.course < st2.course)
                return -1;
            if (st1.age > st2.age)
                return 1;
            if (st1.age < st2.age)
                return -1;
            return 0;
        }

        static int MyMethod(Student st1, Student st2)//Создаем метод для сравнения для экземпляров
        {
            //Сравниваем две строки
            // return String.Compare(st1.firstName, st2.firstName);
            if (st1.course > st2.course) return 1;
            if (st1.course < st2.course) return -1;
            return 0;
        }

        static bool IsAgeBigger18(Student student)
        {
            return student.age > 18;
        }
        static bool IsAgeBigger18AndLower20(Student student)
        {
            return student.age >= 18 && student.age <= 20;
        }
        static int[] CourseStatistics(List<Student> students, Is IS)
        {
            int[] courses = new int[6];
            foreach(Student student in students)
            {
                if (IsAgeBigger18AndLower20(student)) courses[student.course - 1]++;
            }
            return courses;
        }
        static void PrintList(int[] list)
        {
            int k = 0;
            foreach (int el in list)
            {
                Console.WriteLine($"{k+1} курс - {el} студентов");
                k++;
            }
        }
        static int CountStudents(List<Student> students, Is IS)
        {
            int count = 0;
            foreach (Student student in students)
            {
                if (IS(student)) count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            int fiveCourceStudent = 0;
            int sixCourceStudent = 0;
            //Создаем список студентов
            List<Student> list = new List<Student>();
            DateTime dt = DateTime.Now;
            StreamReader sr = new StreamReader("students_4.csv");
            //File.ReadAllLines("students_4.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    //Добавляем в список новый экземляр класса Student
                    Student t;
                    t = new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), Convert.ToInt32(s[6]), int.Parse(s[7]), s[8]);
                    list.Add(t);
                    //Одновременно подсчитываем кол-во бакалавров и магистров
                    if (t.course == 5) fiveCourceStudent++;
                    if (t.course == 6) sixCourceStudent++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            sr.Close();
            Console.WindowWidth = 160;
            Console.BufferWidth = 160;
            //Можно оставить просто MyMethod, но помнить, что мы создаем объект-делегат, который передается в метод Sort
            list.Sort(MyMethod);
            //foreach (var v in list) Console.WriteLine(v.ToString());
            Console.WriteLine("Всего студентов:" + list.Count);
            Console.WriteLine("Студентов 6 курса:{0}", sixCourceStudent);
            Console.WriteLine("Студентов 5 курса:{0}", fiveCourceStudent);
            Console.WriteLine("Кол-во студентов старше 18", CountStudents(list, delegate (Student s)
            {
                return s.age > 18;
            }));
            Is Age = new Is(IsAgeBigger18AndLower20);

            Console.WriteLine("Кол-во студентов старше 18", CountStudents(list, IsAgeBigger18));
            PrintList(CourseStatistics(list, Age));
            list.Sort(AgeCompare);
            list.Sort(CourceAndAgeCompare);
            Console.WriteLine(DateTime.Now - dt);
            Console.ReadKey();
        }
    }
}
