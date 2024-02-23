using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Testing
      // Console.WriteLine(Rectangle(4,5));
      // Console.WriteLine(Circle(4));
      // Console.WriteLine(Triangle(10,9));
      CalculateTotalCost();

    }
    // extra challenge
    
    static void CalculateTotalCost(){
      Console.WriteLine("Which monument would you like to calculate(1 Teotihuacan | 2 Taj Mahal | 3 Great Mosque of Mecca): ");
      string choice = Console.ReadLine();
      switch(choice){
        case "1":
        //Teotihuacan
          double first1 = Triangle(750,500);
          double second1 = Rectangle(1500,2500);
          double third1 = 0.5*Circle((375));
          double areaResult1 = (first1+second1+third1);
          double totalCost1 = Math.Round(areaResult1 * 180, 2);

          Console.WriteLine($"The total cost of the Teotihuacan is {totalCost1} pesos");
        break;
        case "2":
          double first2 = Rectangle(90.5, 90.5);
          double second2 = 4* Triangle(24,24);

          double areaResult2 = (first2-second2);
          double totalCost2 = Math.Round(areaResult2 * 180, 2);

          Console.WriteLine($"The total cost of the Taj Mahal is {totalCost2} pesos"); 
        break;
        case "3":
          double first3 = Rectangle(180,106);
          double second3 = Rectangle(284,264);
          double third3 = Triangle(84,264);
          double areaResult3 = (first3+second3-third3);
          double totalCost3 = Math.Round(areaResult3 * 180, 2);

          Console.WriteLine($"The total cost of the teotihuacan is {totalCost3} pesos");
        break;
        default:
        Console.WriteLine("Try to choose a number between 1-3");
        break;
      }


    }

    //defining basic shapes 
    //Rectangle area = length x width
    static double Rectangle(double length, double width){
      return length * width;
    }
    //Circle area = PI x radius²
    static double Circle(double radius){
      return Math.PI * Math.Pow(radius,2);
    }
    //Triangle area = 0.5 x bottom x height
    static double Triangle(double bottom, double height){
      return 0.5 * bottom * height;
    }


  }
}
