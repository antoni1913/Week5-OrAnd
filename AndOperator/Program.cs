// 0 or below - freezing
// 0 to  5 - cold
// 5 to 10 - chilly
// 10 - 15 - cool
// 15 to 28 - warm 
// 28 above - boiling hot 

Console.WriteLine("Enter the temperature");
int currentTemp = Int32.Parse(Console.ReadLine());

if (currentTemp <= 0)
{
    Console.WriteLine("Freezing");
}
else if (currentTemp >= 0 && currentTemp < 5)
{
    Console.WriteLine("Cold");
}
else if (currentTemp >= 5 && currentTemp < 10)
{
    Console.WriteLine("chilly");
}
else if (currentTemp >= 10 && currentTemp < 15)
{
    Console.WriteLine("Cool");
}
else if (currentTemp >= 15 && currentTemp < 28)
{
    Console.WriteLine("Warm");
}
else
{
    Console.WriteLine("HOT");
}