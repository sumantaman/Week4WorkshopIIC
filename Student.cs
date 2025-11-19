using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Week_4
{
    public class Student
    {
        public int studentId;
        public string name;
        public int age;

        public static string collegeName = "Itahari Internation College";

        public Student(int studentId, string name, int age)
        {
            this.studentId = studentId;
            this.name = name;
            this.age = age;
        }
    }
}
