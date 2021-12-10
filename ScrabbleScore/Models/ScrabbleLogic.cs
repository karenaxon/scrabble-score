using System;
using System.Collections.Generic;

namespace ScrabbleScore.Models
{
  public class ScrabbleLogic
  {
    static Dictionary<char, int> oficeScrabbleDictionary = new Dictionary<char, int>(){
      {'a', 1},
      {'e', 1},
      {'i', 1},
      {'o', 1},
      {'u', 1},
      {'l', 1},
      {'n', 1},
      {'r', 1},
      {'s', 1},
      {'t', 1},
      {'d', 2},
      {'g', 2},
      {'b', 3},
      {'c', 3},
      {'m', 3},
      {'p', 3},
      {'f', 4},
      {'h', 4},
      {'v', 4},
      {'w', 4},
      {'y', 4},
      {'k', 5},
      {'j', 8},
      {'x', 8},
      {'q', 10},
      {'z', 10}
    };
    
    public static int CalcScore(string word)
    {
      int output = 0;
      string betterword = word.ToLower();

      for(int i = 0; i<betterword.Length;i++){
        output += oficeScrabbleDictionary[betterword[i]];
      }
      return output;
    }
  };
}
