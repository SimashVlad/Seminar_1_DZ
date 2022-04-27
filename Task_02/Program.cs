// Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.




class Program
{
    static void Main(string[] args)
    {
        string[] i = Console.ReadLine().Split(' ');
        int a = Convert.ToInt32(i[0]);
        int b = Convert.ToInt32(i[1]);
        int c = Convert.ToInt32(i[2]);
        Console.WriteLine(Math.Max(a, Math.Max(b, c)));



    }
}