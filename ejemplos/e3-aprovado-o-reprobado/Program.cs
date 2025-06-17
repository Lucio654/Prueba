

/*Console.WriteLine("Ingrese su nota:");
string entradaPorteclado=Console.ReadLine ();
double nota = double.Parse(entradaPorteclado);


if (nota >= 51 && nota <= 100)
{
    Console.WriteLine("Usted está aprobado con nota de " + nota);
}
else if (nota >= 0 && nota < 51)
{
    Console.WriteLine("Usted está reprobado.");
}
else
{
    Console.WriteLine("Nota fuera de rango. Debe estar entre 0 y 100.");
}*/

using System;

class Program
{
    // Definimos el tablero con los números de posición
    static char[,] tablero = {
        { '1', '2', '3' },
        { '4', '5', '6' },
        { '7', '8', '9' }
    };
    
    // Variable para rastrear el jugador actual (X o O)
    static char jugadorActual = 'X';

    static void Main()
    {
        // Variables para controlar el estado del juego
        int turnos = 0; // Cuenta los turnos jugados
        bool juegoActivo = true; // Indica si el juego sigue activo

        // Bucle principal del juego (máximo 9 turnos)
        while (juegoActivo && turnos < 9)
        {
            Console.Clear(); // Limpia la pantalla para actualizar el tablero
            MostrarTablero(); // Muestra el tablero actualizado
            
            // Solicita al jugador elegir una posición
            Console.Write($"Jugador {jugadorActual}, elige una posición (1-9): ");
            string input = Console.ReadLine(); // Captura la entrada del jugador

            // Validamos que la entrada sea un número válido
            if (int.TryParse(input, out int posicion) && posicion >= 1 && posicion <= 9)
            {
                // Intentamos actualizar el tablero con la elección del jugador
                if (ActualizarTablero(posicion))
                {
                    turnos++; // Incrementamos el número de turnos
                    
                    // Verificamos si hay un ganador
                    if (ComprobarGanador())
                    {
                        Console.Clear();
                        MostrarTablero(); // Mostramos el tablero final
                        Console.WriteLine($"¡Jugador {jugadorActual} ha ganado!"); // Anunciamos el ganador
                        juegoActivo = false; // Terminamos el juego
                    }
                    else
                    {
                        // Cambiamos al otro jugador para el siguiente turno
                        jugadorActual = (jugadorActual == 'X') ? 'O' : 'X';
                    }
                }
                else
                {
                    // Mensaje de error si la posición ya está ocupada
                    Console.WriteLine("Posición ocupada. Presiona Enter para intentar de nuevo.");
                    Console.ReadLine();
                }
            }
            else
            {
                // Mensaje de error si la entrada no es válida
                Console.WriteLine("Entrada no válida. Presiona Enter para intentar de nuevo.");
                Console.ReadLine();
            }
        }

        // Si se alcanzan 9 turnos y nadie ha ganado, declaramos empate
        if (turnos == 9 && juegoActivo)
        {
            Console.Clear();
            MostrarTablero();
            Console.WriteLine("¡Es un empate!");
        }
    }

    // Método para mostrar el tablero actualizado en la consola
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

    // Método para actualizar el tablero con la elección del jugador
    static bool ActualizarTablero(int posicion)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                // Verificamos si la celda contiene el número de posición y lo reemplazamos con X o O
                if (tablero[i, j] == posicion.ToString()[0])
                {
                    tablero[i, j] = jugadorActual;
                    return true; // Confirmamos que la jugada fue válida
                }
            }
        }
        return false; // Devolvemos falso si la posición ya estaba ocupada
    }

    // Método para comprobar si hay un ganador
    static bool ComprobarGanador()
    {
        // Revisamos filas y columnas
        for (int i = 0; i < 3; i++)
        {
            if (tablero[i, 0] == jugadorActual && tablero[i, 1] == jugadorActual && tablero[i, 2] == jugadorActual) return true;
            if (tablero[0, i] == jugadorActual && tablero[1, i] == jugadorActual && tablero[2, i] == jugadorActual) return true;
        }

        // Revisamos las diagonales
        if (tablero[0, 0] == jugadorActual && tablero[1, 1] == jugadorActual && tablero[2, 2] == jugadorActual) return true;
        if (tablero[0, 2] == jugadorActual && tablero[1, 1] == jugadorActual && tablero[2, 0] == jugadorActual) return true;

        return false; // Si no hay ganador, devolvemos falso
    }
}
