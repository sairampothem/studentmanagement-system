using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    class Studentmngmt
    {
        string dob, stuname, fathername, deptname, address;
        double mobilenum;
        int deptid, fee, rollnum;
        int marks = 1000;
        public void newstudentdetails()
        {
            Console.WriteLine("Enter student name:");
            stuname = Console.ReadLine();
            Console.WriteLine("Enter father name:");
            fathername = Console.ReadLine();
            Console.WriteLine("Enter Address:");
            address = Console.ReadLine();
            Console.WriteLine("Enter Mobile number:");
            mobilenum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Date of Birth:");
            dob = Console.ReadLine();
        }
        public void deptdetails()
        {
            Console.WriteLine("Enter Department ID:");
            deptid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Department name:");
            deptname = Console.ReadLine();
            Console.WriteLine("New Student in {0} Department", deptname);
        }
        public void fees()
        {
            Console.WriteLine("Enter fees:");
            fee = int.Parse(Console.ReadLine());
            Console.WriteLine("New Student record created");
        }
        public void newdisplay()
        {
            Console.WriteLine("NEW STUDENT NAME:" + stuname);
            Console.WriteLine("FATHER NAME:" + fathername);
            Console.WriteLine("ADDRESS:" + address);
            Console.WriteLine("MOBILE NUMBER:" + mobilenum);
            Console.WriteLine("DATE OF BIRTH:" + dob);
            Console.WriteLine("DEPARTMENT ID:" + deptid);
            Console.WriteLine("DEPARTMENT NAME:" + deptname);
            Console.WriteLine("FEES TO BE PAID:" + fee);
        }
        public void oldstudent()
        {
            Console.WriteLine("Enter Roll number:");
            rollnum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student name:");
            stuname = Console.ReadLine();
            Console.WriteLine("old student record found");
        }
        public void getdeptdetails()
        {
            Console.WriteLine("Enter Department ID:");
            deptid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Department name:");
            deptname = Console.ReadLine();
        }
        public void updatefees()
        {
            Console.WriteLine("Enter fees:");
            fee = int.Parse(Console.ReadLine());
            if (fee <= 100000)
            {
                Console.WriteLine("Fees pending!!!");
            }
            else
            {
                Console.WriteLine("Fees paid");
            }
        }
        public void results()
        {
            Console.WriteLine("Enter Marks:");
            marks = int.Parse(Console.ReadLine());
            if (marks < 1000 || marks == 1000)
            {
                Console.WriteLine("Exams passed");
            }
            else if (marks <= 500)
            {
                Console.WriteLine("Exams failed");
            }
            else
            {
                Console.WriteLine("Invalid marks");
            }
        }
        public void olddisplay()
        {
            Console.WriteLine("STUDENT NAME:" + stuname);
            Console.WriteLine("ROLL NUMBER:" + rollnum);
            Console.WriteLine("DEPARTMENT ID:" + deptid);
            Console.WriteLine("DEPARTMENT NAME:" + deptname);
            Console.WriteLine("FEES:" + fee);
            Console.WriteLine("MARKS:" + marks);
        }
    }
}