// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Console.WriteLine ("Input first number");
// int i = int.Parse(Console.ReadLine());
// Console.WriteLine("Input second number");
// int j = int.Parse(Console.ReadLine());
// if (i > j)
// {
//   Console.WriteLine("First number is more than second");
// }
// else if (i < j)
// {
//   Console.WriteLine("Second number is more than first");
// }
// else
// {
//   Console.WriteLine("First and second numbers are equal");
// }  

// Console.WriteLine ("Input first number");
// int a = int.Parse(Console.ReadLine());
// Console.WriteLine ("Input second number");
// int b = int.Parse(Console.ReadLine());
// Console.WriteLine("Input third number");
// int c = int.Parse(Console.ReadLine());
// int max;
// if (b > a)
// {
//     max = b;
// }
// else max = a;
// if (c > max) 
// {
//       max = c;
// }
// Console.WriteLine($"Max number is {max}");

//  Console.WriteLine("Input number");
//  int x = int.Parse(Console.ReadLine());
//  if (x % 2 == 0)
//  {
//    Console.WriteLine($"Number {x} is even");
//  }
//  else Console.WriteLine($"Number {x} is odd");

// Console.WriteLine("Input integer number more than 1");
// int x = int.Parse(Console.ReadLine());
// Console.WriteLine($"Even numbers from 1 to {x} are:");
// int i = 2;
//   while (i <= x )
//   {
//   Console.WriteLine(i);
//   i += 2;
//   }

// Console.WriteLine ("Input three-digit nuber");
// int x = int.Parse(Console.ReadLine());
// if (x > 99 && x < 1000)
// Console.WriteLine($"Second digit is {x/10%10}");
// else
// {
//   Console.WriteLine("It's not a three-digit nuber");
// }

//  Console.WriteLine ("Input  nuber");
//  int x = int.Parse(Console.ReadLine());
//  if(x < 100)
//  Console.WriteLine("There is no third digit here");
// else
// {
//     string str = x.ToString();
//     Console.WriteLine($"Third digit is {str[2]}");
// }

//  Console.WriteLine ("Input  number of a week day");
//  int x = int.Parse(Console.ReadLine());
//  if(x == 6 || x == 7)
//  Console.WriteLine ("It's weekend");
//  else
//  {
//  Console.WriteLine ("It's working day");   
//  }

//Палиндром
// Console.WriteLine("Input number");
// int x = int.Parse(Console.ReadLine());
// int temp = x;
// int y = 0;
// while(x > 0)
// {
//   y = y*10 + x%10;
//   x = x/10;
// }
// if(temp == y)
// Console.WriteLine("Palindrome");
// else
// {
// Console.WriteLine("Not palindrome");
// }

//Расстояние между точами
//  Console.WriteLine("Введите координаты точки А, каждую - с новой строки");
//    int[] Array1 = new int[3];
//          for(int i = 0; i < Array1.Length; i++)
//    {
//      Array1[i] = int.Parse(Console.ReadLine());
//    }
//  Console.WriteLine("Введите координаты точки В, каждую - с новой строки");
//    int[] Array2 = new int[3];
//          for(int i = 0; i < Array2.Length; i++)
//    {
//      Array2[i] = Int32.Parse(Console.ReadLine());
//    }
//   double d1 = 0;
//   for(int i = 0; i < 3; i++)
//    {
//     d1 = d1 + Math.Pow((Array1[i] - Array2[i]), 2);
//    }
// Console.WriteLine($"Расстояние между точками А и В равно {Math.Round(Math.Sqrt(d1), 3)}");

//Таблица кубов
// Console.WriteLine("Input number");
// int n = int.Parse(Console.ReadLine ());
// for(int i = 1; i <= n; i++)
// Console.WriteLine(i*i*i);

//Возведение в степень
// Console.WriteLine("Input number A as base");
// int a = int.Parse(Console.ReadLine ());
// Console.WriteLine("Input number B as exponent");
// int b = int.Parse(Console.ReadLine ());
// int x = 1;
// for(int i = 1; i <=b; i++)
// {
//  x = x*a;
// }
// Console.WriteLine($"Result of exponentation is {x}");

//Сумма цифр в числе
// Console.WriteLine("Input number");
// int x = int.Parse(Console.ReadLine());
// int a = 0;
// while(x > 0)
// {
//   a = a + x%10;
//   x = x/10;
// }
// System.Console.WriteLine($"Sum of digits in number is {a}");

//Массив
// Console.WriteLine("Введите последовательно элементы массива, каждый - с новой строки");
// int[] Array = new int[8];
// for(int i = 0; i < Array.Length; i++)
// {
//  Array[i] = int.Parse(Console.ReadLine());
// }
// Console.WriteLine();
// Console.Write("[");
// for(int i = 0; i < Array.Length; i++)
// {
//   Console.Write($" {Array[i]}");
// }
// Console.Write(" ]");