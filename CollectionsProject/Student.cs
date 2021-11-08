using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    public class Student:IComparable<Student>
    {
        
        
            public int Sid { get; set; }
            public String Name { get; set; }
            public int Class { get; set; }
            public float Marks { get; set; }

        public int CompareTo(Student other)
        {
            if (this.Sid > other.Sid)
                return 1;
            else if (this.Sid < other.Sid)
                return -1;
            else
                return 0;

        }
    }
    class CompareStudents : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.Marks > y.Marks)
                return 1;
            else if (x.Marks < y.Marks)
                return -1;
            else
                return 0;

            
        }
    }
    class TestStudent
    {
        //public static int CompareNames(Student S1,Student S2)
        //{
        //    return S1.Name.CompareTo(S2.Name);

        //}

    
        static void Main()
        {
            Student s1 = new Student { Sid = 103, Name = "Ajay", Class = 10, Marks = 545.00f };
            Student s2 = new Student { Sid = 106, Name = "vijay", Class = 10, Marks = 345.00f };
            Student s3 = new Student { Sid = 104, Name = "Sunil", Class = 10, Marks = 445.00f };
            Student s4 = new Student { Sid = 105, Name = "Amit", Class = 10, Marks = 645.00f };
            Student s5 = new Student { Sid = 101, Name = "Hari", Class = 10, Marks = 845.00f };
            Student s6 = new Student { Sid = 102, Name = "chotu", Class = 10, Marks = 945.00f };

            List<Student> Students = new List<Student>() { s1, s2, s3, s4, s5, s6 };
            //CompareStudents obj = new CompareStudents();
            //Students.Sort(obj);
            //Students.Reverse();
            //Students.Sort(1, 5, obj);
            // Students.Sort(obj);
            //Comparison<Student> obj = new Comparison<Student>(CompareNames);

            //Students.Sort(CompareNames);

            //Students.Sort(delegate (Student S1, Student S2)
            //{
            //    return S1.Name.CompareTo(S2.Name);
            //});

            Students.Sort((S1, S2) => S1.Name.CompareTo(S2.Name));
            foreach (Student S in Students)
            {
                Console.WriteLine(S.Sid + " " + S.Name + " " + S.Class + " " + S.Marks);
            }
            Console.ReadLine();
        }
    }
}
