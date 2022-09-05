Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int num = number;
int i = 0;
while (number > 0 && number % 10 != 0)
{
    if (num % (number % 10) == 0)
        i = i + (number % 10);
    number = number / 10;
}
Console.Write(i);