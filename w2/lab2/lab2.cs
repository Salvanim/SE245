using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Sample1 {
    class Program {

        static void forceAnwser(string question, string anwser){
            while(anwser != "Y" && anwser != "N"){
                Console.Write ($"\n{question} ");
                anwser = Console.ReadLine().ToUpper();
                if(anwser != "Y" && anwser != "N"){
                    Console.WriteLine ("\nSorry, but you did not enter a valid response: ");
                }
            }
        }

        static double getAverage(List<double> numbers){
            double average = 0.0;
            foreach(double num in numbers){
                average += numbers;
            }
            average /= numbers.Count;
            return average;
        }

        static void Main (string[] args) {
            string enterStudent = "";
            string enterGrade = "";
            string studentName = "";
            string strNum = "";
            List<string> students = new List<string>();
            List<List<double>> allStudentGrades = new List<List<double>>();
            List<double> studentGrades = new List<double>();
            List<double> averages = new List<double>();
            double grade = 0.0;
            double average = 0.0;
            double averagesAverage = 0.0;
            bool blnResult = false;

            while(enterStudent == "" || enterStudent == "Y"){
                enterGrade = "";
                studentName = "";
                strNum = "";
                grade = 0.0;
                average = 0.0;

                forceAnwser("Do you want to enter a student (Y/N): ", ref enterStudent);

                if(enterStudent == "Y"){
                    Console.Write ("\nWhat is the name of the student?: ");
                    studentName = Console.ReadLine();
                    students.Add(studentName);

                    while(enterGrade == "" || enterGrade == "Y"){
                        do {
                            Console.Write ($"\nWhat is a grade of {studentName}? (%): ");
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

                    forceAnwser("Do you want to enter another student (Y/N): ", ref enterStudent);
                }
            }

            if(allStudentGrades.Count() > 0){
                foreach(int a in averages){
                    averagesAverage += a;
                }
                averagesAverage /= averages.Count;
                
                int maxLength = 0;
                foreach(List<double> studentGradeList in allStudentGrades){
                    if(studentGradeList.Count > maxLength){
                        maxLength = studentGradeList.Count;
                    }
                }
                
                string gradeIndexStrings = "";
                for(int gradeIndex = 0; gradeIndex < maxLength; gradeIndex++){
                    gradeIndexStrings += $"\t Grade {gradeIndex} ";
                }

                Console.WriteLine($"\nName {gradeIndexStrings} \t Average");
                for(int i = 0; i < allStudentGrades.Count; i++){
                    string currentStudentGrade = students[i] + " \t ";
                    for(int g = 0; g < maxLength; g++){
                        if(g >= allStudentGrades[i].Count){
                            currentStudentGrade += "  \t\t ";
                        } else {
                            if(allStudentGrades[i][g] < 60){
                                currentStudentGrade += " F \t\t ";
                            }else if(allStudentGrades[i][g] < 70){
                                currentStudentGrade += " D \t\t ";
                            }else if(allStudentGrades[i][g] < 80){
                                currentStudentGrade += " C \t\t ";
                            }else if(allStudentGrades[i][g] < 90){
                                currentStudentGrade += " B \t\t ";
                            } else {
                                currentStudentGrade += " A \t\t ";
                            }
                        }
                    }
                    Console.WriteLine(currentStudentGrade + averages[i].ToString());
                }
                Console.WriteLine($"Average Grade across all students: {averagesAverage}");
            }
        }
    }
}