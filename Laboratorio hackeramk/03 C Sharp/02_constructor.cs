using System;

class Jugador
{
    string nombre;
    int nivel;

    public Jugador(string nombre, int nivel)
    {
        this.nombre = nombre;
        this.nivel = nivel;
    }

    public void Mostrar()
    {
        Console.WriteLine(nombre + " nivel " + nivel);
    }

    static void Main()
    {
        Jugador jugador = new Jugador("Pedro", 5);
        jugador.Mostrar();
    }
}
