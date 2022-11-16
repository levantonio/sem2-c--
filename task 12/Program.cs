// 12. Написать программу, которая
// 1. принимает на вход 2 числа
// 2. если число 1 кратно числу 2 вывести "кратно"
// 3. если не кратно - показать остаток от деления
// 34, 5 -- не кратно, остаток от деления 4
// 16, 4 -- кратно

Console.WriteLine("Введите 2 числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

int MultipLi(int num1, int num2)
{
    return num1 % num2;
}

int result = MultipLi(num1, num2);
if(result == 0)
{
    Console.WriteLine("Кратно");
}
else Console.WriteLine($"Не кратно, остаток {result}");

