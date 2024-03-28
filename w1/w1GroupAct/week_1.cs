using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w1GroupAct {
    class Program {
        static void Main (string[] args) {
            //Initialzes Varriables
            String strFirst, strOperand, strNum2, strNum1;
            Int32 intNum1 = 0, intNum2 = 0, intNum3, intResult = 0;
            Double dblResult;

            //Gets user's name and addresses user
            Console.WriteLine ("Hello There!");

            Console.Write ("Please enter your first name: ");
            strFirst = Console.ReadLine();

            Console.WriteLine ("Hello " + strFirst + "! Let's do some math!");

            //Gets numbers and opperand for opperation from user
            Console.Write ("Please enter the first number: ");
            strNum1 = Console.ReadLine();

            Console.Write ("Please enter the math operation (PLUS, MINUS, MULTIPLY, DIVIDE): ");
            strOperand = Console.ReadLine().ToLower();

            Console.Write ("Please enter the second number: ");
            strNum2 = Console.ReadLine();

            //Parses provided numbers to ints
            intNum1 = Int32.Parse(strNum1);
            intNum2 = Convert.ToInt32 (strNum2);

            //Performs opperations based on users input
            switch (strOperand) {
                case "plus" or "+":
                    intResult = intNum1 + intNum2;
                    break;
                case "minus" or "-":
                    intResult = intNum1 - intNum2;
                    break;
                case "divide" or "/":
                    intResult = intNum1 / intNum2;
                    break;
                case "multply" or "*":
                    intResult = intNum1 * intNum2;
                    break;
            }

            //Parses oppertion result
            dblResult = (Double) intResult;

            //Returns result to console
            if (strOperand == "plus" || strOperand == "+"){
                Console.WriteLine ($"\n\nThe sum of {intNum1} and {intNum2} equals: {dblResult}");
            } else if (strOperand == "minus" || strOperand == "-"){
                Console.WriteLine ($"\n\nThe difference of {intNum1} and {intNum2} equals: {dblResult}");
            } else if (strOperand == "divide" || strOperand == "/"){
                Console.WriteLine ($"\n\nThe quotient of {intNum1} and {intNum2} equals: {dblResult}");
            } else if (strOperand == "multiply" || strOperand == "*")
                Console.WriteLine ($"\n\nThe product of {intNum1} and {intNum2} equals: {dblResult}");

            //Exits program
            Console.WriteLine ("\n\nPress Any Key to Continue");
            Console.ReadKey ();
        }
    }
}