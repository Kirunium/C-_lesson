// Напишите программу, которая выводит случайное число
// из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// int num = new Random().Next(10,100);
// // new Random().Next(-52,125); // -52 124
// Console.WriteLine(num);

// int num1= num/10;
// int num2 = num %10;

// if(num1>num2)
// {
// System.Console.WriteLine(num1);
// }
// else if(num1== num2)
// {
// System.Console.WriteLine("Цифры равны");
// }
// else
// {
// System.Console.WriteLine(num2);
// }
// Напишите программу, которая выводит случайное
// трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// int num = new Random().Next(100,1000); // 456
// Console.WriteLine(num);

// int result = num/100*10 + num%10; // 4*10+ 6 =46

// Console.WriteLine(result);
// Напишите программу, которая будет принимать
// на вход два числа и выводить, является ли
// второе число кратным первому. Если число
// 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// System.Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите число");
// int num2 = int.Parse(Console.ReadLine());

// if(num1%num2 ==0)
// {
// System.Console.WriteLine("кратно");
// }
// else
// {
// // System.Console.WriteLine("не кратно, ост." + num1%num2); // конкатенация
// System.Console.WriteLine($"не кратно, ост. {num1%num2}"); // интерполяция
// }
// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно одновременно
// 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

// System.Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num%7 ==0 && num%23==0) // && - и || - или
// {
// System.Console.WriteLine("Да");
// }
// else
// {
// System.Console.WriteLine("Нет");
// }
// Напишите программу, которая принимает на
// вход два числа и проверяет, является ли
// одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

// System.Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if(num1 == num2*num2 || num2 == num1*num1)
// {
// System.Console.WriteLine("Да");
// }
// else
// {
// System.Console.WriteLine("Нет");
// }