Console.WriteLine("Введите количество чисел в ряду:");

int n = int.Parse(Console.ReadLine());

int a = 0;
int b = 1;
int i = 0;

while (i < n)
{
    Console.WriteLine(a);

    int c = a + b;
    a = b;
    b = c;

    i++;
}