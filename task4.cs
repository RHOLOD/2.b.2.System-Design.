
//Один из способов реализации принципа открытости/закрытости через паттерн Стратегия.
//Класс Seller закрыт от изменений, зато мы можем легко расширить его функциональность, определив дополнительные реализации интерфейса IProduct.
abstract class Seller
{
    public string Name { get; set; }

    public Seller(string name)
    {
        this.Name = name;
    }

    public void SellGoods (IProduct product)
    {
        product.Sell();
    }
}
interface IProduct
{
    void Sell();
}
class CarSales: IProduct
{
    public void Sell()
    {
        Console.WriteLine("Продать машину");
    }
}
class ClothingSales: IProduct
{
    public void Sell()
    {
        Console.WriteLine("Продать одежду");
    }
}

//Другим способом применения принципа открытости/закрытости представляет паттерн Шаблонный метод.
abstract class Seller
{
    public string Name { get; set; }

    public Seller(string name)
    {
        this.Name = name;
    }

    public void SellGoods(SellProduct[] product)
    {
        foreach (var i in product)
            i.Sell();
    }
}
abstract class SellProduct
{
    public void Sell()
    {
        Advertise();
        ConclusionSale();
    }
    protected abstract void Advertise();
    protected abstract void ConclusionSale();
}

class CarSalesman : Seller
{
    protected override void Advertise()
    {
        Console.WriteLine("Рекламируем машины");
    }
    protected override void ConclusionSale()
    {
        Console.WriteLine("Оформаляем продажу машины");
    }
}

class ClothingSalesman : Seller
{
    protected override void Advertise()
    {
        Console.WriteLine("Рекламируем одужду");
    }
    protected override void ConclusionSale()
    {
        Console.WriteLine("Оформаляем продажу одежды");
    }
}