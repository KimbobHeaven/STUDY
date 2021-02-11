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
            int student1 = 0, student2 = 0, student3 = 0, student4 = 0, student5 = 0;
            int sum = 0;

            for (int n = 1; n <= 5; n++)
            {
                Console.Write("enter " + n + "'s height : ");

                switch (n)
                {
                    case 1:
                        student1 = Convert.ToInt32(Console.ReadLine());
                        break;
                    
                    case 2:
                        student2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    
                    case 3:
                        student3 = Convert.ToInt32(Console.ReadLine());
                        break;
                    
                    case 4:
                        student4 = Convert.ToInt32(Console.ReadLine());
                        break;
                    
                    case 5:
                        student5 = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }

            sum = student1 + student2 + student3 + student4 + student5;
            Console.WriteLine("average = " + (sum / 5));
        }
    }
}
// without list

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
            int[] students = new int[5];
            int sum = 0;

            for (int n = 1; n <= 5; n++)
            {
                Console.Write("enter " + n + "'s height : ");

                students[n - 1] = Convert.ToInt32(Console.ReadLine());
                sum += students[n - 1];
            }

            Console.WriteLine("average = " + (sum / 5));
        }
    }
}
// with 1 dimension list

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
            int[] students = new int[5];
            int[] sum = new int[2];

            for (int n = 1; n <= 5; n++)
            {
                Console.Write("enter 1." + n + "'s height : ");

                students[n - 1] = Convert.ToInt32(Console.ReadLine());
                sum[0] += students[n - 1];
            }

            Console.WriteLine("average1 = " + (sum[0] / 5));
            
            for (int n = 1; n <= 5; n++)
            {
                Console.Write("enter 2." + n + "'s height : ");

                students[n - 1] = Convert.ToInt32(Console.ReadLine());
                sum[1] += students[n - 1];
            }

            Console.WriteLine("average2 = " + (sum[1] / 5));
        }
    }
}
// with just 1 dimension

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
            int[,] students = new int[2, 5];
            int[] sum = new int[2];

            for (int m = 1; m <= 2; m++)
            {
                for (int n = 1; n <= 5; n++)
                {
                    Console.Write("enter " + m + "." + n + "'s height : ");

                    students[m - 1, n - 1] = Convert.ToInt32(Console.ReadLine());
                    sum[m - 1] += students[m - 1, n - 1];
                }
                
                Console.WriteLine("average" + m + " = " + sum[m - 1] / 5);
            }
        }
    }
}
// with 2 dimensions, [a, b] 생성시 세로a 가로b로 생성 (행, 렬 순서)

ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

/*
type name (x)
{
    funtion
    return y;
}    
함수선언
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2_1
{
    class Program
    {
        static int Sum(int a, int b)
        {
            int c = a + b;

            return c;
        }
        
        static void Main(string[] args)
        {
            int result = Sum(10, 20);
            
            Console.WriteLine("10 + 20 = " + result);
        }
    }
}
// basic function

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2_1
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            
            Console.WriteLine("a = " + a + " b = " + b);

            Swap(ref a, ref b);
            
            
            Console.WriteLine("a = " + a + " b = " + b);
        }
    }
}
// function with ref : 매개변수를 복사하지않고 참조하라는 듯. 함수의 매개변수로 선언된 변수는 해당함수내에서만 유효하지만, 레퍼런스를 사용할 경우 함수 내에서 값이 변하더라도 함수 밖에서 똑같이 값이 변경됨
/* output : 
a = 10 b = 20
a = 20 b = 10
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2_1
{
    class Program
    {
        static void Swap(int a, int b)
        {
            int c = a;
            a = b;
            b = c;
        }
        
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            
            Console.WriteLine("a = " + a + " b = " + b);

            Swap(a, b);

            Console.WriteLine("a = " + a + " b = " + b);
        }
    }
}
// function without ref
/* output :
a = 10 b = 20
a = 10 b = 20
*/

ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2_1
{
    class Program
    {
        static void Function()
        {
            Console.WriteLine("no var");
        }

        static void Function(string s)
        {
            Console.WriteLine("input : s");
        }

        static void Main(string[] args)
        {
            Function();
            Function("function overloading");
        }
    }
}
// function overloading : 이름은 같지만 1. 함수형이 다른경우, 2. 매개변수의 경우 또는 변수형이 다른경우 함수들이 서로 구분됨

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex_2_1
{
    class Program
    {
        static void Sum(ref int result, int a, int b)
        {
            result = a + b;
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Sum(double a, double b)
        {
            return (int) (a + b);
        }

        static void Main(string[] args)
        {
            int result = 0;

            Sum(ref result, 10, 20);
            Console.WriteLine("void Sum(ref int result, int a, int b) : " + result);
            Console.WriteLine("int Sum(int a, int b) : " + Sum(10, 20));
            Console.WriteLine("int Sum(double a, double b) : " + Sum(10.0, 20.0));
        }
    }
}
// examples



