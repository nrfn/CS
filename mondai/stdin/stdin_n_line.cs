// N行のデータの入力
using System;
class Program
{
    static void Main()
    {
      var line = Console.ReadLine();
      for(int i = 0; i < int.Parse(line); i++){
          var read = Console.ReadLine();
          Console.WriteLine(read);
      }
    }
}