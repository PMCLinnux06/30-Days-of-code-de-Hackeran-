using System;

class Persona
{
    public string Nombre;

    public void Saludar()
    {
        Console.WriteLine("Hola, soy " + Nombre);
    }

    static void Main()
    {
        Persona persona = new Persona();
        persona.Nombre = "Pedro";
        persona.Saludar();
    }
}
