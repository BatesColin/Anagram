using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagram
{
  public class Anagram
  {
    public Anagram()
    {

    }
    public static string Comparision(string wordList, string inputWord)
    {
      public string nope = "Not an anagram";
      // string[] characters = inputWord.Sort();
      string sortedWord = String.Concat(inputWord.OrderBy(c=>c));
      string[] wordCheck = wordList.Split(' ');
      foreach (string word in wordCheck)
      List<string> result=new List<string>{};
      {
        if (inputWord.Length == word.Length)
        {
          string newWord = String.Concat(word.OrderBy(c=>c));
          if(sortedWord == newWord)
          {
            result.Add(word);
          }
        }
      }
    }
      string[] tempArray = result.ToArray();
      string anagramWord = tempArray.ToString();
      return anagramWord;
    }
  public class Program
  {
    public static void Main()
    {
      Anagram myAnagram = new Anagram();
      Console.WriteLine("Input an initial word.");
      public string inputWord = Console.ReadLine();
      Console.WriteLine("Input a list of possible anagram words");
      public string wordList = Console.ReadLine();
      string result = myAnagram.Comparision(wordList, inputWord)
      Console.WriteLine(anagramWord);
    }
  }
}
