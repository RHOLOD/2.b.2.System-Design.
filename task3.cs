//В С# легко реализуеться концепция "класс как модуль" с помощью абстактных классов.
// Класс(модуль) MarineVessel автономен и уверсален, может использоваться как самостоятельный элемен - класс Boot
// Класс(модуль) Sailboat использует родительский модуль и расширяет его дополнительными возможностями.
abstract class MarineVessel
{
    public MarineVessel()
    {

    }
    public void Drifting()
    {
        Console.WriteLine("Дрейвовать");
    }
}
abstract class Boot :MarineVessel
{

}
abstract class Sailboat : MarineVessel
{
    public void Sail()
    {
        Console.WriteLine("Плавать под парусом");
    }
}