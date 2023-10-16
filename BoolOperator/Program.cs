using BoolOperator;

var lightStatus = LightStatus.Create(1);

if (lightStatus)
{
    Console.WriteLine("Move!");
}
else
{
    Console.WriteLine("Stop!");
}
Console.ReadKey();