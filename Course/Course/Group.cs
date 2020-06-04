using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Group
    {
        public string Name { get; set; }
        public int MaxStudentCount { get; set; }

        private Student[] students;

        public readonly int Id;
        private static int count = 0;

        public Group()
        {
            count++;
            Id = count;
            students = new Student[0];
        }

        public Group(string name,int maxStuCount):this()
        {
            Name = name;
            MaxStudentCount = maxStuCount;
        }

        public override string ToString()
        {
            return Name;
        }

        public void AddStudent(Student newStu)
        {
            if (students.Length < MaxStudentCount)
            {
                foreach (Student item in students)
                {
                    if (item.Id == newStu.Id)
                    {
                        Console.WriteLine($"{newStu.Name} adli telebeni artiq elave etmisiniz");
                        return;
                    }
                }
                Array.Resize(ref students,students.Length+1);
                students[students.Length - 1] = newStu;
                //Console.WriteLine("Telebe elave olundu");
            }
            else
            {
                Console.WriteLine($"{Name} grupu doludur.");
            }
        }

        public  void ShowStudentList()
        {
            Console.WriteLine($"{Name} grupunda olan telebelerin siyahisi:");
            foreach (Student item in students)
            {
                Console.WriteLine(item);
            }
        }

        public void IsExist(string name,string surname)
        {
            foreach (Student item in students)
            {
                if(item.Name==name && item.Surname == surname)
                {
                    Console.WriteLine($"{Name} qrupunda {name} {surname} adli telebe var");
                    return;
                }
            }
            Console.WriteLine($"{Name} qrupunda {name} {surname} adli telebe YOXDUR!!!");
        }
    }
}
