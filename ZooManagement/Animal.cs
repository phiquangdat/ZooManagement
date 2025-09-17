using System;
namespace ZooManagement
{
    abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Animal(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
    public abstract void MakeSound();

}

}
