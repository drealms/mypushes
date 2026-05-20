// №31 --> 1 variant

using System.Runtime.CompilerServices;

class Animal
{
    public string? name { get; set; }
    public int? age { get; set; }

    public Animal()
    {
        
    }

    public Animal(string? Name, int? Age)
    {
        name = Name;
        age = Age;
    }

    public void Show()
    {
        WriteLine("Animal: name={0}, age={1}", name, age);
    }

    public void Voice()
    {
        WriteLine("Moo!");
    }
}

class Dog : Animal
{
    protected string? nickname;

    public Dog()
    {
        
    }

    public Dog(string Name, int Age, string Nickname) : base(Name, Age)
    {
        nickname = Nickname;
    }

    public new void Show()
    {
        WriteLine("Dog: name={0}, age={1}, nickname={2}", name, age, nickname);
    }

    public new void Voice()
    {
        WriteLine("Woof!");
    }
}

class Cat : Animal
{
    protected string? color;

    public Cat()
    {
        
    }

    public Cat(string Name, int Age, string Color) : base(Name, Age)
    {
        color = Color;
    }

    public new void Show()
    {
        WriteLine("Cat: name={0}, age={1}, color={2}", name, age, color);
    }

    public new void Voice()
    {
        WriteLine("Meow-meow!");
    }
}