// Solicite la edad y mostrar por consola si es mayor o menor de edad

Console.WriteLine("ingrese su edad");

String? entradaPorTeclado = Console.ReadLine(); //lee la entrada del usuario

if (int.TryParse(entradaPorTeclado, out int edad)) //Intenta onvertir la entrada en un numero
{
    if (edad >= 18)
    {
        Console.WriteLine($"Tienes {edad} años, Usted es Mayor de Edad");
    }
    else
    {
        Console.WriteLine($"Tienes {edad} años, Usted es Menor de Edad");
    }
}
else
{
    Console.WriteLine("Ingrese un numero valido");

}


