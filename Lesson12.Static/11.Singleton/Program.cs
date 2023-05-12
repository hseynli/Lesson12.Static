Console.OutputEncoding = System.Text.Encoding.UTF8;

// "protected" konstruktor olduğuna görə new Singleton() yazılışından istifadə edə bilmərik
Singleton instance1 = Singleton.Instance();
Singleton instance2 = Singleton.Instance();

if (instance1 == instance2)
    Console.WriteLine("Hər iki referance eyni obyektə yönləndirilir.");