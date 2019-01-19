using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0730069_Manvir_Singh
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInformation _Mary = new StudentInformation("Marry", 3.8, 20);
            StudentInformation _John = new StudentInformation("John", 3.8, 20);
            StudentInformation _Mark = new StudentInformation("Mark", 3.8, 20);
            StudentInformation _Steve = new StudentInformation("Steve", 3.8, 20);
            StudentInformation _Cindy = new StudentInformation("Cindy", 3.8, 20);
        }
    }
    class StudentInformation
    {
        string Name;
        string StudentNumber;
        double GPA;
        int Attendance;
        public StudentInformation(string aName, double cGPA, int dAttendance)
        {
            Name = aName;
            StudentNumber = bStudentNumber;
            GPA = cGPA;
            Attendance = dAttendance;
        }
    }
}
