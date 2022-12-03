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


int x1 = GetNumber("Введите Х первой точки");
int y1 = GetNumber("Введите У первой точки");
int z1 = GetNumber("Введите Z первой точки");
int x2 = GetNumber("Введите Х второй точки");
int y2 = GetNumber("Введите У второй точки");
int z2 = GetNumber("Введите Z второй точки");

double sum1 = Math.Pow((x2 - x1),2);
double sum2 = Math.Pow((y2 - y1),2);
double sum3 = Math.Pow((z2 - z1),2);

double result = Math.Sqrt(sum1+sum2+sum3);

Console.WriteLine($"Расстояние равно {result}");