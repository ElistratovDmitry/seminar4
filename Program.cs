// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Решить задачу с использованием методов.

int GetDegree (int a, int b) // метод
{
    b=Math.Abs(b);
    int degree = a;
    for (int i=1; i<b; i++)
    {
        degree = degree * a;        

    }
    return degree;
}

Console.WriteLine("Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
Console.WriteLine("input INT A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input INT B");
int b = Convert.ToInt32(Console.ReadLine());
int degree =  GetDegree(a, b);

Console.WriteLine($"{a} в степени {b} = {degree}");


/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11 ; 82 -> 10; 9012 -> 12*/

int GetSumNumbers(string  numbers) // метод
{
    int sum = 0;
    for (int i=0; i < numbers.Length; i++)
    {
        int c = Convert.ToInt32(numbers[i].ToString());
        //System.Console.WriteLine($" {i} {numbers[i]}  {Convert.ToInt32(numbers[i])}  {c}  " ); // для отладки
        sum = sum +c;
    }
    return sum;
}

Console.WriteLine("Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
System.Console.WriteLine("input Integer Number");

string number = Console.ReadLine();
number = (Math.Abs(Convert.ToInt32(number))).ToString();
int sum = GetSumNumbers(number); 

System.Console.WriteLine( $"SUM from {number} = {sum}");

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Элементы массива вводятся пользователем.

string [] InputArray(string [] array) // метод ввод массива
{
    for (int i = 0 ; i < array.Length; i++)
    {
        System.Console.WriteLine( $"Input array( {i} )");
        array[i] = Console.ReadLine();
    }
    return array;
}

void WriteArray(string [] array) // метод вывод масиива
{
    System.Console.WriteLine("");
    for ( int i=0 ; i < array.Length; i++)
    {
    Console.WriteLine($"array ( {i} ) = {array[i]}");
    }
}

Console.WriteLine("Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Элементы массива вводятся пользователем.");
string [] array8 = new string[8];
string [] newarray8 = InputArray(array8);
WriteArray(newarray8);





