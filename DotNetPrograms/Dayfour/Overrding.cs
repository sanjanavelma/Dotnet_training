using System;

// Method Overriding
class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes sound");
    }
}

class Dog : Animal
{
    public override void Sound()
    {
        base.Sound();
        Console.WriteLine("Dog barks");
    }
}

// Sealed Method Example
class Parent
{
    public virtual void Show()
    {

    }
}

class Child : Parent
{
    public sealed override void Show()
    {

    }
}

// Composition
class Engine
{
    public void Start()
    {
        Console.WriteLine("Engine started");
    }
}

class CarExp
{
    Engine engine = new Engine();
    public void Driver()
    {
        engine.Start();
        Console.WriteLine("Car is driving");
    }
}

// Method Hiding
class Parent2
{
    public void Show()
    {
        Console.WriteLine("Parent Show");
    }
}

class Child2 : Parent2
{
    public new void Show()
    {
        Console.WriteLine("Child Show");
    }
}

// Static Method Hiding
class A
{
    public static void Display()
    {
        Console.WriteLine("A Display");
    }
}

class B : A
{
    public new static void Display()
    {
        Console.WriteLine("B Display");
    }
}
