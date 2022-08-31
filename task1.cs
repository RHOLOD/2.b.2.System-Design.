namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer("Алексей", "Бобров", 30, "563565286576", "32234", "11697338589", 23, "CSharp");
            Employee employee = new Employee("Николай", "Попов", 45, "563565286576", "32234", "11697338589");
            Person person = new Person("Павел", "Чапарян", 35);
            Person[] array = new Person[] { developer, employee, person };
            void massGreeting(Person[] array)
            {
                foreach (Person person in array)
                {
                    person.Greeting();
                }
            }

            //Пример полиморфизма
            massGreeting(array);
            developer.Greeting(5);
            developer.Greeting("javascript");
        }
        
    }
    class Person
    {
        protected string firstName;
        private string lastName;
        private int age;
        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }
        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }
        public int Age
        {
            get => age;
            set
            {
                if (value > 0) age = value;
                else age = 0;
            }
        }
        public virtual void Greeting()
        {
            Console.WriteLine($"Привет, я человек и меня зовут: {firstName}$");
        }
        public string FullName()
        {
            return $"Фамилия: {lastName}  Имя: {firstName}$";
        }
    }
    // Класс Employee наследует класс Person
    class Employee : Person
    {
        private string inn;
        private string number;
        private string shils;

        public Employee(string firstName, string lastName, int age, string inn, string number, string shils)
            : base(firstName, lastName, age)
        {
            this.inn = inn;
            this.number = number;
            this.shils = shils;
        }
        //Переопеделние метода Greeting
        public override void Greeting()
        {
            Console.WriteLine($"Привет, я работник и меня зовут: {firstName}$");
        }
    }
    // Класс Developer наследует класс Employee
    class Developer : Employee
    {
        private int level;
        private string language;

        // Пример Композиции
        Computer computer;

        public Developer(string firstName, string lastName, int age, string inn, string number, string shils, int level, string language)
            : base(firstName, lastName, age, inn, number, shils)
        {
            this.level = level;
            this.language = language;
            computer = new Computer(58000, "intel i5-11320h", "24Гб", "500ГБ", "15.6 дюймов", "ноубук");
        }
        //Переопеделние метода Greeting
        public override void Greeting()
        {
            Console.WriteLine($"Привет, я разработчик и меня зовут: {firstName}$");
        }
        public void Greeting(int year)
        {
            Console.WriteLine($"Привет, я разработчик уже {year} лет$");
        }
        public void Greeting(string language)
        {
            Console.WriteLine($"Привет, я разработчик на {language}$");
        }
    }
    class Computer
    {
        private int price { get; set; }
        private string processor { get; set; }
        private string ram { get; set; }
        private string hardDisk { get; set; }
        private string monitorSize { get; set; }
        private string type { get; set; }

        public Computer (int price, string processor, string ram, string hardDisk, string monitorSize, string type)
        {
            this.price = price;
            this.processor = processor;
            this.ram = ram;
            this.hardDisk = hardDisk;
            this.monitorSize = monitorSize;
            this.type = type;
        }
    }
}
