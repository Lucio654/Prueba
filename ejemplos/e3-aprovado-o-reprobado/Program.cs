

Console.WriteLine("Ingrese su nota:");
string entradaPorteclado=Console.ReadLine ();
double nota = double.Parse(entradaPorteclado);


if (nota >= 51 && nota <= 100)
{
    Console.WriteLine("Usted está aprobado con nota de " + nota);
}
else if (nota >= 0 && nota < 51)
{
    Console.WriteLine("Usted está reprobado.");
}
else
{
    Console.WriteLine("Nota fuera de rango. Debe estar entre 0 y 100.");
}
