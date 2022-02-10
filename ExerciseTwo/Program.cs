/*
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
        // public student attributes
        public string FirstName;
        public string LastName;
        public string SID;

        public double Exam1Grade;
        public double Exam2Grade;
        public double Exam3Grade;

        public double AvgGrade;
        public char LetterGrade;


        public Student()
        {
        }

        // create a student object
        public Student(string fn, string ln, string id, double exam1, double exam2, double exam3)
        {
            FirstName = fn;
            LastName = ln;
            SID = id;
            Exam1Grade = exam1;
            Exam2Grade = exam2;
            Exam3Grade = exam3;

        }

        // calculate the avg grades with the given exam 1 - exam 3 grades and return avg number
        public double CalculateAverage()
        {
            double AvgGrade = (Exam1Grade + Exam2Grade + Exam3Grade) / 3;
            this.AvgGrade = AvgGrade;
            return AvgGrade;

        }

        // calculate the letter grade given the average grade
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
            string overrideString = string.Format("{0} {1} ({2}), Exam 1: {3:F2}, Exam 2: {4:F2}, Exam 3: {5:F2}, Average Grade: {6:F2}, LetterGrade: {7}", FirstName,LastName,SID,Exam1Grade,Exam2Grade,Exam3Grade, CalculateAverage(), CalculateLetterGrade());

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

            // ask user for an input to begin program or not
            Console.WriteLine("Do you want to enter a student? Yes or No");
            string userResponce = Console.ReadLine().Trim().ToLower();
            ;

            // ask user for student data:
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

                // create student object
                Student newStudent = new Student(firstName, lastName, studentID, gradeOne, gradeTwo, gradeThree);

                // add the new student to a collection
                listOfStudents.Add(newStudent);

                // ask user for an input to begin program or not
                Console.WriteLine("Do you want to enter a student? Yes or No");
                userResponce = Console.ReadLine().Trim().ToLower();
            }

            // Print out all the students’ information, including the names, the student id’s, the grades of three exams, and the average grade of three exams.
            foreach (Student x in listOfStudents)
            {
                // calls ToString(); Override method
                Console.WriteLine(x.ToString());
            }
            
            // keep console open
            Console.ReadKey();
        }
    }
}