//функция получения числа с консоли
int GetNumber(string message)
{
int result = 0;
bool isCorrect = false;


while(!isCorrect)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out result) && result != 0)
{
isCorrect = true;
}
else
{
Console.WriteLine("Ввели не число или 0. Введите корректное число");
}
}

return result;
}

int n = GetNumber("Ведите N:");

for (int i = 1; i < n; i++)
{
    int sum = i * i * i;
    Console.Write($"{sum},");
}

int result = n * n * n;

Console.Write($"{result}.");