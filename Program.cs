// Written By Shashank
// 1/15/2025

namespace ProjectSpring2025B
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> aListofStudents = new List<Student>();
            Student aStudent1 = new Student();
            Student aStudent2 = new Student();
            Student aStudent3 = new Student();
            Student aStudent4 = new Student(4, "Gail", "Smith", "Elizabeth", "Nursing");
            Student aStudent5 = new Student(5, "Rogers", "Evans", "George", "Dental Hygiene");


            aStudent1.StudentId = 1;
            aStudent1.FirstName = "Anna";
            aStudent1.LastName = "Romanov";
            aStudent1.MiddleName = "Marie";
            aStudent1.Major = "Biology";

            aStudent2.StudentId = 2;
            aStudent2.FirstName = "Robert";
            aStudent2.LastName = "Junior";
            aStudent2.MiddleName = "Downey";
            aStudent2.Major = "Nursing";

            aStudent3.StudentId = 3;
            aStudent3.FirstName = "Aditya";
            aStudent3.LastName = "Maharjan";
            aStudent3.MiddleName = "Dev";
            aStudent3.Major = "Physical Education";

            aListofStudents.Add(aStudent1);
            aListofStudents.Add(aStudent2);
            aListofStudents.Add(aStudent3);
            aListofStudents.Add(aStudent4);
            aListofStudents.Add(aStudent5);

            /*
            Console.WriteLine(aStudent1.ToString());
            Console.WriteLine(aStudent2.ToString());
            Console.WriteLine(aStudent3.ToString());
            Console.WriteLine(aStudent4.ToString());
            Console.WriteLine(aStudent5.ToString());
            .....
            */

            //This is noe the preferred code
            foreach(Student aStudent in aListofStudents)
            {
                Console.WriteLine(aStudent.ToString());
            }

            //This is the old format that you may see online
            foreach (var s in aListofStudents)
            {
                Console.WriteLine(s.ToString());
            }

        }
    }
}