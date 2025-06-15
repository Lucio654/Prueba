// Sumar números del 1 al N. Pedir al usuario un número N y sumar 
//todos los números del 1 hasta N usando while.

Console.Write("Ingrese un número: " );

if (int.TryParse(Console.ReadLine(), out int esNumero) && esNumero >= 0)
{
    //Console.Write("ingreso valido");

    int sumar = 0;
    int Contador = 1;

    while (Contador <= esNumero)
    {
        Console.WriteLine(Contador);
        sumar = sumar + Contador;
        Contador ++;

    }
    Console.Write($"La suma de los numeros del 1 al {esNumero} es: {sumar}");
}
else
{
    Console.Write("Ingrese un valor valido");
}