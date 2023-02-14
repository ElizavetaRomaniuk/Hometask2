// See https://aka.ms/new-console-template for more information
Console.WriteLine("Input the number");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 99 && a < 1000)
{
    int result = (a % 100) / 10;
    Console.WriteLine(result);
}
    else 
        Console.WriteLine("It is not a three-digit number");