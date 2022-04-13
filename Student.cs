using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    class Student
    {
        public string FullName { get; set; }
        public string GroupNo { get; set; }
        public bool Type { get; set; }
        private Student[] students = new Student[0];
        public Student(string fullname, string groupno, bool type)
        {
            FullName = fullname;
            GroupNo = groupno;
            Type = type;
        }
        public void Add(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }



    }
}
