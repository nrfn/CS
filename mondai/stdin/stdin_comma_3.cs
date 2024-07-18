// カンマ区切りの3つのデータの入力
using System;
class Program
{
    static void Main()
    {
        var line = Console.ReadLine();
        string[] words = line.Split(',');
        foreach (string word in words) {
            Console.WriteLine(word);
        }
    }
}