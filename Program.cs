/* Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
 */

Console.WriteLine ("Введите M числа:");
string array = Console.ReadLine();
string [] array2 = new string [array.Length];
int a = 0;
for (int i = 0; i < array.Length; i++)
{
  if (array[i] == ',')
  {
    a++;
  }
  else
  {
    array2[a] = array2[a]+$"{array[i]}";
  }
}
a++;
int [] result = new int[a];
PrintArray (result, array2);
int sum = 0;
for (int i = 0; i < a; i++)
{
  if (result[i]>0)
  {
    sum++;
  }
}
Console.WriteLine ("Количество чисел больше 0: "+sum);

void PrintArray (int [] array, string [] num)
{
  for (int i = 0; i < array.Length; i++)
  {
  array[i] = Convert.ToInt32(num[i]);
  Console.Write (array[i]+"  ");
  }
Console.WriteLine();
}



 /* Задача 43: Напишите программу, которая найдёт 
 точку пересечения двух прямых, заданных уравнениями 
 y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 
 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

/* Console.WriteLine("Введите значение b1");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k1");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double k2 = double.Parse(Console.ReadLine());
double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"Точка пересечения двух прямых X: {x}, Y: {y}"); */