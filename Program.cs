//Задача 4
//Напишите программу, которая на вход принимает три числа, и выдает максимальное из этих чисел
//2; 3; 7
//44; 5; 78
//22; 3; 9
Console.WriteLine("Введите первое число");
int q1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int q2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int q3 = Convert.ToInt32(Console.ReadLine());
int[] nn = { q1, q2, q3 };
int max = nn[0];
int i = 0;
int size = 3;
while (i < size)
{
    if (nn[i] > max)
        max = nn[i];
    i++;
}
Console.WriteLine("Максимальное число = " + max);
