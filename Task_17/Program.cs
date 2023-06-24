// Задача №17. Напишите программу, которая на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдает номер четверти плоскости, в которой находится эта точка.
// помним что int number -может хранить только одно значение

int[] coordinates = new int [2]; 
// вся эта конструкция говорит о том что мы будем выделять 2 ячейки памяти в нашем массиве
// new -выделяет память под какието значения, выделяет память в нашей программе
// int - указывает что мы выделяем целое число
// [2] - указывает что мы выделяем два целых числа

System.Console.Write("Введите координаду X: ");
coordinates[0] = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координаду Y: ");
coordinates[1] = Convert.ToInt32(Console.ReadLine());

if (coordinates[0] > 0 && coordinates[1] > 0)
{
    System.Console.WriteLine("Точка находиться в 1-й четверти");
}
else if (coordinates[0] < 0 && coordinates[1] > 0)
{
    System.Console.WriteLine("Точка находиться в 2-й четверти");
}
else if (coordinates[0] < 0 && coordinates[1] < 0)
{
    System.Console.WriteLine("Точка находиться в 3-й четверти");
}
else if (coordinates[0] > 0 && coordinates[1] < 0)
{
    System.Console.WriteLine("Точка находиться в 4-й четверти");
}
else
{
    System.Console.WriteLine("Введены неправильные координаты");
}