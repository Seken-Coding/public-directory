using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {

      Encrypt();
      Decrypt();
      
    }

    static void Encrypt()
    {
      //Array to assign letters properly
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

      //UserInput
      Console.WriteLine("Type a message to encrypt: ");
      string message = Console.ReadLine().ToLower();

      //Inserting String to a char array
      char[] secretMessage = message.ToCharArray();
      //Creating a result array with the same length as the userinput array
      char[] encryptedMessage = new char[secretMessage.Length];

      //Loop to encrypt, checks for length of the array and then shifts letters by 3 to the right. Afterwards it inputs in a char array and joins them to display the result 
      for(int i = 0; i < secretMessage.Length; i++)
      {
        char temp = secretMessage[i];
        int pos = (Array.IndexOf(alphabet,temp)+ 3) % 26; // encrypting here
        char output = alphabet[pos];
        encryptedMessage[i] = output;
      }
      string result = string.Join("",encryptedMessage);
      Console.WriteLine(result);
    }
    // just reverse encryption reversed the alphabet array to invert the result
    static void Decrypt()
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'}; 
      Array.Reverse(alphabet); 
      Console.WriteLine("Type a message to decrypt: ");
      string message = Console.ReadLine().ToLower();
      char[] secretMessage = message.ToCharArray();
      char[] encryptedMessage = new char[secretMessage.Length];
      for(int i = 0; i < secretMessage.Length; i++)
      {
        char temp = secretMessage[i];
        int pos = (Array.IndexOf(alphabet,temp)+ 3) % 26; // decrypting here
        char output = alphabet[pos];
        encryptedMessage[i] = output;
      }
      string result = string.Join("",encryptedMessage);
      Console.WriteLine(result);
    }
  }
}