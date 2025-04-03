using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TresEnRaya
{
    abstract class Jugador
    {
        public char Symbol { get; }

        protected Jugador(char symbol)
        {
            Symbol = symbol;
        }

        public abstract void Mover(Tablero tablero);
    }
}
