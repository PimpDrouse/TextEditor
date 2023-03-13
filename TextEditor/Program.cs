using System;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace TextEditor
{
    public class TextEditor
    {
        public static void Main(string[] args)
        {
            string text = $"Введите путь до файла: \n{Console.ReadLine()}";
            Console.Clear();
            Console.WriteLine(text);
            List<StringBuilder> textMatrix = StringToMatrix(text);
            
            int x = 0, y = 0;
            Console.SetCursorPosition(x, y);
            while (true)
            {
                ConsoleKeyInfo key = new ConsoleKeyInfo();
                key = Console.ReadKey(true);
                switch(key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        x -= 1;
                        Console.SetCursorPosition(x, y);
                        break;
                    case ConsoleKey.RightArrow:
                        x += 1;
                        Console.SetCursorPosition(x, y);
                        break;
                    case ConsoleKey.DownArrow:
                        y += 1;
                        Console.SetCursorPosition(x, y);
                        break;
                    case ConsoleKey.UpArrow:
                        y -= 1;
                        Console.SetCursorPosition(x, y);
                        break;
                    case ConsoleKey.Escape:
                        goto end;
                    default:
                        textMatrix[y][x] = key.KeyChar;
                        break;
                }
                end:
                Console.WriteLine(MatrixToString(textMatrix));
            }
        }

        public static List<StringBuilder> StringToMatrix(string text) => text.Split("\n").Select(x => new StringBuilder(x)).ToList();
        public static string MatrixToString(List<StringBuilder> matrix) => String.Join("\n", matrix);
    }
}