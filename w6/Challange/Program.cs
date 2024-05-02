using System;
using System.Linq; 

namespace midterm
{
  class Program{

    static void Main(string[] args){
        Console.WriteLine(isPalindrome("RacE car?"));
    }

    public static bool isPalindrome(string testString){
        int fi = 0;
        int bi = testString.Length-1;
        while(fi < testString.Length/2 && bi >= testString.Length/2){
            if (testString[fi] == ' ' || char.IsPunctuation(testString[fi])){
                fi++;
            }

            if (testString[bi] == ' ' || char.IsPunctuation(testString[bi])){
                bi--;
            }
            
            if(Char.ToLower(testString[fi]) != Char.ToLower(testString[bi]) ){
                return false;
            }
            fi++; 
            bi--;
        }
        return true;
    }

  }
}