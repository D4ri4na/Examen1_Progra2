using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TresEnRaya
{

    class Computadora : Jugador
    {
        private Random rand;

        public Computadora(char symbol) : base(symbol)
        {
            rand = new Random();
        }

        public override void Mover(Tablero tablero)
        {
            Console.WriteLine("Turno de la Computadora: ");
            int fila, col;
            bool valido = false;

            do
            {
                fila = rand.Next(3);
                col = rand.Next(3);
                valido = tablero.Mover(fila, col, Symbol);
            } while (!valido);
        }
    }
}
