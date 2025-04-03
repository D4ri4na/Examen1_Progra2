using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TresEnRaya
{
    class Persona : Jugador
    {
        public Persona(char symbol) : base(symbol) { }

        public override void Mover(Tablero tablero)
        {
            int fila, col;
            bool valido = false;

            do
            {
                Console.WriteLine("Tu turno: ");
                Console.Write("Elige fila (0-2): ");
                string filaInput = Console.ReadLine();
                Console.Write("Elige columna (0-2): ");
                string colInput = Console.ReadLine();

                if (int.TryParse(filaInput, out fila) && int.TryParse(colInput, out col))
                {
                    valido = tablero.Mover(fila, col, Symbol);
                    if (!valido)
                    {
                        Console.WriteLine("Casilla ocupada o inválida. Intenta de nuevo.");
                    }
                }
            } while (!valido);
            Console.WriteLine("===================================");
        }
    }

}
