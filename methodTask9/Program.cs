// 9. написать программу, которая
// 1. выводит случайное число из отрезка [10, 99] и
// 2. показать наибольшую цифру числа

// 78 -> 8
// 12 -> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 --> {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit > secondDigit)
//     Console.WriteLine($"Наибольшая цифра числа --> {firstDigit}");
// else
//     Console.WriteLine($"Наибольшая цифра числа --> {secondDigit}"); // в случае одинаковых чисел- ваводит результат "else!!!"

//Console.WriteLine($"Наибольшая цифра числа --> {Math.Max(firstDigit, secondDigit)}"); //встроенный метод с#

int MaxDigit(int num)// мы можем значения передать 
{
    int firstDigit = num / 10; //number- глобальная переменная, num- локальная переменная
    int secondDigit = num % 10;
    if (firstDigit > secondDigit)
        return firstDigit;
    return secondDigit; // else не нужен
}

int maxDigit = MaxDigit(number);
int maxDigit2 = MaxDigit(23);
int maxDigit3 = MaxDigit(78);
int maxDigit4 = MaxDigit(99);

Console.WriteLine($"Наибольшая цифра числа --> {maxDigit}");
Console.WriteLine($"Наибольшая цифра числа --> {maxDigit2}");
Console.WriteLine($"Наибольшая цифра числа --> {maxDigit3}");
Console.WriteLine($"Наибольшая цифра числа --> {maxDigit4}");


