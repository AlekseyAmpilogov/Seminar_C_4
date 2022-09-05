Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int tmp = a;
int tmp2 = b;
while (b > 1)
{
    b = b - 1;
    a = a * tmp;
}
Console.WriteLine(tmp + " в степени " + tmp2 + " = " + a);