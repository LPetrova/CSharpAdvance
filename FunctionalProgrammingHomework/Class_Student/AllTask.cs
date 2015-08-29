using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Student
{
    class AllTask
    {
        static void Main(string[] args)
        {
            //Problem 1.	Class Student
            var students = new List<Student>
		{
			new Student("Iliana", "Ivanova",18,1,"021234","",new List<int> {5, 3, 5, 6},1),
			new Student("Penka", "Petrova",18,2,"3592321638","peshev@abv.bg",new List<int> {5, 2, 5, 6},1),
			new Student("Petko", "Petkov",19,3,"07113","petkov@abv.bg",new List<int> {5, 2, 5, 6},2),
			new Student("Goshko", "Goskov",19,4,"083545","goshov@gmail.com",new List<int> {5, 2, 5, 5},2),
			new Student("Mariq", "Tcankova",20,5,"+359 203","niama@ght.gh",new List<int> {6, 2, 6, 4},1),
			new Student("Rositza", "Roseva",21,6,"112345","pakmail@abv.bg",new List<int> {4, 2, 6, 3},2),
			new Student("Ivan", "Petkov",36,7,"524354","zashto@hotmail.com",new List<int> {6, 2, 2, 6},3),
		};

            Console.WriteLine("Problem 2. Students by Group");
            Console.WriteLine();

            var studentsQuery = from student in students
                                where student.GroupNumber == 2
                                orderby student.FirstName
                                select student;

            foreach (var st in studentsQuery)
            {
                Console.WriteLine("{0} {1}: {2}", st.FirstName, st.LastName, st.GroupNumber);
            }
            Console.WriteLine( );
            
            Console.WriteLine("Problem 3. Students by First and Last Name");
            Console.WriteLine( );

            var studentsFirstAndLastName =
               from st in students
               where st.FirstName.CompareTo(st.LastName) < 0
               select st;
            
            foreach (var st in studentsFirstAndLastName)
            {
                Console.WriteLine("First Name = {0}, Last Name = {1}", 
                    st.FirstName, st.LastName );
            }
            Console.WriteLine(  );
          
            Console.WriteLine("Problem 4. Students by Age");
            Console.WriteLine( );

            var studentsByAge =
                from st in students
                where (st.Age >= 18 && st.Age <= 24)
                select new { st.FirstName, st.LastName, st.Age };
            
            foreach (var st in studentsByAge)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName + " " + st.Age);
            }
            Console.WriteLine();

            Console.WriteLine("Problem 5. Sort Students");
            Console.WriteLine("Using Lambda:");
            Console.WriteLine();

            //this is DESCENDING order by and DESCENDING thenby
            var sortStudentsLambda = students.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName).Select(st => (string.Format("{0} {1}", st.FirstName, st.LastName)));
            foreach (var st in sortStudentsLambda)
            {
                Console.WriteLine(st);
            }

            Console.WriteLine();
            Console.WriteLine("LINQ query:");
            Console.WriteLine();

            var sortStudentsLINQ =
                from st in students
                orderby st.FirstName descending, st.LastName descending
                select st;

            foreach (var st in sortStudentsLINQ)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName);
            }         
            Console.WriteLine();

            Console.WriteLine("Problem 6. Filter Students by Email Domain");
            Console.WriteLine( );

            var studentsByEmails =
               from st in students
               where st.Email.Contains("@abv.bg")
               select st;

            foreach (var st in studentsByEmails)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName + "-->" + st.Email);
            }
            Console.WriteLine();

            Console.WriteLine("Problem 7. Filter Students by Phone");
            Console.WriteLine( );

            var studentsPhoneSofia =
                from st in students
                where (st.Phone.StartsWith("02") || st.Phone.StartsWith("+3592") || st.Phone.StartsWith("+359 2"))
                select st;

            foreach (var st in studentsPhoneSofia)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName + " --> " + st.Phone);
            }

            Console.WriteLine();

            Console.WriteLine("Problem 8. Excellent Students");
            Console.WriteLine();
            
            var exellentStudents = from student in students
                                where student.Marks.Contains(6)
                                select new { FullName = student.FirstName + " " + student.LastName, student.Marks };
            foreach (var st in exellentStudents)
            {
                Console.WriteLine(st.FullName+ ": " + string.Join(", ", st.Marks));
            }
            Console.WriteLine();

            Console.WriteLine("Problem 9. Weak Students");
            Console.WriteLine(  );
            var weakStudents =
              from st in students
              where (st.Marks.Min() == 2)
              select new { Fullname = string.Join(" ", st.FirstName, st.LastName), Marks = string.Join(" ", st.Marks) };

            foreach (var st in weakStudents)
            {
                Console.WriteLine(st.Fullname + " " + st.Marks);
            }
            Console.WriteLine(  );

            Console.WriteLine("Problem 10. Students Enrolled in 2014");
            Console.WriteLine();
           
            var studentEnrolled = from student in students
                                where student.FacultyNumber % 100 == 14
                                select student;
            foreach (var st in studentEnrolled)
            {
                Console.WriteLine("{0} {1} FN: {2} Marks: {3}", st.FirstName, st.LastName, st.FacultyNumber, string.Join(", ", st.Marks));
            }
        }
    }
}
