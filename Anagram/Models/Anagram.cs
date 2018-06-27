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
    public string Comparision(string wordList, string inputWord)
    {
      // string nope = "Not an anagram";
      string sortedWord = String.Concat(inputWord.OrderBy(c=>c));
      string[] wordCheck = wordList.Split(' ');
      List<string> result=new List<string>{};
      foreach (string word in wordCheck)
      {

        if (inputWord.Length == word.Length)
        {
          string newWord = String.Concat(word.OrderBy(c=>c));
          if(sortedWord == newWord)
          {
            result.Add(word);
          }
        }
        //Assert.Fail("Not an anagram");
      }
      string[] tempArray = result.ToArray();
      string anagramWord = tempArray.ToString();
      return anagramWord;
    }
  }
  public class Program
  {
    public static void Main()
    {
      Anagram myAnagram = new Anagram();
      Console.WriteLine("Input an initial word.");
      string inputWord = Console.ReadLine();
      Console.WriteLine("Input a list of possible anagram words");
      string wordList = Console.ReadLine();
      string result = myAnagram.Comparision(wordList, inputWord);
      Console.WriteLine(anagramWord);
    }
  }
}
