using System;

public class Program {
    public static void Main() {
        Animal Koalsky = new Penguin();
        Animal Bald = new Eagle();
        Console.WriteLine(Koalsky);
        Console.WriteLine(Bald);
        ((Eagle)Bald).Fly();
    }
}

public abstract class Animal {
    public void Eat() {
        Console.WriteLine("Hungry");
    }
}

public interface IMoveable {
    void Move();
}

public interface IFlyable {
    void Fly();
}

public interface ICanEatMeat {
    bool EatMeat { get; set; }
}

public interface ICanEatVegies {
    bool EatVegies { get; set; }
}

public interface ISwimmable {
    void Swim();
}

public interface IRunnable {
    void Run();
}

public class Penguin : Animal, IMoveable, ICanEatMeat, ISwimmable {
    public void Move() {
        Console.WriteLine("I am movement able");
    }

    public bool EatMeat { get; set; } = true;

    public void Swim() {
        Console.WriteLine("I am swimming");
    }
}

public class Eagle : Animal, IMoveable, ICanEatMeat, IFlyable {
    public void Move() {
        Console.WriteLine("I am movement able");
    }

    public bool EatMeat { get; set; } = true;

    public void Fly() {
        Console.WriteLine("I believe I can fly");
    }
}
