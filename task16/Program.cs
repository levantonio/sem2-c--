// 16. написать программу, которая
// 1. принимает на вход два числа
// 2. является ли одно число квадратом второго
// 5, 25 --> да
// -4, 16 --> да
// 25, 5 --> да
// 8, 9 --> нет

Console.WriteLine("Введите 2 числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

bool IsSquare(int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}

 
bool res = IsSquare(number1, number2);
Console.WriteLine(res ? "да" : "нет");