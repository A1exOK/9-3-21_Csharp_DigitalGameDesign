using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      // [ Cents ==> Coins Program | By: Alex ] \\
      /*
      This program will convert a given amount of cents to the nearest coin amount. 
      */
      
      // Startup Sequence \\
      Console.WriteLine("Loading variables... ");

      // Coin Variables
      double goldValue = 10;
      double silverValue = 5;

      // Main Menu
      Console.WriteLine("\n Welcome to Money Maker!");
      
      // MAIN CODE
      Console.WriteLine("\n Please enter an amount to convert: ");   // Amount to work with
      string strAmount = Console.ReadLine();
      double total = Convert.ToDouble(strAmount);

      // Gold Coin
      double goldCoins = Math.Floor(total / goldValue);  // Gets amount of gold coins
      double remainder = Math.Floor(total % goldValue);  // Gets Remainder 

      /* [ Test Code ]
      Console.WriteLine(goldCoins);    
      Console.WriteLine(remainder);
      */

      // Silver Coin
      double silverCoins = Math.Floor(remainder / silverValue); // Gets amount of silver coins
      double finalRemainder = Math.Floor(remainder % silverValue); // Gets rematinder

      // DISPLAY (Prints out number of coins)
      Console.WriteLine($"\n {total} cents is equal to: ");
      Console.WriteLine($"Gold Coins: {goldCoins}");
      Console.WriteLine($"Silver Coins: {silverCoins}");
      Console.WriteLine($"Bronze Coins: {finalRemainder}");
    }
  }
}

