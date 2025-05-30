// ingrese una nota y que muestre si esta aprobado, en segunda instancia o aplazado.

Console.WriteLine("ingrese su nota");

string? entradaPorTeclado = Console.ReadLine();

if (int.TryParse(entradaPorTeclado, out int nota))
{
    if (nota > 50 && nota <= 100)
    {
        Console.WriteLine($"tienes una nota de {nota}, usted esta Aprobado...Felicidades!!!");
    }
    else if (nota > 39 && nota <= 50)
    {
        Console.WriteLine($"tienes una nota de {nota}, usted esta en Segundas Instancias");
    }
    else if (nota >= 0 && nota <= 39)
    {
        Console.WriteLine($"tienes una nota de {nota}, usted esta Reprobado");
    }
    else
    {
        Console.WriteLine("ingrese una nota que este en el rango de 0 a 100");
    }

}
else
{
    Console.WriteLine("ingrese un número valido");
}


//codigo mas optimizado con Switch.

/*Console.WriteLine("Ingrese su nota:");

string? entradaporTeclado = Console.ReadLine();

if (int.TryParse(entradaporTeclado, out int nota))
{
    switch (nota)
    {
        case >= 51 and <= 100:
            Console.WriteLine($"Tienes una nota de {nota}, usted está Aprobado... ¡Felicidades!");
            break;
        case >= 40 and <= 50:
            Console.WriteLine($"Tienes una nota de {nota}, usted está en Segundas Instancias.");
            break;
        case >= 0 and <= 39:
            Console.WriteLine($"Tienes una nota de {nota}, usted está Reprobado.");
            break;
        default:
            Console.WriteLine("Ingrese una nota que esté en el rango de 0 a 100.");
            break;
    }
}
else
{
    Console.WriteLine("Ingrese un número válido.");
}*/