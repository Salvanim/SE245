using System

namespace Lab1 {
    class Program{
        static void Main(string[] args){
            string studentName, anotherGrade;
            List<int> grades = new List<int>(){};
            
            Console.Write("Please enter the students name: ");
            studentName = Console.ReadLine();

            anotherGrade = "Y"
            while(anotherGrade == "Y"){
               Console.Write("Please enter a grade of the student (as %): ");
               int grade;
               bool isINT = int.TryParse(Console.ReadLine(), out grade);
               if(!isInt){
                Console.Write("Not a Number! Please enter a grade of the student (as %): ");
                bool isINT = int.TryParse(Console.ReadLine(), out grade);
               }
               List.add(grade);
               Console.Write("Do you want to add another grade (Y/N): ");
               anotherGrade = Console.ReadLine().ToUpper();
            }

            for(int i; i < grades.Count(); i++){
                Console.WriteLine(grades[i]);
            }

        }
    }
}
