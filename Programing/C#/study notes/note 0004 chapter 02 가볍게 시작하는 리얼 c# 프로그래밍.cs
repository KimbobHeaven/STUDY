using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2_1
{
    class Program
    {
        static int Choice()
        {
            while (true)
            {
                ConsoleKeyInfo key = InputKey();

                int n = ((int) key.Key) - 48;

                if (n > 0 && n <= 3)
                    return n;
            }
        }
        
        static ConsoleKeyInfo InputKey()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            return key;
        }
        
        static void ShowMenu()
        {
            Console.WriteLine("'내가' 만든 게임");
            Console.WriteLine("1. 가위 바위 보");
            Console.WriteLine("2. 탱크");
            Console.WriteLine("3. 끝내기");
            Console.WriteLine("무엇을 하시겠습니까?");
        }

        static void Main(string[] args)
        {
            ShowMenu();
            Console.SetCursorPosition(27, 4);

            int c = Choice();
        }
    }
}
// 메뉴구성
