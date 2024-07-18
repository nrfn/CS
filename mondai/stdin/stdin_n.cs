// N個のデータの入力
using System;
class Program
{
    static void Main()
    {
      var line = Console.ReadLine();
      var input_words = Console.ReadLine();
      string[] words = input_words.Split(' ');
      foreach (string word in words){
        Console.WriteLine(word);
      }
    }
}