# StudentGradeBookSystem
using System;

namespace StudentGradeBookSystem
{
    class Assignment
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO STUDENT GRADE BOOK SYSTEM! ");


            string StudentNumber = "2020-00412-BN-0"; //declare + assignment
            string StudentName = "LLANO, JOHN DEAN P.";
            string StudentAdress = "OLIVAREZ HOMES SOUTH Biñan City, Laguna";
            int age = 19;
            string password = "John Dean";
            string course = "DICT";
            string yearlevel = "1st";

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter Password:");
                string passwordInput = Console.ReadLine();

                Console.WriteLine();
                if (passwordInput == password)
                {
                    Console.WriteLine("STUDENT'S INFORMATION");
                    Console.WriteLine("Student Number: " + StudentNumber);
                    Console.WriteLine("Student Name: " + StudentName);
                    Console.WriteLine("Student Address: " + StudentAdress);
                    Console.WriteLine("Student: " + age);
                    Console.WriteLine("Student Coure & Year: " + course + " " + yearlevel);
                    break;
                }
                else
                {
                    Console.WriteLine(" Invalid Password. ");
                }
            }


            Console.WriteLine("STUDENT GRADES");

            Console.WriteLine("ENTER YOUR NAME:  ");
            String NameofStudent = Console.ReadLine();

            Console.WriteLine("ENTER COMPUTER PROGRAMMING2 GRADE: ");
            double Comprog2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ENTER DISCRETE STRUCTURES GRADE: ");
            double DiscreteStructures = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ENTER UNDERSTANDING YOUR SELF GRADE: ");
            double UnderstandingTheSelf = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ENTER HARDWARE/SOFTWARE INSTALLATION AND MAINTIENANCE GRADE: ");
            double HardwareSoftwareInstallationAndMainten = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ENTER PHYSICAL FITNESS GRADE:  ");
            double PhysicalFitness = Convert.ToDouble(Console.ReadLine());

            double average = (Comprog2 + DiscreteStructures + UnderstandingTheSelf + HardwareSoftwareInstallationAndMainten + PhysicalFitness) / 5;

            if (average >= 75)
            {
                Console.WriteLine(" YOU ARE PASSED!");
            }
            else
            {
                Console.WriteLine(" YOU ARE FAILED!");
            }

            Console.Write("YOUR GENERAL AVERAGE " + StudentName + " IS " + average);

        }
    }
}
