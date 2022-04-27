// Напишите программу, которая на вход 
// принимает число и выдает, является ли 
// число чётным (делиться ли оно без остатка).

Console.Write("Введите число a ");
int num = int.Parse(Console.ReadLine());
bool result = num % 2 == 0;
Console.WriteLine(result ? "Да" : "Нет");
