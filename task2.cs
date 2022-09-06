class Grage
{
    private int roofHeight;
    private int wallLength;
    private int wallHeight;
    private int gateWidth;
    private int gateHeight;
    private int pitDepth;
    public Grage(int roofHeight, int wallLength, int wallHeight, int gateWidth, int gateHeight, int pitDepth)
    {
        this.roofHeight = roofHeight;
        this.wallLength = wallLength;
        this.wallHeight = wallHeight;
        this.gateWidth = gateWidth;
        this.gateHeight = gateHeight;
        this.pitDepth = pitDepth;
    }
    public void OpenGate()
    {
        Console.WriteLine("Ворота Открыты!");
    }
    public void CloseGate()
    {
        Console.WriteLine("Ворота Закрыты!");
    }
}

// Пример расширения класса-родителя.
// Класс Теплый гараж наследуеться от гараж 
// Он имееть дополнительные поля countBatteries, countBulbs и методы TurnOnHeating(), TurnOnLights().
class WarnGarage : Grage
{
    private int countBatteries;
    private int countBulbs;
    public WarnGarage(int roofHeight, int wallLength, int wallHeight, int gateWidth, int gateHeight, int pitDepth, int countBatteries, int countBulbs)
        : base(roofHeight, wallLength, wallHeight, gateWidth, gateHeight, pitDepth)
    {
        this.countBatteries = countBatteries;
        this.countBulbs = countBulbs;
    }
    public void TurnOnHeating()
    {
        Console.WriteLine("Отопление включено!");
    }
    public void TurnOnLights()
    {
        Console.WriteLine("Отопление выключено!");
    }
}


class Bird
{
    private int wingspan;
    private int bodySize;
    private int bodyMass;
    private int beakLength;
    private int length;
    private string plumagepri;
    public Bird(int wingspan, int bodySize, int bodyMass, int beakLength, int length, string plumagepri)
    {
        this.wingspan = wingspan;
        this.bodySize = bodySize;
        this.bodyMass = bodyMass;
        this.beakLength = beakLength;
        this.length = length;
        this.plumagepri = plumagepri;
    }
    public virtual void Moving()
    {
        Console.WriteLine("Махать крыльями и лететь!");
    }
}
// Пример специализации класса-родителя.
// Клас нелетающие птицы наследуеться от класса птиц,
// наследник не изменяет родительский класс, а только меняет поведение метода Moving.
class FlightlessBirds : Bird
{
    public FlightlessBirds(int wingspan, int bodySize, int bodyMass, int beakLength, int length, string plumagepri)
        : base(wingspan, bodySize, bodyMass, beakLength, length, plumagepri)
    {

    }
    public override void Moving()
    {
        Console.WriteLine("Бежать!");
    }
}
