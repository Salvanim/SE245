using System;

namespace structChallange
{
  class Program{
    struct Point{
        public int X;
        public int Y;
    }

    static Point GetRandomPoint(int minX, int minY, int maxX, int maxY){
        Random rnd = new Random();
        Point ranPoint = new Point();
        ranPoint.X = rnd.Next(minX, maxX);
        ranPoint.Y = rnd.Next(minY, maxY);
        return ranPoint;
    }

    static void Main(string[] args)
    {
        int minimumX = 10;
        int minimumY = 10;
        string cont = "";
        while(cont == ""){
            Point RandomPoint = GetRandomPoint(-minimumY, -minimumY, minimumX, minimumY);
            Console.Write($"({RandomPoint.X},{RandomPoint.Y})");
            cont = Console.ReadLine();
        }
    }
  }
}