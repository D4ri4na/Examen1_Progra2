using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TresEnRaya
{
    class Tablero
    {
        private char[,] tablero;

        public Tablero()
        {
            tablero = new char[,]
            {
            { ' ', ' ', ' ' },
            { ' ', ' ', ' ' },
            { ' ', ' ', ' ' }
            };
        }

        public void Mostrar()
        {
            Console.WriteLine("  0 1 2");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(tablero[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("=================================");
        }

        public bool Mover(int fila, int col, char symbol)
        {
            if (fila >= 0 && fila < 3 && col >= 0 && col < 3 && tablero[fila, col] == ' ')
            {
                tablero[fila, col] = symbol;
                return true;
            }
            return false;
        }

        public bool Ganar()
        {
            for (int i = 0; i < 3; i++)
            {
                if ((tablero[i, 0] == tablero[i, 1] && tablero[i, 1] == tablero[i, 2] && tablero[i, 0] != ' ') ||
                    (tablero[0, i] == tablero[1, i] && tablero[1, i] == tablero[2, i] && tablero[0, i] != ' '))
                {
                    return true;
                }
            }

            if ((tablero[0, 0] == tablero[1, 1] && tablero[1, 1] == tablero[2, 2] && tablero[0, 0] != ' ') ||
                (tablero[0, 2] == tablero[1, 1] && tablero[1, 1] == tablero[2, 0] && tablero[0, 2] != ' '))
            {
                return true;
            }

            return false;
        }
    }

}
