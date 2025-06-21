//Pregunta 1: ¿Qué causa el calentamiento global?
//a) Lluvia ácida b) Gases de efecto invernadero c) Rayos cósmicos 
//Tu respuesta: b Correcto 
// ✔ Pregunta 2: ¿Qué animal está en peligro de extinción? a) Gallina b) Oso polar c) Gato Tu respuesta: b Correcto ✔ ...


/*(using System;

class Programa
{
    static void Main()
    {
        string[] preguntas = {
            "¿Qué causa el calentamiento global?",
            "¿Qué animal está en peligro de extinción?"
        };

        string[,] opciones = {
            { "a) Lluvia ácida", "b) Gases de efecto invernadero", "c) Rayos cósmicos" },
            { "a) Gallina", "b) Oso polar", "c) Gato" }
        };

        string[] ResCorrectas = { "b", "b" };

        for (int i = 0; i < preguntas.Length; i++)
        {
            Console.WriteLine($"Pregunta {i + 1}: {preguntas[i]}");

            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine(opciones[i, j]);
            }

            Console.Write("Tu respuesta: ");
            string? respuesta = Console.ReadLine().ToLower();

            if (respuesta == ResCorrectas[i])
            {
                Console.WriteLine("La respuesta que elejiste es Correcta");
            }
            else
            {
                Console.WriteLine($"Incorrecto. La respuesta correcta era: {ResCorrectas[i]}");
            }
        }
    }
}*/


/*using System;

class Programa
{
    static void Main()
    {
        string[] preguntas = {
            "¿Qué causa el calentamiento global?",
            "¿Qué animal está en peligro de extinción?"
        };
        
        string[] opciones = {
            "a) Lluvia ácida  b) Gases de efecto invernadero  c) Rayos cósmicos",
            "a) Gallina  b) Oso polar  c) Gato"
        };

        string[] ResCorrectas = { "b", "b" };

        for (int i = 0; i < preguntas.Length; i++)
        {
            Console.WriteLine($"Pregunta {i + 1}: {preguntas[i]}");
            Console.WriteLine(opciones[i]);

            Console.Write("Elige Tu respuesta: ");
            string? respuesta = Console.ReadLine();

            if (respuesta == ResCorrectas[i])
                Console.WriteLine("Tu respuesta es Correcto ");
            else
                Console.WriteLine("Tu respuesta es Incorrecto. la opcion corresta es: b ");
        }
    }
}*/


        int puntaje = 0;
        string ContinuarJugando = "s";

        while (ContinuarJugando == "s")
        {
            puntaje = puntaje + 10;
            Console.WriteLine("Empezó tu partida");
            Console.WriteLine("Tu puntaje es: " + puntaje);

            Console.Write("¿Quieres seguir jugando? (s/n): ");
            ContinuarJugando = Console.ReadLine();
        }

        Console.WriteLine("Tu puntaje final es " + puntaje);
 