// To see if the day is a weekend
Console.WriteLine("Input the number");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 6 || a == 7)
    Console.WriteLine("Yeah, today is the weekend");
    else if (a > 0 && a < 8)
        Console.WriteLine("Sorry, today is not the weekend");
    else 
    Console.WriteLine("It is not a weekday");
