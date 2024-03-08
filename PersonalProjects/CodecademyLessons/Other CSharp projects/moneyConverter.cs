using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      // Currencies
      int gold = 10;
      int silver = 5;

      // Userinput
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("How much many coins do you wanna convert: ");
      string input = Console.ReadLine();
      double coins = Math.Floor(Convert.ToDouble(input));
      // Calculations
      double goldCoins = Math.Floor(coins / gold) ;
      double leftOver = coins % gold ;

      double silverCoins = Math.Floor(leftOver / 5);
      double bronzeCoins = leftOver % 5;

      // Outputs process

      Console.WriteLine( $"{coins} cents is equal to {goldCoins} goldcoins, {silverCoins} silvercoins and {bronzeCoins} bronzecoins.");
    }
  }
}
