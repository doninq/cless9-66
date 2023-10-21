/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int Func(int m, int n)
{ 
    int Sum = 0;
    if(m == n)return 0;
    Sum += m + Func(m+1, n);
    //Console.Write(Sum + " ");
    return Sum;
}
Console.Write(Func(2, 15));
