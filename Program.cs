﻿// See https://aka.ms/new-console-template for more information
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

// int ReadInt()
// {
// Console.WriteLine("Input number");
// int m = int.Parse(Console.ReadLine());
// return m;
// }
// double [,] MakeFillArray(int Length1, int Length2)
// {
//  Random random = new Random(); 
// double[,] arr = new double[Length1, Length2];
//   for(int i = 0; i < Length1; i++)
//   {
//     for(int j = 0; j < Length2; j++)
//     arr[i, j] = random.NextDouble()*200-100;
//   }
//   return arr;
// }
// void PrintArray(double[,] Arr)
// {
//     for(int i = 0; i < Arr.GetLength(0); i++)
//   {
//     for(int j = 0; j < Arr.GetLength(1); j++)
//     {
//       Console.Write($" {Math.Round(Arr[i,j],2)}  ");
//     }
//     Console.WriteLine();
//   }
// }
// double[,] Array = MakeFillArray(ReadInt(),ReadInt());
// PrintArray(Array);
// Console.WriteLine();

// int ReadInt()
// {
// Console.WriteLine("Input number");
// int m = int.Parse(Console.ReadLine());
// return m;
// }
// int [,] MakeFillArray(int Length1, int Length2)
// {
// int[,] arr = new int[Length1, Length2];
//   for(int i = 0; i < Length1; i++)
//   {
//     for(int j = 0; j < Length2; j++)
//     arr[i, j] = new Random().Next(-100, 101);
//   }
//   return arr;
// }
// void PrintArray(int[,] Arr)
// {
//     for(int i = 0; i < Arr.GetLength(0); i++)
//   {
//     for(int j = 0; j < Arr.GetLength(1); j++)      
//     Console.Write($"{Arr[i,j]} ");
//     Console.WriteLine();
//   }
// }
// void FindValue(int[,] Arr)
// {
//   Console.WriteLine("Input value to find");
//   int x = int.Parse(Console.ReadLine());
//   int Count = 0;
//    for(int i = 0; i < Arr.GetLength(0); i++)
//   {
//     for(int j = 0; j < Arr.GetLength(1); j++)
//        if(Arr[i,j]==x )
//       {
//        Console.WriteLine($"Value {x} occures in array cell ({i},{j})");
//        Count++;
//       }
//   }      
//          if(Count==0)
//          System.Console.Write("There is no such value in array"); 
//          else
//          Console.WriteLine($"Value {x} occures in array {Count} time(s)");           
// }     
// int[,] Array = MakeFillArray(ReadInt(),ReadInt());
// PrintArray(Array);
// Console.WriteLine();
// FindValue(Array);

// int ReadInt()
// {
// Console.WriteLine("Input numbers");
// int m = int.Parse(Console.ReadLine());
// return m;
// }
// int [,] MakeFillArray(int Length1, int Length2)
// {
// int[,] arr = new int[Length1, Length2];
//   for(int i = 0; i < Length1; i++)
//   {
//     for(int j = 0; j < Length2; j++)
//     arr[i, j] = new Random().Next(-100,101);
//   }
//   return arr;
// }
// void PrintArray(int[,] Arr)
// {
//     for(int i = 0; i < Arr.GetLength(0); i++)
//   {
//     for(int j = 0; j < Arr.GetLength(1); j++)      
//     Console.Write($"{Arr[i,j]} ");
//     Console.WriteLine();
//   }
// }
// void ColumnAverage(int[,] Arr)
// {
//    double[] Average = new double[Arr.GetLength(1)];
//    for(int j = 0; j < Arr.GetLength(1); j++)
//      {
//        double Sum=0;  
//          for(int i = 0; i < Arr.GetLength(0); i++)
//            Sum+=Arr[i,j];      
//            Average[j] = Sum/Arr.GetLength(0);
//            Console.Write($"{Math.Round(Average[j],1)}  ");   
//      }    
// }  
// int[,] Array = MakeFillArray(ReadInt(),ReadInt());
// PrintArray(Array);
// Console.WriteLine("Average values of array columns are:");
// ColumnAverage(Array);

// int ReadInt()
// {
// Console.WriteLine("Input numbers");
// int m = int.Parse(Console.ReadLine());
// return m;
// }
// int [,] MakeFillArray(int Length1, int Length2)
// {
// int[,] arr = new int[Length1, Length2];
//   for(int i = 0; i < Length1; i++)
//   {
//     for(int j = 0; j < Length2; j++)
//     arr[i, j] = new Random().Next(-100,101);
//   }
//   return arr;
// }
// void PrintArray(int[,] Arr)
// {
//     for(int i = 0; i < Arr.GetLength(0); i++)
//   {
//     for(int j = 0; j < Arr.GetLength(1); j++)      
//     Console.Write($"{Arr[i,j]} ");
//     Console.WriteLine();
//   }
// }
// void UpdateArray(int [,] Arr)
// {
//    int Temp =0;
//    for(int k = 0; k < Arr.GetLength(0); k++)
//   {
//      for(int j = 0; j<Arr.GetLength(1); j++)
//      {
//        for(int i = j+1; i<Arr.GetLength(1); i++)
//        {
//          if(Arr[k,i] > Arr[k,j])
//              {
//                Temp = Arr[k,i];
//                Arr[k,i] = Arr[k,j];
//                Arr[k,j] = Temp;
//              }
//        }
//        Console.Write($"{Arr[k,j]} ");
//      }
//     Console.WriteLine();  
//   }
//  }     

// int[,] Array = MakeFillArray(ReadInt(),ReadInt());
// PrintArray(Array);
// Console.WriteLine();
// UpdateArray(Array);

// int ReadInt()
// {
//   Console.WriteLine("Input numbers");
//  int m = int.Parse(Console.ReadLine());
//  return m;
// }
// int [,] MakeFillArray(int Length1, int Length2)
// {
//   int[,] arr = new int[Length1, Length2];
//   for(int i = 0; i < Length1; i++)
//   {
//     for(int j = 0; j < Length2; j++)
//     arr[i, j] = new Random().Next(-100,101);
//   }
//   return arr;
// }
// void PrintArray(int[,] Arr)
// {
//   for(int i = 0; i < Arr.GetLength(0); i++)
//  {
//   for(int j = 0; j < Arr.GetLength(1); j++)      
//   Console.Write($"{Arr[i,j]} ");
//   Console.WriteLine();
//  }
// }
// void FindMinRowSum(int [,] Arr)
// {
//    int[] row = new int[Arr.GetLength(0)];
//    int Min = row[0];
//    int MinIndex = 0;
//    for(int i = 0; i < Arr.GetLength(0); i++)
//   {
//     int Sum =0;
//     for(int j = 0; j < Arr.GetLength(1); j++)
//    {
//     row[i] = Sum+=Arr[i, j];
//    }
//    if(row[i] < Min)
//    {
//     Min = row[i];
//     MinIndex = i;
//    }
//   }
//     Console.Write($"Min sum cells row from top  is {MinIndex+1} ");
// }     
// int[,] Array = MakeFillArray(ReadInt(),ReadInt());
// PrintArray(Array);
// Console.WriteLine();
// FindMinRowSum(Array);

// int ReadInt()
// {
//   Console.WriteLine("Input numbers, first bigger than second");
//  int m = int.Parse(Console.ReadLine());
//  return m;
// }
// void ListBetweenNumbers(int n, int m)
// {
//    if(n>m)
//   {
//    Console.Write(m+ ", ");
//    ListBetweenNumbers(n, m+1);
//   }
//   else  Console.Write(n); 
// }
// ListBetweenNumbers(ReadInt(),ReadInt());

// int SumBetweenNumbers(int m, int n)
// {
//   if(m==n) return n;
//   else return SumBetweenNumbers(m,n-1)+n;
// }
// int ReadInt()
// {
//   Console.WriteLine("Input numbers, first smaller than second");
//  int m = int.Parse(Console.ReadLine());
//  return m;
// }
// Console.WriteLine(SumBetweenNumbers(ReadInt(),ReadInt()));

//   uint Ackerman (uint m, uint n)
//   {
//     if(m==0)
//     {
//     return n+1;
//     }
//     else if(n==0 && m !=0)
//     {
//     return Ackerman(m-1, 1);
//     } 
//     else  return Ackerman(m-1, Ackerman(m, n-1));
//   }
//   uint ReadInt()
//   {
//     Console.WriteLine("Input numbers");
//   uint m = uint.Parse(Console.ReadLine());
//   return m;
//   }
//   Console.WriteLine(Ackerman (ReadInt(), ReadInt()));

