using System;

namespace HelloWorld
{
  class Program{
    static void Main(string[] args)
    {
      int numberAmount = 10;
      for(int bn = 1; bn <= numberAmount; bn++){
        for(int n = 1; n <= numberAmount; n++){
            int value = bn * n; 
            Console.Write($"{value}\t");
        }
        Console.WriteLine();
      }
    }
  }
}