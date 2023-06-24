// Задача №17. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
// 2 Вариант решения МАССИВОМ СТРОК
System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
// строка с индексом (      0      ) (       1       ) (       2       ) (       3        )
string[] array = { "X > 0 && Y > 0", "X < 0 && Y > 0", "X < 0 && Y < 0", "X > 0 && Y < 0" };

if (number > 0 && number < 5)
{
    System.Console.WriteLine(array[number - 1]);
}
else
{
    System.Console.WriteLine("Такой четверти не существует");
}