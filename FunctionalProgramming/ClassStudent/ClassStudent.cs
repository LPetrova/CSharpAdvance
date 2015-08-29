using System.IO;
using System.Linq;

namespace ClassStudent
{
   public class ClassStudent
    {
       public static void Main()
       {
           StudentsDirectory database = new StudentsDirectory();

           // printing
           database.Students.PrintStudentsInfo();
       }
    }
}
