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

double DistanceBDots(int[] A, int[] B)
{
    int x = (B[0] - A[0]);
    int y = (B[1] - A[1]);
    int z = (B[2] - A[2]);
    return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)+ Math.Pow(z, 2));
}

int[] dotA = new int[3];
int[] dotB = new int[3];

Console.WriteLine("Поочередно введите координаты для точки A, нажимая Enter после каждой ");
for(int i = 0; i < 3; i++)
{
    dotA[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Поочередно введите координаты для точки B, нажимая Enter после каждой ");
for(int i = 0; i < 3; i++)
{
    dotB[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Рещение " + Convert.ToString(Math.Round(DistanceBDots(dotA, dotB), 2)));
