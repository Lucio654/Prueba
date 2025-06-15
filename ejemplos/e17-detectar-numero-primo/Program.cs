// 8. Detectar número primo
//Usar un bucle for para determinar si un número ingresado por el usuario es primo o no.

Console.Write("Ingrese un número: ");
int numero = int.Parse(Console.ReadLine());

if (numero < 2) 
{
    Console.WriteLine($"{numero} NO es un número primo.");
}
else 
{
    bool esPrimo = true;

    for (int i = 2; i < numero; i++) 
    {
        if (numero % i == 0) 
        {
            esPrimo = false;
            break; 
        }
    }

    if (esPrimo)
        Console.WriteLine($"{numero} es un número primo.");
    else
        Console.WriteLine($"{numero} NO es un número primo.");
}