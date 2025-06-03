// Crea un programa en C# que solicite al usuario su edad (entre 0 y 120). Luego, el programa debe mostrar en pantalla la categoría a la que pertenece:

Console.WriteLine("Ingrese una edad entre (0 - 120): ");
string leerPorPantalla = Console.ReadLine();

bool esEdad = int.TryParse(leerPorPantalla, out int edad);

string resultado;

if (!esEdad)
{
    Console.WriteLine("No es una edad de valor entero");
    return;
}

switch (edad)
{
    case int _ when edad >= 0 && edad <= 5:
        resultado = "Bebé";
        break;
    case int _ when edad>= 6 && edad <= 12:
        resultado = "Niño/a";
        break;
    case int _ when edad>=13 && edad <= 17:
        resultado = "Adolescente";
        break;
    case int _ when edad >= 18 && edad <= 64:
        resultado = "Adulto";
        break;
    case int _ when edad >= 65 && edad <= 120:
        resultado = "Adulto Mayor";
        break;
    default:
        resultado = "Edad no esta en el rango de 0-120";
        break;
}

Console.WriteLine("Su categoria segun su edad es : " + resultado);
