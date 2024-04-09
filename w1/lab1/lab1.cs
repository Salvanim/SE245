using System;

namespace Lab1 {
    class Program{
        static void Main(string[] args){
            string studentName, anotherStudent, endingHeader, studentString;
            int gradeAmount;
            double average, totalAverage;
            bool isINT;
            List<string> students = new List<string>();
            List<int[]> studentsGrades = new List<int[]>();
            int[] grades;
            double[] averages;

            Console.Write("\nPlease enter the amount of grades you wish to calculate: ");
            
            isINT = int.TryParse(Console.ReadLine(), out gradeAmount);
            while(!isINT){
                Console.Write("\nNot a Number! Please enter the amount of grades you wish to calculate: ");
                isINT = int.TryParse(Console.ReadLine(), out gradeAmount);
            }

            grades = new int[gradeAmount];

            anotherStudent = "Y";
            while(anotherStudent == "Y"){
                Console.Write("\nPlease enter the students name: ");
                studentName = Console.ReadLine();
                students.Add(studentName);

                for(int gc = 0; gc < gradeAmount; gc++){
                    Console.Write("\nPlease enter a grade of the student (as %): ");
                    int grade;
                    isINT = int.TryParse(Console.ReadLine(), out grade);
                    
                    while(!isINT){
                        Console.Write("\nNot a Number! Please enter a grade of the student (as %): ");
                        isINT = int.TryParse(Console.ReadLine(), out grade);
                    }
                    grades[gc] = grade;
                }
                studentsGrades.Add((int[])grades.Clone());

                Console.Write("\nDo you want to add another student? (Y/N): ");
                anotherStudent = Console.ReadLine().ToUpper();
            }

            averages = new double[studentsGrades.Count()];
            
            for(int i = 0; i < averages.Length; i++){
                average = 0;
                foreach(int g in studentsGrades[i]){
                    average += g;
                }
                average /= studentsGrades[i].Length;
                averages[i] = average;
            }

            endingHeader = "";
            for(int h = 1; h <= gradeAmount; h++){
                endingHeader += $"\tGrade #{h} ";
            }

            Console.WriteLine($"\nName \t{endingHeader} \tAverage");
            for(int s = 0; s < studentsGrades.Count(); s++){
                studentString = students[s];
                foreach(int g in studentsGrades[s]){
                    studentString += $"\t\t{g} ";
                }
                string stringAverage = String.Format("{0:0.00}",averages[s]);
                studentString += $"\t\t{stringAverage}";
                Console.WriteLine(studentString);
            }
            
            totalAverage = 0;
            foreach(int ave in averages){
                totalAverage += ave;
            }
            totalAverage /= averages.Length;

            Console.WriteLine($"\nThe Average Grade for All Students is: {totalAverage}");
        }
    }
}
