// 14. написать программу которая
// 1. принимает на вход число
// 2. проверяет кратно ли оно одновременно 7 и 23
// 14 --> нет
// 46 --> нет
// 161 --> да

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool MultipLicityTwoDigits (int num)
{
    return num % 7 == 0 && num % 23 == 0;  // && - and 
    
}

bool result = MultipLicityTwoDigits(number); //Выводит false/true

string resultStr = result ? "да" : "нет"; //Выводит да/нет да == true*** нет == false тернарный орератор : == иначе

Console.WriteLine($"{number} -> {resultStr}");