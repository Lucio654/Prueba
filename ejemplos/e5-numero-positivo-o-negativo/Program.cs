// ingrese un numero y que muestre si es positivo o negativo

Console.WriteLine("ingrese un numero");

string? entradaPorTeclado = Console.ReadLine();

if (double.TryParse(entradaPorTeclado, out double num))
{
    if (num > 0)
    {
        Console.WriteLine($"El numero {num} es positivo");
    }
    else if (num < 0)
    {
        Console.WriteLine($"El numero {num} es negativo");
    }
    else
        Console.WriteLine($"El numero {num} no es positivo ni negativo");
}
else
{
    Console.WriteLine("ingrese un número valido");
}

