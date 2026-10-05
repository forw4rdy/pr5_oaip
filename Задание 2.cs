Console.WriteLine("Введите число i:");

int i = int.Parse(Console.ReadLine());

int number = 1;

while (number <= i)
{
    Console.WriteLine(number);
    number = number * 2;
}