using System;
//Inheritance is created using the colon (:) symbol.
class Vehicle
{
    public void Start()
    {
        Console.WriteLine("Vehicle started");
    }
}
class Car : Vehicle
{
    public void Drive()
    {
        Console.WriteLine("Car is driving");
    }
}
class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
    }
}

class Students : Person
{
    public int RollNo;

    public Students(string name, int roll) : base(name)
    {
        RollNo = roll;
    }
}
// Multilevel Inheritance
// A class is derived from another derived class.
class LivingBeing
{
    public void Breathe()
    {
        Console.WriteLine("Breathing");
    }
}

class Human : LivingBeing
{
    public void Think()
    {
        Console.WriteLine("Thinking");
    }
}

class Employese : Human
{
    public void Work()
    {
        Console.WriteLine("Working");
    }
}
interface IPrintable
{
    void Print();
}

interface IScannable
{
    void Scan();
}

class Machine : IPrintable, IScannable
{
    public void Print()
    {
        Console.WriteLine("Printing");
    }

    public void Scan()
    {
        Console.WriteLine("Scanning");
    }
}