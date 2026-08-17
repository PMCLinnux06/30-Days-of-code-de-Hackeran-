using System;

class Animal
{
    public void Comer()
    {
        Console.WriteLine("El animal come");
    }
}

class Perro : Animal
{
    public void Ladrar()
    {
        Console.WriteLine("Guau");
    }

    static void Main()
    {
        Perro perro = new Perro();
        perro.Comer();
        perro.Ladrar();
    }
}
