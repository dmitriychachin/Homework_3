//функция получения числа с консоли
int GetNumber(string message)
{
int result = 0;
bool isCorrect = false;


while(!isCorrect)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out result) && result > 9999 && result < 100000)
{
isCorrect = true;
}
else
{
Console.WriteLine("Ввели не пятизначное число. Введите корректное число");
}
}

return result;
}

int num = GetNumber("Введите пятизначное число");
int num1 = num / 10;
int num2 = (num / 1000) % 10;

if (num / 10000 == num % 10 && num1 % 10 == num2){
    Console.WriteLine("Yes");
} else 
    Console.WriteLine("No");

