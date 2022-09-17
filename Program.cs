//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
int count = 0;
Console.WriteLine("Введите М чисел");
for (int i = 0; i < m; i++)
{
   int n = Convert.ToInt32(Console.ReadLine());
   if (n > 0)
   {
        count++;
   }
}
Console.WriteLine("Ответ");
Console.WriteLine(count);