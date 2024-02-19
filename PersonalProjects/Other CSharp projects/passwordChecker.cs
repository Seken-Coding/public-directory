using System;
using System.Text.RegularExpressions;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
        //default parameters
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "1234567890";
      string specialChars = "!#?ß.,-_:;";
      Console.WriteLine("Write a password: ");
      string input = Console.ReadLine();
      int score = 0;

      //Extra regex challenge //first&last regex with help of ChatGPT
      string pattern1 = @"^[\w\d\W]{8,}$";
      string pattern2 = @"[A-Z]";
      string pattern3 = @"[a-z]";
      string pattern4 = @"[0-9]";
      string pattern5 = @"^.*[^\w\s].*$";

      bool isMatch1 = Regex.IsMatch(input, pattern1);
      bool isMatch2 = Regex.IsMatch(input, pattern2);
      bool isMatch3 = Regex.IsMatch(input, pattern3);
      bool isMatch4 = Regex.IsMatch(input, pattern4);
      bool isMatch5 = Regex.IsMatch(input, pattern5);

      if(isMatch1){
        score++;
      }
      if(isMatch2){
        score++;
      }
      if(isMatch3){
        score++;
      }
      if(isMatch4){
        score++;
      }
      if(isMatch5){
        score++;
      }
      //    original exercise
      // if(input.Length >= minLength){
      //   score++;
      // };
      // if(Tools.Contains(input,uppercase)){
      //   score++;
      // };
      // if(Tools.Contains(input,lowercase)){
      //   score++;
      // }
      // if(Tools.Contains(input,digits)){
      //   score++;
      // }
      // if(Tools.Contains(input,specialChars)){
      //   score++;
      // }

      //extra challenge (if password is "password" or "1234" it will be scored 0)
      if(input == "password"){
        score = 0;
      }
      if(input == "1234"){
        score = 0;
      }

      //switch cases for rating
      switch(score){
        case 4 :
        case 5 :
          Console.WriteLine("Your pasword is extremely strong");
          break;
        case 3:
          Console.WriteLine("Your pasword is strong");
          break;
        case 2:
          Console.WriteLine("Your password is medium");
          break;
        case 1:
          Console.WriteLine("Your password is weak");
          break;
        default:
          Console.WriteLine("Your password matches nothing");
          break;
        }   
      Console.WriteLine("Your score is: " + score);
    }
  }
}
