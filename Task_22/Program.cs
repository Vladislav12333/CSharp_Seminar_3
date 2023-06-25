// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
// 3 Вариант решения задачи

System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[number];
for (int i = 0; i < number; i++)
{
    array[i] = (int)Math.Pow(i + 1, 2);
}

System.Console.WriteLine("[" + string.Join(", ", array) + "]");