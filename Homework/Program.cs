// Задача 2. На вход программа принимает два числа и выдает большее и меньшее
Console.Clear();
// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 == number2)
// {
//     Console.WriteLine("Числа равны");
// }
// else
//     if (number1 > number2)
//     {
//         Console.WriteLine("Максимальное число:" + number1 + ", минимальное число: " + number2);
//     }
//     else
//     {
//         Console.WriteLine("Максимальное число:" + number2 + ", минимальное число: " + number1);
//     }

// // Задача 4. Программа принимает на вход три числа и выдает максимальное 

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number2 > max)
{
    max = number2;
}
    if (number3 > max)
    {
        max = number3;
    }
Console.Write("Максимальное число: " + max);
