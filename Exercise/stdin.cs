// 標準入力サンプル問題セット
using System;

class Program
{
    static void Main()
    {
      // 1つのデータの入力
      // 1行のデータの入力
      var line = Console.ReadLine();
      Console.WriteLine(line);

      // 3行のデータの入力
      var line1 = Console.ReadLine();
      var line2 = Console.ReadLine();
      var line3 = Console.ReadLine();
      Console.WriteLine(line1);
      Console.WriteLine(line2);
      Console.WriteLine(line3);

      // N行のデータの入力
      var line = Console.ReadLine();
      for(int i = 0; i < int.Parse(line); i++){
          var read = Console.ReadLine();
          Console.WriteLine(read);
      }

      // 3つのデータの入力
      var line = Console.ReadLine();
      string[] words = line.Split(' ');
      foreach (string word in words){
          Console.WriteLine(word);
      }

      // N個のデータの入力
      var line = Console.ReadLine();
      var input_words = Console.ReadLine();
      string[] words = input_words.Split(' ');
      foreach (string word in words){
        Console.WriteLine(word);
      }
    }
}