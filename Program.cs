// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// string PalindromosDetect(string lin)
// {
//     int j = 0;
//     int k = lin.Length - 1;
//     string result = "Да";
//     for(int i = 0; i < lin.Length / 2; i++)
//     {
//         if(lin[j] != lin[k]) result = "Нет";
//         j++;
//         k--;
//     }
//     return result;
// }

// Console.Write("Введите число: ");
// string? line = Console.ReadLine();

// if(line?.Length > 1) Console.Write("Является ли число палиндромом? " + PalindromosDetect(line));
// else Console.Write("Нет числа, нет и палиндрома");

// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.