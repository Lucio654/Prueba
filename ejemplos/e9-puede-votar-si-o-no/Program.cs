//Dado una edad determina si puede votar 
Console.WriteLine("Ingrese su edad");
String? entradaPorTeclado = Console.ReadLine();
if (int.TryParse(entradaPorTeclado, out int edad))
{
    if (edad >= 18 && edad <= 120)
    {
        Console.WriteLine("Tienes " + edad +" años, usted puede votar");
    }
    else
    {
        Console.WriteLine("Vuelve cuando tengas 18 años");
    }
}
else
{
    Console.WriteLine("ingrese un valor valido");
}
