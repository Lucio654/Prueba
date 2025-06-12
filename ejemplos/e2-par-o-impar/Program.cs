
/*Console.WriteLine("Ingrese un numero");
String entradaPorteclado = Console.ReadLine();
int numero = int.Parse(entradaPorteclado);

if (numero % 2 == 0)
{
    Console.WriteLine("El numero es par");
}
else
{
    Console.WriteLine("El numero es impar");
}*/

using System;

class Program
{
    static char[,] tablero = {
        { '1', '2', '3' },
        { '4', '5', '6' },
        { '7', '8', '9' }
    };
    static char jugadorActual = 'X';

    static void Main()
    {
        int turnos = 0;
        bool juegoActivo = true;

        while (juegoActivo && turnos < 9)
        {
            Console.Clear();
            MostrarTablero();
            Console.Write($"Jugador {jugadorActual}, elige una posición (1-9): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int posicion) && posicion >= 1 && posicion <= 9)
            {
                if (ActualizarTablero(posicion))
                {
                    turnos++;
                    if (ComprobarGanador())
                    {
                        Console.Clear();
                        MostrarTablero();
                        Console.WriteLine($"¡Jugador {jugadorActual} ha ganado!");
                        juegoActivo = false;
                    }
                    else
                    {
                        jugadorActual = (jugadorActual == 'X') ? 'O' : 'X';
                    }
                }
                else
                {
                    Console.WriteLine("Posición ocupada. Presiona Enter para intentar de nuevo.");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Presiona Enter para intentar de nuevo.");
                Console.ReadLine();
            }
        }

        if (turnos == 9 && juegoActivo)
        {
            Console.Clear();
            MostrarTablero();
            Console.WriteLine("¡Es un empate!");
        }
    }

    static void MostrarTablero()
    {
        Console.WriteLine("=== Tres en Raya ===");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(tablero[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static bool ActualizarTablero(int posicion)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (tablero[i, j] == posicion.ToString()[0])
                {
                    tablero[i, j] = jugadorActual;
                    return true;
                }
            }
        }
        return false;
    }

    static bool ComprobarGanador()
    {
        for (int i = 0; i < 3; i++)
        {
            if (tablero[i, 0] == jugadorActual && tablero[i, 1] == jugadorActual && tablero[i, 2] == jugadorActual) return true;
            if (tablero[0, i] == jugadorActual && tablero[1, i] == jugadorActual && tablero[2, i] == jugadorActual) return true;
        }
        if (tablero[0, 0] == jugadorActual && tablero[1, 1] == jugadorActual && tablero[2, 2] == jugadorActual) return true;
        if (tablero[0, 2] == jugadorActual && tablero[1, 1] == jugadorActual && tablero[2, 0] == jugadorActual) return true;

        return false;
    }
}

