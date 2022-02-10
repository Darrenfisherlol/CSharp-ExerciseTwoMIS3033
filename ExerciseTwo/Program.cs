﻿/*
 *Darren Fisher 
 * MIS 3033
 * Excersie 2
 */

/*
 Create a C# Console Application, name it StudentRecordApp, that will prompt the user if the 
user needs to enter a new record of a student.
If “yes”, then prompt the user to enter the names of the students, the student id’s, and the grades 
of three exams.
If the user enters “no”, then print out all the students’ information, including the names, the 
student id’s, the grades of three exams, and the average grade of three exams.
 */

using System;
using System.Collections.Generic;


namespace exTwoMac
{

    class Student
    {



        string FirstName;
        string LastName;
        string SID;

        double Exam1Grade;
        double Exam2Grade;
        double Exam3Grade;

        double AvgGrade;
        char LetterGrade;


        public Student()
        {
        }

        public Student(string fn, string ln, string id, double exam1, double exam2, double exam3)
        {
            FirstName = fn;
            LastName = ln;
            SID = id;
            Exam1Grade = exam1;
            Exam2Grade = exam2;
            Exam3Grade = exam3;

        }

        public double CalculateAverage()
        {
            double AvgGrade = (Exam1Grade + Exam2Grade + Exam3Grade) / 3;
            this.AvgGrade = AvgGrade;
            return AvgGrade;

        }

        public char CalculateLetterGrade()
        {
            if (AvgGrade > 90)
            {

                LetterGrade = 'A';
            }
            else if (AvgGrade > 80)
            {
                LetterGrade = 'B';
            }
            else if (AvgGrade > 70)
            {
                LetterGrade = 'C';
            }
            else if (AvgGrade > 60)
            {
                LetterGrade = 'D';
            }
            else
            {
                LetterGrade = 'F';
            }
            return LetterGrade;

        }

        public override string ToString()
        {
            string overrideString = "";

            return overrideString;
            //return base.ToString();
        }



    }



    class Program
    {
        static void Main(string[] args)
        {


            // collections of students ~ list because we dont have a defined amount of students
            List<Student> listOfStudents = new List<Student>();


            Console.WriteLine("Do you want to enter a student? Yes or No");

            string userResponce = Console.ReadLine().Trim().ToLower();

            // ask user for student data
            //names of the students, the student id’s, and the grades of three exams.
            while (userResponce == "yes")
            {
                Console.WriteLine("What is your first name");

                string firstName = Console.ReadLine().Trim().ToLower();

                Console.WriteLine("What is your last name");
                string lastName = Console.ReadLine().Trim().ToLower();

                Console.WriteLine("What is your student id");
                string studentID = Console.ReadLine().Trim().ToLower();

                Console.WriteLine("What is your first grade");
                double gradeOne = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What is your second grade");
                double gradeTwo = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What is your third grade");
                double gradeThree = Convert.ToDouble(Console.ReadLine());

                Student newStudent = new Student(firstName, lastName, studentID, gradeOne, gradeTwo, gradeThree);

            }

            // Print out all the students’ information, including the names, the student id’s, the grades of three exams, and the average grade of three exams.





            Console.ReadKey();
        }
    }
}