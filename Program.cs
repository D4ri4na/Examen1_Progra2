using System;
using TresEnRaya;

class Program
{
    static void Main()
    {
        Console.WriteLine("Game Start !!!");
        Juego juego = new Juego(new Persona('X'), new Computadora('O'));
        juego.Start();
    }
}

