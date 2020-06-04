using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Javidan", "Mediyev");
            Student s2 = new Student("Seynur", "Memmedov");
            Student s3 = new Student("Osman", "Ismayilov");
            Student s4 = new Student("Zahid", "Qasimli");
            Student s5 = new Student("Kamil", "Memmedov");

            Group p314 = new Group("P314",2);
            p314.AddStudent(s1);
            //p314.AddStudent(s1);
            p314.AddStudent(s3);
            Group p116 = new Group("P116", 18);
            p116.AddStudent(s2);
            p116.AddStudent(s4);
            p116.AddStudent(s5);

            p314.IsExist("Javidan", "Mediyev");
            //p314.ShowStudentList();
            //p116.ShowStudentList();
        }
    }
}
