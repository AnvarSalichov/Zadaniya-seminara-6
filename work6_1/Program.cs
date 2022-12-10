// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Write("Сколько чисел Вы введете?");
int M = Convert.ToInt32(Console.ReadLine());
int count = 0;
int[] array = new int[M];
for (int i = 0; i < array.Length; i++)                   //array.Length или M  
{
    Console.Write("Введите число = "); 
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0)
     {
        count=count+1;                                   //=count++
     }
}
Console.WriteLine(String.Join(", ", array));
Console.WriteLine("Введено положительных чисел "+ count);