// Que lea una calificacion 1 al 10 y muestre con letras (A, B, C, D, E, F...)
Console.WriteLine("ingrese su calificacion que este entre el rango 1 y 10");

string? entradaPorTeclado = Console.ReadLine();

if (int.TryParse(entradaPorTeclado, out int Nota))
{
    switch (Nota)
    {
        case 1:
            Console.WriteLine("J");
            break;
        case 2:
            Console.WriteLine("I");
            break;
        case 3:
            Console.WriteLine("H");
            break;
        case 4:
            Console.WriteLine("G");
            break;
        case 5:
            Console.WriteLine("F");
            break;
        case 6:
            Console.WriteLine("E");
            break;
        case 7:
            Console.WriteLine("D");
            break;
        case 8:
            Console.WriteLine("C");
            break;
        case 9:
            Console.WriteLine("B");
            break;
        case 10:
            Console.WriteLine("A");
            break;
        default:
            Console.WriteLine("Nota no valido, la nota tien que estar en rango de 1 y 10");
            break;     
    }    
}
else
{
    Console.WriteLine("ingrese un valor valido");
}

