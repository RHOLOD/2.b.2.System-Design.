//Ключевым моментом использования DLR в C# является применение типов dynamic.
//Это ключевое слово позволяет опустить проверку типов во время компиляции.
//Кроме того, объекты, объявленные как dynamic, могут в течение работы программы менять свой тип. 

class Person
{
    public string Name { get; }
    public dynamic Age { get; set; }
    public Person(string name, dynamic age)
    {
        Name = name; Age = age;
    }

    // выводим зарплату в зависимости от переданного формата
    public dynamic GetSalary(dynamic value, string format)
    {
        if (format.GetType() == typeof(string)) return $"{value} euro";
        else if (format.GetType() == typeof(int)) return value;
        else return 0.0;
    }

    public override string ToString() => $"Name: {Name}  Age: {Age}";
}

//Динамический объект связывается во время выполнения и основывается он на типе,
//который приобретает во время выполнения, а не на том, который ему задан при компиляции. 
//Когда компилятор встречает динамически связанное выражение (любое выражение,
//содержащее значение с типом dynamic), он просто упаковывает выражение таким образом,
//чтобы связывание можно было осуществить позже, во время выполнения.