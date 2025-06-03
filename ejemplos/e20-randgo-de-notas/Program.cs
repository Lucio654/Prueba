Console.WriteLine("Ingrese una nota entre (0 - 100): ");
string leerPorPantalla = Console.ReadLine();



bool esNumero = int.TryParse(leerPorPantalla, out int nota);

string resultado;

if (!esNumero)
{
    Console.WriteLine("No es una nota de valor entero");
    return;
}

switch (nota)
{
    case int _ when nota >= 97 && nota <= 100:
        resultado = "A+";
        break;
    case int _ when nota >= 93 && nota <= 96:
        resultado = "A";
        break;
    case int _ when nota >= 90 && nota <= 92:
        resultado = "A-";
        break;
    case int _ when nota >= 87 && nota <= 89:
        resultado = "B+";
        break;
    case int _ when nota >= 83 && nota <= 86:
        resultado = "B";
        break;
    case int _ when nota >= 80 && nota <= 82:
        resultado = "B-";
        break;
    case int _ when nota >= 70 && nota <= 79:
        resultado = "C";
        break;
    case int _ when nota >= 60 && nota <= 69:
        resultado = "D";
        break;
    case int _ when nota >= 0 && nota < 60:
        resultado = "F";
        break;
    default:
        resultado = "Nota inválida";
        break;
}

Console.WriteLine("La nota es: " + resultado);
