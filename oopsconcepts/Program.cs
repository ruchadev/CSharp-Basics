using System;

// // Base class
class Animal
{
    public Animal()
    {
        System.Console.WriteLine("CLASS ANIMAL CONSTRUCTOR IS CALLED");
    }

    public void Bark()
    {
        System.Console.WriteLine("Animals are barking very loudly");
    }

    public void Eat()
    {
        System.Console.WriteLine("This animal eats food.");
    }
}

// Interface
interface I2
{
    void fly();
}

// Derived class implementing interface
class Fruits : Animal, I2
{
    public Fruits()
    {
        System.Console.WriteLine("CLASS Fruits CONSTRUCTOR IS CALLED");
    }

    public void Eat()
    {
        System.Console.WriteLine("I would like to eat different fruits");
    }

    public void fly()
    {
        System.Console.WriteLine("I can fly");
    }
}

// Another derived class
class Bird : Animal
{
    public void Fly()
    {
        System.Console.WriteLine("This bird can fly.");
    }
}

// Another derived class
class Car : Animal
{
    public void Engine()
    {
        System.Console.WriteLine("I can drive the car");
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Demonstrating inheritance with Bird
        Bird sparrow = new Bird();
        sparrow.Eat();
        sparrow.Fly();

        // Demonstrating inheritance with Car
        Car engine = new Car();
        engine.Engine();
        engine.Bark();

        // Demonstrating inheritance with Fruits
        Fruits fruit = new Fruits();
        fruit.Bark();
        fruit.Eat();
        fruit.fly();
    }
}

//Note - By using SEALED keyword you can prevent calss from being inheritred
//also you can use STatic keyword in base class

//diffrence is you can create the object of sealed class but cannot create object of static class

class youtube
{
    public virtual void Subscribe()
    {
        System.Console.WriteLine("Subscribe to youtube");
    }
}
class SocialMedia : youtube
{
    public new void Subscribe()
    {
        System.Console.WriteLine("subscribe me on other apps");
    }
}

class mainClass
{
    static void Main(string[] args)
    {
        youtube youtube = new SocialMedia();
        youtube.Subscribe();
        //Console.ReadLine();
    }
}

