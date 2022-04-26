// Напишите программу, которая на вход
// принимает два числа и выдаёт, 
// какое число больше, а какое меньше.

Console.Write("Введите число a ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите число b ");
int num2 = int.Parse(Console.ReadLine());
if(num1 > num2) Console.Write("max ="+ num1);
    else Console.Write("max ="+ num2);
