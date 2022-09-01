using System;

class MyNewClass
{

    public static  void MyTask1()
    {
        //         : Задайте массив из 12 элементов, заполненный
        // случайными числами из промежутка [-9, 9]. Найдите сумму
        // отрицательных и положительных элементов массива.
       int [] MyArr = new int[12];
       int SumMin =0, SumPl = 0;

       for (int i = 0; i< MyArr.Length; i++)
       {
            MyArr[i]= new Random().Next(-9,10);
            if (MyArr[i]<0)  SumMin += MyArr[i];
            else SumPl += MyArr[i];

       }

       Console.WriteLine(String.Join(", ", MyArr ));
       Console.WriteLine($"Сумма отрицательных {SumMin}");
       Console.WriteLine($"Сумма положительных {SumPl}");
       
    }

    public static  void MyTask32()
    {
        // Напишите программу замена элементов
        // массива: положительные элементы замените на
        // соответствующие отрицательные, и наоборот.

        int[] MyArr = new int[12];
        for (int i=0; i< MyArr.Length; i++)
        {
            MyArr[i] = new Random().Next(-9,10);
            Console.Write($" {MyArr[i]} ");
            MyArr[i] = -MyArr[i];
        } 
        Console.WriteLine(String.Join(" ", MyArr));


    //    int [] MyArr = new int[12];
    //     // Задаем массив
    //    for (int i = 0; i< MyArr.Length; i++)
    //    {
    //         MyArr[i]= new Random().Next(-9,10);

    //    }
    //    Console.WriteLine(String.Join(", ", MyArr ));
        
    //     // Меняем элементы
    //     for (int i=0; i < MyArr.Length; i++ )
    //     {
    //         MyArr[i] = -MyArr[i];
    //     }
    //     Console.WriteLine(String.Join(", ", MyArr ));
    }

    public static  bool MyTask33( )
    {
        // Задайте массив. Напишите программу, которая
        // определяет, присутствует ли заданное число в массиве.

        int[] MyArr = new int[12];
        bool numInArr=false;
        for (int i=0; i< MyArr.Length; i++)
        {
            MyArr[i] = new Random().Next(-9,10);
        }
        Console.WriteLine(String.Join(" ", MyArr));

        Console.WriteLine("Введите число для поиска ");
        int num = Convert.ToInt32(Console.ReadLine());
             for (int i=0; i< MyArr.Length; i++)
        {
            if (MyArr[i] == num)  numInArr = true;
        }
   
        return numInArr;
    }
     public static int MyTask35()
     {
        // Задайте одномерный массив из 123 случайных чисел.
        // Найдите количество элементов массива, значения которых лежат в
        // отрезке [10,99]. 
        int[] MyArr = new int[123];
        int count=0;
        for (int i=0; i< MyArr.Length; i++)
        {
            MyArr[i] = new Random().Next(-900,1000);
            if  ((MyArr[i] >= 10) && (MyArr[i] <= 99))   count++;
        }
        
        Console.WriteLine(String.Join(" ", MyArr));
        System.Console.WriteLine(count);
        
        return count;
     }

       public static void MyTask37()
     {
        // Найдите произведение пар чисел в одномерном массиве.
        // Парой считаем первый и последний элемент, второй и предпоследний
        // и т.д. Результат запишите в новом массиве
        int[] MyArr = {2,4,5,3,6,8};
      
        // for (int i=0; i< MyArr.Length; i++)
        // {
        //     MyArr[i] = new Random().Next(-9,10);
        // }
        
        //int[] NewArr = new int[MyArr.Length/2];
       
        Console.WriteLine(String.Join(" ", MyArr));
        
        int [] NewArr ;
        int n = MyArr.Length;
        
        for (int i=0; i < MyArr.Length/2; i++)
        {
            NewArr[i] = MyArr[i]*MyArr[MyArr.Length-1-i]; 
        } 
        Console.WriteLine(String.Join(" ", NewArr));

     }
    static void Main()
    {
       // MyTask32();

        // bool nInA=MyTask33();
        // Console.WriteLine( nInA ? "Да" : "Нет");

       // int count=MyTask35();

    }

 
}
