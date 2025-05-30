// See https://aka.ms/new-console-template for more information
Console.WriteLine("ingrese el primer numero");
string? entradaPorTeclado = Console.ReadLine();
int num1 = int.Parse(entradaPorTeclado);
Console.WriteLine("ingrese el segundo numero");
string? entradaPorTeclado1 = Console.ReadLine();
int num2 = int.Parse(entradaPorTeclado1);
Console.WriteLine("ingrese el tercer numero");
string? entradaPorTeclado2 = Console.ReadLine();
int num3 = int.Parse(entradaPorTeclado2);

if (num1 > num2 && num1 > num2)
{
    Console.WriteLine($"El numero mayor es {num1}");
}
else if (num2 > num1 && num2 > num3)
{
    Console.WriteLine($"El numero mayor es {num2}");
}
else if (num3 > num1 && num3 > num2)
{
    Console.WriteLine($"El numero mayor es {num3}");
}