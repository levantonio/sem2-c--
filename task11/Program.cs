// 11. Написать программу
// 1. которая выводит случайное число
// 2. и удаляет вторую цифру этого числа

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
// int number1 = (number / 100) % 10;
// int number2 = number % 10;
// Console.Write($"{number1}{number2}");

int ConcaTenet(int num) // мы можем значения передать
{
    int number1 = (num / 100) % 10; //number- глобальная переменная, num- локальная переменная
    int number2 = num % 10;
    int result = Convert.ToInt32($"{number1}{number2}");// я не знаю другого метода преобразовать значение
    return result;
}

int res = ConcaTenet(number);
Console.WriteLine(res);
