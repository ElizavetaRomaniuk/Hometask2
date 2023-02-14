// To see the third digit of the number
Console.WriteLine("Input the number");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 99 && a < 1000)
    Console.WriteLine(a % 10);
    else if (a > 999)
        Console.WriteLine((a / 100) % 10);
else 
    Console.WriteLine("It is not a three-digit number");