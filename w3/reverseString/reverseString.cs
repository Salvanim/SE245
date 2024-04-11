namespace reverseString {
    class Program {
        static string reverseString (string reverse) {
            string reversed = "";
            for(int i = reverse.Length-1; i >= 0; i--){
                reversed += reverse[i];
            }
            return reversed;
        }

        static string shiftString (string shift, int startIndex){
            string shifted = "";
            for(int i = startIndex; i <= (shift.Length-1 + startIndex); i++){
                if(i > shift.Length-1){
                    shifted += shift[i % startIndex];
                } else {
                    shifted += shift[i];
                }
            }
            return shifted;
        }
        static void Main (string[] args) {
            Console.Write("\nWhat string do you want to reverse?: ");
            Console.WriteLine(reverseString(Console.ReadLine())); 

            Console.Write("\nWhat string do you want to shift?: ");
            
            string shiftingString = Console.ReadLine();
            bool isNum = false;
            int shiftIndex = 0;
            
            while(!isNum){
                
                Console.Write("\nWhat index do you want to shift to? (#): ");
                isNum = Int32.TryParse(Console.ReadLine(), out shiftIndex);
                
                if(!isNum){
                    Console.WriteLine("Not a number, try again. ");
                }

            }

            Console.WriteLine(shiftString(shiftingString, shiftIndex));
        }
    }
}