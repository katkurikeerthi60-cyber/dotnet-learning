static void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

static (int sum, int difference) Calculate(int a, int b)
{
    return (a + b, a - b);
}

int x = 10;
int y = 20;

Console.WriteLine($"Before swap: x = {x}, y = {y}");

Swap(ref x, ref y);

Console.WriteLine($"After swap: x = {x}, y = {y}");

var (sum, difference) = Calculate(30, 10);

Console.WriteLine($"Sum = {sum}");
Console.WriteLine($"Difference = {difference}");