// 6. Validar entrada con do-while
//Pedir al usuario que introduzca un número positivo y seguir pidiendo hasta que lo haga correctamente.

    int numero;


do
{
    Console.Clear();
    Console.Write("Introduzca un numero positivo: ");
    while (!int.TryParse(Console.ReadLine(), out numero))
    {
    Console.WriteLine("Error: Debe ingresar un número válido.");
    Console.Write("Introduzca un número positivo: ");
    }
    if (numero <= 0)
    {
    Console.WriteLine("Ingrese un valor positivo");
    Console.WriteLine("Presiona una tecla para continuar...");
    Console.ReadKey();
    }
    

} while (numero <= 0);
Console.Write("se ingreso correctamente");

     