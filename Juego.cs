using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TresEnRaya
{
    class Juego
    {
        private Tablero tablero;
        private Jugador jugador1;
        private Jugador jugador2;
        private Jugador jugadorActual;
        private Random rand;

            public Juego(Jugador jugador1, Jugador jugador2)
            {
                tablero = new Tablero();
                this.jugador1 = jugador1;
                this.jugador2 = jugador2;
                rand = new Random();
                jugadorActual = rand.Next(2) == 0 ? jugador1 : jugador2;
                
            }

            public void Start()
            {
                int turno = 0;
                bool ganar = false;

                while (turno < 9 && !ganar)
                {

                    tablero.Mostrar();
                jugadorActual.Mover(tablero);
                    ganar = tablero.Ganar();
                    jugadorActual = (jugadorActual == jugador1) ? jugador2 : jugador1;
                    turno++;
                }

                tablero.Mostrar();

                if (ganar)
                {
                    Console.WriteLine("¡El jugador " + (jugadorActual == jugador2 ? jugador1.Symbol : jugador2.Symbol) + " ha ganado!");
                }
                else
                {
                    Console.WriteLine("Es un empate.");
                }
            Console.WriteLine("Game Over ");
            }
        }

    }

