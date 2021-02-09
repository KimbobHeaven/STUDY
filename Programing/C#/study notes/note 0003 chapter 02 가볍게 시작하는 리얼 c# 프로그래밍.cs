using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
// 문자열 출력

ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

/*
type name;  // 변수선언
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer;
            double real;

            integer = 10;
            real = 20;
        }
    }
}
// integer = 10.1 선언시 오류출력

ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char character;
            string character2;

            character = 'c';
            character2 = "character";
        }
    }
}
// char, string 길이차이

ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer;
            double real;
            string text;

            integer = Convert.ToInt32(10.1);
            real = 20;
            text = Convert.ToString(real);
            integer = Convert.ToInt32(text);
        }
    }
}
// 변수형은 강제로 바꿔줘야함

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer;
            double real;
            string text;

            integer = (int)10.1;
            real = 20;
            text = real.ToString();
            integer = int.Parse(text);
        }
    }
}
// 위처럼 써도 같은효과를 가짐

ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("test");
            Console.Write("test2");
            
            Console.WriteLine("test3");
            Console.WriteLine("test4");
        }
    }
}
// WriteLine : Write + \n

ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("10 x 10");
        }
    }
}
// 커서위치 이동, WriteLine의 시작하는곳이 10, 10

ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input : ");
            string str = Console.ReadLine();
            Console.WriteLine("input = " + str);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input : ");
            int ch = Console.Read();
            Console.WriteLine("input = " + (char)ch);
        }
    }
}
// ReadLine : input 을 string 으로 저장, Read : input 의 첫글자를 int 로 저장

ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input : ");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine("\ninput = " + key.Key);
        }
    }
}
// enter 없이 한글자를 input, 속성개념은 후에설명

ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 6;

            if (value > 5)
            {
                Console.WriteLine("True");
            }
        }
    }
}
// 조건문사용

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 6;

            if (value > 5)
            {
                Console.WriteLine("True");
            }
            else if (value < 5)
            {
                
            }
            else
            {
                
            }
        }
    }
}
// else if 로 사용

ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 6;

            switch (value)
            {
                case 1:
                    Console.WriteLine('1');
                    break;
                case 6:
                    Console.WriteLine('6');
                    break;
            }
        }
    }
}
// switch (변수) case (값) 형태에서 변수와 값이 같을경우 실행, 다를경우 패스

ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 0; n < 100; n++)
            {
                Console.WriteLine("repeat");
            }
        }
    }
}
// 반복문사용 for(초깃값; 조건식; 증가 또는 감소식;)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int k = 1; k <= 9; k++)
            {
                for (int n = 1; n <= 9; n++)
                {
                    Console.WriteLine(k + " x " + n + " = " + k * n);
                }
            }
        }
    }
}
// 구구단

ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("True");
                break;
            }
        }
    }
}
// while사용

ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

