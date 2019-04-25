using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Hello welcome to our BOOTY");
      Console.WriteLine("What is your word?");
      string userInput = Console.ReadLine().ToUpper();
      Word newWord = new Word(userInput);
      Console.WriteLine(newWord.GetValue());
    }
  }
}
