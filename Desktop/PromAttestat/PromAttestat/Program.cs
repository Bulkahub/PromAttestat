// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//  Использовать рекурсию, не использовать циклы.

int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
void ValueOfDigits(int M, int N)
{
    if (M != N)//Неравенство
    {
        if (M == N)//Равны 
        {
            ValueOfDigits(M - 1, N);// От большого к меньшему
            System.Console.Write(M + " ");
        }
        else
        {
            ValueOfDigits(M + 1, N);//иначе 
            System.Console.Write(M + " ");
        }
    }
    else
    {
        System.Console.Write(M + " ");
    }

}
ValueOfDigits(M, N);





// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.

int m = 2;
int n = 6;
int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }

    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}
int result = Ackermann(m, n);
Console.WriteLine($"A({m}, {n}) = {result}");





// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


static void PrintReverseArray(int[] numbers, int index)
{
    if (index >= 0)
    {

        Console.WriteLine(numbers[index]);
        PrintReverseArray(numbers, index - 1);

    }
}
static void Main()
{
    int[] number = { 1, 2, 3, 4, 5, 6, 7 };
    PrintReverseArray(number, number.Length - 1);
}
Main();
