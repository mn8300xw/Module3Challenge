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
        Console.WriteLine("Enjoy Half off admission for kids on Sundays!");
        break;
    case 2:
        Console.WriteLine("Special appearance on Monday");
        break;
    case 3:
        Console.WriteLine("10% senior discount on Tuesdays");
        break;
    case 4:
        Console.WriteLine("Animal of the day: Camels! Wednesday");
        break;
    case 5:
        Console.WriteLine("Free fountain drink on thirsty Thursdays");
        break;
    case 6:
        Console.WriteLine("Discount on fried foods for Friday");
        break;
    case 7:
        Console.WriteLine("Special discount on Koala exhibit on Saturday");
        break;
    default:
        Console.WriteLine("Enoy the zoo!");
        break;
}
