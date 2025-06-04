

string leerPorTeclado, s1, s2;
int n1, n2;
double resultado;

do
{
    Console.Clear();
    Console.WriteLine("1. Suma ");
    Console.WriteLine("2. Resta ");
    Console.WriteLine("3. Multiplicacion ");
    Console.WriteLine("4. Division ");
    Console.WriteLine("0. Salir ");
    Console.WriteLine("Elige una opcion: ");
    leerPorTeclado = Console.ReadLine();

    switch (leerPorTeclado)
    {
        case "1":
            Console.WriteLine("Ingrese el primer numero: ");
            s1 = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo numero: ");
            s2 = Console.ReadLine();

            n1 = int.Parse(s1);
            n2 = int.Parse(s2);

            resultado = n1 + n2;

            Console.WriteLine("La suma es: " + resultado);

            break;
        case "2":
            Console.WriteLine("Ingrese el primer numero: ");
            s1 = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo numero: ");
            s2 = Console.ReadLine();

            n1 = int.Parse(s1);
            n2 = int.Parse(s2);

            resultado = n1 - n2;

            Console.WriteLine("La resta es: " + resultado);
            
            break;
        case "3":
            Console.WriteLine("Ingrese el primer numero: ");
            s1 = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo numero: ");
            s2 = Console.ReadLine();

            n1 = int.Parse(s1);
            n2 = int.Parse(s2);

            resultado = n1 * n2;

            Console.WriteLine("La Multiplicacion es: " + resultado);
            
            break;
        case "4":

            Console.WriteLine("Ingrese el primer numero: ");
            s1 = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo numero: ");
            s2 = Console.ReadLine();

            n1 = int.Parse(s1);
            n2 = int.Parse(s2);

            resultado = (double)n1 / n2;

            Console.WriteLine("La division es: " + resultado);

            break;
        case "0":
            break;
        default:
            Console.WriteLine("Opcion invalida!!!");
            break;
    }

    if (leerPorTeclado != "0")
    {
        Console.WriteLine();
        Console.WriteLine("Presiona una tecla para continuar...");
        Console.ReadKey();
    }

} while (leerPorTeclado != "0");
    