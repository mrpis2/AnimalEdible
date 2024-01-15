class Program
{
    private static void Main(string[] args)
    {
        Animal[] animals = new Animal[2];
        animals[0] = new Tiger();
        animals[1] = new Chicken();
        foreach (Animal animal in animals) 
        {
            Console.WriteLine(animal.MakeSound());
            if (animal is Chicken)
            {
                IEdible iedibler = (IEdible)animal;
                Console.WriteLine(iedibler.HowToEat());
            }
        }
        Fruit[] fruits = new Fruit[2];
        fruits[0] = new Apple();
        fruits[1] = new Orange();
        foreach (Fruit fruit in fruits)
        {
            Console.WriteLine(fruit.HowToEat());
        }

    }
}

public abstract class Animal
{
    public abstract string MakeSound();
}

public class Tiger: Animal
{
    public override string MakeSound()
    {
        return "Tiger: roar";
    }
}

public class Chicken : Animal, IEdible
{
    public override string MakeSound()
    {
        return "Chicken: Cluck-cluck";
    }
    public string HowToEat()
    {
        return "could be fried";
    }
}

public interface IEdible
{
    public string HowToEat();
}

public abstract class Fruit : IEdible
{
    public abstract string HowToEat();
}

public class Apple : Fruit
{
    public override string HowToEat()
    {
        return "Apple could be slided";
    }
}

public class Orange : Fruit
{
    public override string HowToEat()
    {
        return "Orange could be juiced";
    }
}