using System;

Console.Write("Enter the animal's hunger level (1-10): ");
int hungerLevel = int.Parse(Console.ReadLine());

// Inside the Main method
if (hungerLevel >= 8)
{
    Console.WriteLine("Lion: Roar! I need a big meal!");
}
else if (hungerLevel >= 5)
{
    Console.WriteLine("Monkey: Ooh ooh! I'll take some bananas.");
}
else
{
    Console.WriteLine("Tortoise: Slow and steady—I'll have some lettuce.");
}

// After the if-else block
string recommendation = (hungerLevel >= 5) ? "Listen to the Lion: Roar!" : "Listen to the Monkey: Ooh ooh!";
Console.WriteLine($"{recommendation}");

Console.Write("Enter a day of the week (1-7): ");
int dayOfWeek = int.Parse(Console.ReadLine());

// After the ternary operator
switch (dayOfWeek)
{
    case 1:
        Console.WriteLine("Sunday");
        break;
    case 2:
        Console.WriteLine("Monday");
        break;
    case 3:
        Console.WriteLine("Tuesday");
        break;
    case 4:
        Console.WriteLine("Wednesday");
        break;
    case 5:
        Console.WriteLine("Thursday");
        break;
    case 6:
        Console.WriteLine("Friday");
        break;
    case 7:
        Console.WriteLine("Saturday");
        break;
    default:
        Console.WriteLine("You didn't pick a day.");
        break;
}
