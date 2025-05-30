// 6. Realizar un programa que reciba un mes y muestre si es enero, febrero, marzo, abril, mayo, junio, julio, agosto, septiembre, octubre, noviembre o diciembre

Console.WriteLine("ingrese un numero entre el 1 y 12");

string? entradaPorTeclado = Console.ReadLine();

if (int.TryParse(entradaPorTeclado, out int mesnum))
{
    switch (mesnum)
    {
        case 1:
            Console.WriteLine("Enero");
            break;
        case 2:
            Console.WriteLine("Febrero");
            break;
        case 3:
            Console.WriteLine("Marzo");
            break;
        case 4:
            Console.WriteLine("Abril");
            break;
        case 5:
            Console.WriteLine("Mayo");
            break;
        case 6:
            Console.WriteLine("Junio");
            break;
        case 7:
            Console.WriteLine("Julio");
            break;
        case 8:
            Console.WriteLine("Agosto");
            break;
        case 9:
            Console.WriteLine("Septiembre");
            break;
        case 10:
            Console.WriteLine("Octubre");
            break;
        case 11:
            Console.WriteLine("Noviembre");
            break;
        case 12:
            Console.WriteLine("Diciembre");
            break;
        default:
            Console.WriteLine("Mes no valido");
            break;     
    }    
}
else
{
    Console.WriteLine("ingrese un numero valido que este entre 1 y 12");
}

/*Console.WriteLine("Ingrese un número del 1 al 12:");
string? entrada = Console.ReadLine();

if (int.TryParse(entrada, out int mes) && mes >= 1 && mes <= 12)
{
    string nombreMes = mes switch
    {
        1 => "Enero", 2 => "Febrero", 3 => "Marzo", 4 => "Abril",
        5 => "Mayo", 6 => "Junio", 7 => "Julio", 8 => "Agosto",
        9 => "Septiembre", 10 => "Octubre", 11 => "Noviembre", 12 => "Diciembre",
        _ => "Mes no válido"
    };

    Console.WriteLine($"El mes es {nombreMes}.");
}
else
{
    Console.WriteLine("Ingrese un número válido.");
}
*/

