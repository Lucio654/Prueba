//  4. Menú con do-while: Crear un pequeño menú que se repita
//hasta que el usuario elija salir (ejemplo: 1. Saludar, 2. Sumar, 3. Salir).


string? leerPorTeclado;

do
{
    Console.Clear();
    Console.WriteLine("MENU----");
    Console.WriteLine("1. Inicio ");
    Console.WriteLine("2. Ingresar ");
    Console.WriteLine("3. Tabla de operaciones ");
    Console.WriteLine("0. Salir ");
    Console.Write("Elige una opcion: ");

     leerPorTeclado = Console.ReadLine();

    switch (leerPorTeclado)
    {
        case "1":
            Console.WriteLine("Has seleccionado la opción: Inicio.");
            break;
        case "2":
            Console.WriteLine("Has seleccionado la opción: Ingresar.");
            break;
        case "3":
            Console.WriteLine("Has seleccionado la opción: Tabla de operaciones.");
            break;
        case "0":
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción inválida. asegurese de elegir una de las opciones del menu.");
            break;

    }
    
    if (leerPorTeclado != "0")
    {
        Console.WriteLine("Presiona una tecla para continuar...");
        Console.ReadKey();
    }

}
while (leerPorTeclado != "0");