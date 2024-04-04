using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Sample1 {
    class Program {
        static void Main (string[] args) {
            string enterStudent = "";
            string enterGrade = "";
            string studentName = "";
            string strNum = "";
            List<string> students = new List<string>();
            List<List<double>> allStudentGrades = new List<List<double>>();
            List<double> studentGrades = new List<double>();
            List<double> averages = new List<double>();
            List<string> gradeLetters = new List<double>();
            double grade = 0.0;
            double average = 0;
            bool blnResult = false;
            
            while(enterStudent == "" || enterStudent == "Y"){
                enterGrade = "";
                studentName = "";
                strNum = "";
                grade = 0.0;
                average = 0.0;

                while(enterStudent != "Y" && enterStudent != "N"){
                    Console.Write ("\nDo you want to enter a student (Y/N): ");
                    enterStudent = Console.ReadLine().ToUpper();
                    if(enterStudent != "Y" && enterStudent != "N"){
                        Console.WriteLine ("\nSorry, but you did not enter a valid response: Ex Y");
                    }
                }
            
                Console.Write ("\nWhat is the name of the student?: ");
                studentName = Console.ReadLine();
                students.Add(studentName);

                while(enterGrade == "" || enterGrade == "Y"){
                    do {
                        Console.Write ($"\nWhat is grade of {studentName}?: ");
                        strNum = Console.ReadLine ();

                        blnResult = Double.TryParse (strNum, out grade);

                        if (blnResult == false) {
                            Console.WriteLine ("\nSorry, but you did not enter a valid real number in digits: Ex 1051.00."); //checks if user input is a real number
                        }
                    } while (blnResult == false);

                    studentGrades.Add(grade);
                    enterGrade = "";

                    while(enterGrade != "Y" && enterGrade != "N"){
                        Console.Write ("\nDo you want to enter another grade (Y/N)?: ");
                        enterGrade = Console.ReadLine().ToUpper();
                        if(enterGrade != "Y" && enterGrade != "N"){
                            Console.WriteLine ("\nSorry, but you did not enter a valid response: Ex 'Y'");
                        }
                    }
                }

                allStudentGrades.Add(studentGrades);

                foreach(double gra in studentGrades){
                    average += gra;
                }

                average /= studentGrades.Count;
                averages.Add(average);

                studentGrades = new List<double>();
                enterStudent = "";

                while(enterStudent != "Y" && enterStudent != "N"){
                    Console.Write ("\nDo you want to enter another student (Y/N): ");
                    enterStudent = Console.ReadLine().ToUpper();
                    if(enterStudent != "Y" && enterStudent != "N"){
                        Console.WriteLine ("\nSorry, but you did not enter a valid response: Ex Y");
                    }
                }
            }
        }
    }
}