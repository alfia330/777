using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Введите имя файла: ");
        string file = Console.ReadLine();

        if (!File.Exists(file))
        {
            Console.WriteLine("Файл не существует. Программа завершена.");
            return;
        }

        string text = File.ReadAllText(file);
        File.WriteAllText("output.txt", text.ToUpper());
        Console.WriteLine("Содержимое записано в output.txt заглавными буквами.");
    }
}