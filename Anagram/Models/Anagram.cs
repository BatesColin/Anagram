using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagram
{
  public class Anagram
  {
    public static string Comparision(string wordList, string inputWord)
    {
      // string[] characters = inputWord.Sort();
      string sortedWord = String.Concat(inputWord.OrderBy(c=>c));
      string[] wordCheck = wordList.Split(' ');
      foreach (string word in wordCheck)
      {
        if (inputWord.Length == word.Length)
        {
          string newWord = String.Concat(word.OrderBy(c=>c));
          if(sortedWord == newWord)
          {
            return word;
          }
        }
        else
        {
          return Console.WriteLine("Not an anagram");
        }
      }
    }
 //"hat" ["tha" "bat" "the" "this"] = sorted
    public static void Main()
    {
      Console.WriteLine("Input an initial word.");
      public string inputWord = Console.ReadLine();
      Console.WriteLine("Input a list of possible anagram words");
      public string wordList = Console.ReadLine();
    }
  }
}
