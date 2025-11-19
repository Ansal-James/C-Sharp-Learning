using System;

class Animal
{
    public string name;
    public int age;

    
    public Animal(string name, int age)
    {
        this.name = name;  
        this.age = age;
    }

    public void speak()
    {
        Console.WriteLine($"Animal : {name}");
        Console.WriteLine($"Age : {age}");
    }
}

class Dog : Animal
{
    public string breed;
    public Dog(string name, int age, string breed) : base (name, age) {
        this.breed = breed;
    }
    public void bark()
    {
        Console.WriteLine("bow Bow ");
    }
}

class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) { }
    public void Meow()
    {
        Console.WriteLine("Mewo Mewo");
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        Dog d = new Dog("doggy", 3, "Huskey");
        Cat c = new Cat("billy", 2);

        d.speak();
        c.speak();
    }
}