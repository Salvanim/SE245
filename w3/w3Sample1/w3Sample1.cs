using System;
using System.Collections.Generic;

namespace Week3_Sample1 {
    class Program {
        static void Pause () {
            Console.WriteLine ("\n\nPress Any Key to Continue");
            Console.ReadKey ();
        }

        static double CalcAvg (double dblTotal, int intNumofPaychecks) {
            double dblResult = (dblTotal / intNumofPaychecks);
            return dblResult;
        }

        static void DisplayTheList (List<double> dblListIncoming) {
            int intCntr = 1;
            foreach (double d in dblListIncoming) {
                Console.WriteLine ($"Weekly entry #{intCntr}: ${d}");
                intCntr++;
            }
        }

        static void StoreToTheList (List<double> dblEarnings, ref double dblTotal, ref int intCounter, double dblPaycheck) {
            dblEarnings.Add (dblPaycheck);
            dblTotal += dblPaycheck;
            intCounter++;
        }

        static bool IsValidDouble (String strNum) {
            double dblNum = 0;
            bool blnResult = Double.TryParse (strNum, out dblNum);
            return blnResult;
        }

        static void Main (string[] args) {
            String strFirst, strNum, strCntr;
            Double dblNum = 0, dblTotal = 0, dblResult = 0;
            Int32 intCntr = 0;
            bool blnResult = false;

            List<double> dblEarnings = new List<double> ();

            Console.WriteLine ("Averager Program: Enter weekly earnings.  (a -1 to end entries)\n\n");

            do {
                do {
                    Console.Write ("Please enter payroll #" + (intCntr + 1) + ": ");
                    strNum = Console.ReadLine ();
                    blnResult = IsValidDouble (strNum);

                    if (blnResult == false) {
                        Console.WriteLine ("\n\nSorry, but you did not enter a valid real number in digits: Ex 1051.00.");
                    } else {
                        dblNum = Double.Parse (strNum);
                    }
                } while (blnResult == false);

                if (dblNum >= 0) {
                    StoreToTheList (dblEarnings, ref dblTotal, ref intCntr, dblNum);
                }

            } while (dblNum >= 0);

            DisplayTheList (dblEarnings);

            dblResult = CalcAvg (dblTotal, intCntr);
            Console.WriteLine ("The average of the weekly earnings entered is: $" + dblResult);

            Pause ();
        }
    }
}