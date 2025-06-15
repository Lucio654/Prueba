// 10. Adivina el número (juego)
//El sistema genera un número aleatorio del 1 al 50.
//El usuario intenta adivinarlo.
//Usar do-while hasta que acierte, indicando si es mayor o menor.

using System.Timers;

Random random = new Random();
int numeroAleatorio = random.Next(1, 51);
int jugador;


do
{
    Console.Write("Ingrese un numero");

    if (int.TryParse(Console.ReadLine(), out jugador))
    {
        if (jugador == numeroAleatorio)
        {
            Console.WriteLine("usted adivino el numero");
        }
        else if (jugador < numeroAleatorio)
        {
            Console.WriteLine("El numero es Mayor, intentelo de nuevo");
        }
        else
        {
            Console.WriteLine("El numero es menor, intentelo de nuevo");
        }


    }
    else
    {
        Console.WriteLine("ingrese valores numericos");
    }
} while (jugador != numeroAleatorio);

  