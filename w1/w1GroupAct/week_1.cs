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
            Dictionary<string, string> opperands = new Dictionary<string, string>(){
                {"PLUS","+"},
                {"MINUS","-"},
                {"MULTIPLY","*"},
                {"DIVIDE","/"},
                {"MODULUS","%"},
                {"EXPONENT","^"},
                {"POWER","^"}
            };

            Dictionary<string, string> resultantName = new Dictionary<string, string>(){
                {"+","sum"},
                {"-","difference"},
                {"*","product"},
                {"/","quotient"},
                {"%","remainder"},
                {"^","power"},
            };
            
            Double intNum1 = 0, intNum2 = 0;
            Double dblResult = 0;

            //Gets user's name and addresses user
            Console.WriteLine ("Hello There!");

            Console.Write ("Please enter your first name: ");
            strFirst = Console.ReadLine();

            Console.WriteLine ("Hello " + strFirst + "! Let's do some math!");

            //Gets numbers and opperand for opperation from user
            Console.Write ("Please enter the first number: ");
            strNum1 = Console.ReadLine();
            Console.Write ($"Please enter the math operation ({string.Join(", ", new List<string>(opperands.Keys))}): ");
            strOperand = Console.ReadLine().ToUpper();

            Console.Write ("Please enter the second number: ");
            strNum2 = Console.ReadLine();

            //Parses provided numbers to ints
            intNum1 = Convert.ToDouble(strNum1);
            intNum2 = Convert.ToDouble(strNum2);

            //Performs opperations based on users input
            string result;
            if(opperands.TryGetValue(strOperand, out result)){
                strOperand = result;
            }

            switch (strOperand) {
                case "+":
                    dblResult = intNum1 + intNum2;
                    break;
                case "-":
                    dblResult = intNum1 - intNum2;
                    break;
                case "/":
                    dblResult = intNum1 / intNum2;
                    break;
                case "*":
                    dblResult = intNum1 * intNum2;
                    break;
                case "%":
                    dblResult = intNum1 % intNum2;
                    break;
                case "^":
                    dblResult = Math.Pow(intNum1,intNum2);
                    break;
            }

            //Returns result to console
            if(resultantName.TryGetValue(strOperand, out result)){
                Console.WriteLine ($"\n\nThe {result} of {intNum1} and {intNum2} equals: {dblResult}");
            }
            //Exits program
            Console.WriteLine ("\n\nPress Any Key to Continue");
            Console.ReadKey ();
        }
    }
}