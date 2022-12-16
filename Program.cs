// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Console.WriteLine("Input number");
// int a = int.Parse(Console.ReadLine());
// void FillArray(int[] mass1)
// {
//  for(int i = 0; i < mass1.Length; i++)
//   {
//     mass1[i] = new Random().Next(100,1000);
//   }
// }
// void PrintArray(int[] mass)
//  {
//   for(int i=0; i<mass.Length; i++)
//   Console.Write($"{mass[i]} " );
//  }
// int SumEven(int[] array)
// {
//   int Sum = 0;
//   int Sum1= 0;
//   for(int i=0; i<array.Length; i++)
//   {
//     if(array [i] % 2 == 0)
//     {
//      Sum = Sum + array[i];
//     }
//     else
//     {
//       Sum1 = Sum1 + array[i];
//     }
//   }  
//  return Sum;
//  }
// int[] arr = new int[a];
// FillArray(arr);
// PrintArray(arr);
// Console.WriteLine();
// Console.Write($"Sum of even digits in array is {SumEven(arr)}");

//Взял нечетные индексы, но с позиции бытового здравого смысла, значения массива на четных местах!
// Console.WriteLine("Input number");
// int a = int.Parse(Console.ReadLine());
// void FillArray(int[] mass1)
// {
//  for(int i = 0; i < mass1.Length; i++)
//   {
//     mass1[i] = new Random().Next(-10,20);
//   }
// }
// void PrintArray(int[] mass)
//  {
//   for(int i=0; i<mass.Length; i++)
//   Console.Write($"{mass[i]} " );
//  }
// int SumOfOddIndexes(int[] array)
// {
//   int Sum = 0;
//   for(int i=1; i<array.Length; i+=2)
//   {
//      Sum = Sum + array[i];
//   }
//  return Sum;
//  }
// int[] arr = new int[a];
// FillArray(arr);
// PrintArray(arr);
// Console.WriteLine();
// Console.Write($"Sum of odd indexes values is {SumOfOddIndexes(arr)}");

// Console.WriteLine("Input number");
// int a = int.Parse(Console.ReadLine());
// void FillArray(double[] mass1)
// {
//   Random random = new Random();
//  for(int i = 0; i < mass1.Length; i++)
//   {
//     mass1[i] = random.NextDouble()*100;
//   }
// }
// void PrintArray(double[] mass)
//  {
//   for(int i=0; i<mass.Length; i++)
//   Console.Write($"{Math.Round(mass[i],2)} ");
//  }
// int FindMaxMin(double[] array)
// {
//   double Min = array[0];
//   double Max = array[0];
//   for(int i=0; i<array.Length; i++)
//   {
//      if(array[i]>Max)
//      Max=array[i];
//      if(array[i]<Min)
//      Min=array[i];
//   }
//   int Dif = (int)(Max - Min);
//  return Dif;
//  }
// double[] arr = new double[a];
// FillArray(arr);
// PrintArray(arr);
// Console.WriteLine();
// Console.Write(FindMaxMin(arr));

// int ReadInt()
// {
// Console.WriteLine("Input number of numbers");
// int m = int.Parse(Console.ReadLine());
// return m;
// }
// int [] MakeFillArray(int Length)
// {
// int[] arr = new int[Length];
//   for(int i = 0; i < Length; i++)
//   {
//     arr[i] = new Random().Next(-100, 101);
//   }
//   return arr;
// }
// void PrintArray(int[] Arr)
// {
//     for(int i = 0; i < Arr.Length; i++)
//   {
//     Console.Write($"{Arr[i]} ");
//   }
// }
// void GetNumberOfPositives(int[] mass)
// {
//   int[] massive = new int[mass.Length];
//   int Sum = 0;
//   for(int i = 0; i < mass.Length; i++)
//   {
//     if(mass[i] > 0)
//     Sum++;
//   }
//   Console.WriteLine($"Number of positives is {Sum}");
// }
// int[] Array = MakeFillArray(ReadInt());
// PrintArray(Array);
// Console.WriteLine();
// GetNumberOfPositives(Array);

// Console.WriteLine("Input coefficients k1, b1, k2, b2");
// double k1 = Convert.ToDouble(Console.ReadLine());
// double b1 = Convert.ToDouble(Console.ReadLine());
// double k2 = Convert.ToDouble(Console.ReadLine());
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.Write($"k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2}");
// double x = (b2-b1)/(k1-k2);
// System.Console.WriteLine();
// if(k1==k2 && b1==b2)
// {
// Console.WriteLine("Lines are coinside");
// }
// else if(k1==k2 && !(b1==b2))
// {
// Console.WriteLine("Lines are parallel");
// }
// else
// {
// Console.Write($"Coordinates of interception of two lines: ({Math.Round(x,3)}, {Math.Round(x*k1+b1,3)})");
// } 
