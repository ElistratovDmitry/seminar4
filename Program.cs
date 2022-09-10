/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Решить задачу с использованием методов.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

int GetDegree (int a, int b)
{
    b=Math.Abs(b);
    int degree = a;
    for (int i=1; i<b; i++)
    {
        degree = degree * a;        
    }
    return degree;
}

Console.WriteLine("input INT A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input INT B");
int b = Convert.ToInt32(Console.ReadLine());
int degree =  GetDegree(a, b);

Console.WriteLine($"{a} в степени {b} = {degree}");
/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/

void GetSumNumbers(string number)
{
    int sum = 0;
    System.Console.WriteLine(number);
    for (int i=0; i < number.Length; i++)
    {
        System.Console.WriteLine(number[i]);
        int c = Convert.ToInt32(number[i]);
        System.Console.WriteLine($" {i}   {c}  " );
        //sum = sum +Convert.ToInt32(number[i]);
        //System.Console.WriteLine( sum );
        
    }

}

System.Console.WriteLine(   "input Number");
string number = Console.ReadLine();
System.Console.WriteLine(number);
GetSumNumbers(number);







