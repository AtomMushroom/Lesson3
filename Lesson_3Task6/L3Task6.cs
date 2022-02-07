double product = 1.0;
double temp = 1.0;
for (int i = 0; i < 10; i++)
{
    temp = Double.Parse(Console.ReadLine());
    product *= temp;
}
Console.WriteLine("Произведение: " + product);