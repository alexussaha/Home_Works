using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Student
    {
       
            public string lastName;
            public string firstName;
            public string univercity;
            public string faculty;
            public int course;
            public string department;
            public int group;
            public string city;
            public int age;

            //Создаем конструктор
            public Student(string firstName, string lastName, string univercity, string faculty, string department, int age, int course, int group, string city)
            {
                this.lastName = lastName;
                this.firstName = firstName;
                this.univercity = univercity;
                this.faculty = faculty;
                this.department = department;
                this.course = course;
                this.age = age;
                this.group = group;
                this.city = city;
            }

            public override string ToString()
            {
                return String.Format("{0,15}{1,15}{2,15}{3,15}{4,15}{5,15}{6,15}{7,5}{8,10}", firstName, lastName, univercity, faculty, department, age, course, group, city);
            }
        
    }
}
