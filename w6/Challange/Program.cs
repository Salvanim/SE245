using System;
using System.Linq; 

namespace midterm
{
  class Program{

    static void Main(string[] args){
        Console.WriteLine(isPalindrome("Race Car").ToString());
    }

    public bool isPalindrome(string testString){
        testString = testString.ToUpper().Replace(" ", "");
        string reversedString = "";
        for(int i = testString.Length; i > 0; i--){
            reversedString = testString[i].ToString();
        }
        if(reversedString == testString){
            return true;
        }
        return false;
    }

    public string onlyBaseText(string stringToConvert){
        return stringToConvert.ToUpper().Replace(" ", "");
    }

  }
}