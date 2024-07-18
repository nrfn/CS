// カンマ区切りのN個のデータの入力
using System;
class Program
{
    static void Main()
    {
        var line = Console.ReadLine();
        var readline = Console.ReadLine();
        string[] words = readline.Split(',');
        foreach (string word in words) {
            Console.WriteLine(word);
        }
    }
}