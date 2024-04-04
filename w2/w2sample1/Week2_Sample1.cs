using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Sample1 {
    class Program {
        static void Main (string[] args) {

            //Declare vars
            String strFirst, strNum, strCntr;
            Double dblNum = 0, dblTotal = 0, dblResult = 0;
            Int32 intCntr = 0;
            bool blnResult = false;
            bool amtResult = false;

            while(amtResult == false){
                Console.WriteLine ("Averager Program: How many week's earning are you going to average?"); // prompting user input
                strCntr = Console.ReadLine (); //stores new user input as strCntr
                amtResult = Int32.TryParse (strCntr, out intCntr); // converts string into integer
                // TryParse = tries to parse amtResult and if true, then changes intCntr to provide a value, otherwise it does not change
                if(amtResult == false){
                    Console.WriteLine ("\nSorry, but you did not enter a valid real number in digits: Ex 8");
                }
            }
            //Double[] dblEarnings = new Double[intCntr]; //creates a list of doubles of length provided

            Console.WriteLine ("Averager Program: Enter weekly earnings.\n\n"); // prompting user input

            //********************************************************************************************************************************************
            //********************************************************************************************************************************************
            for (int intCounter = 0; intCounter < intCntr; intCounter++) { // defines the counter and counts and loops for the amount provided by user
                //*********************************************************************************************************************************
                do { // runs each payroll indicated by user and checks that a number is entered
                    Console.Write ("Please enter payroll #" + (intCounter + 1) + ": ");
                    strNum = Console.ReadLine ();

                    blnResult = Double.TryParse (strNum, out dblNum); // converting string to double

                    if (blnResult == false) {
                        Console.WriteLine ("\n\nSorry, but you did not enter a valid real number in digits: Ex 1051.00."); //checks if user input is a real number
                    }
                } while (blnResult == false); // does the check for a real number entered (continually)
                //*********************************************************************************************************************************
                dblTotal += dblNum; // retrieves total amount entered for entire pay period

            }
            //********************************************************************************************************************************************

            //*************************************************************************************************************************************
            //*************************************************************************************************************************************

            dblResult = (dblTotal / intCntr); // calculating the average by dividing dblTotal by intCntr
            Console.WriteLine ("The average of the weekly earnings entered is: $" + dblResult); // displays calculated average weekly earnings

            //*************************************************************************************************************************************
            //*************************************************************************************************************************************
            Console.WriteLine ("\n\nPress Any Key to Continue"); //exits the program
            Console.ReadKey ();

        }
    }
}