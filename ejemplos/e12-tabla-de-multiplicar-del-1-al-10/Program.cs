// 3. Tablas de multiplicar: Solicitar un número al usuario y
// mostrar su tabla de multiplicar del 1 al 10 usando for.

Console.Write("ingrese un númmero: ");

if (int.TryParse(Console.ReadLine(), out int esNumero) && esNumero >= 0)
{
    Console.WriteLine($"La tabla de Multipiclacion del {esNumero} es: ");
    Console.WriteLine(); //para simular el espacio
    for (int i = 1; i <= 10; i++)
    {
        int resultado = esNumero * i;
        //Console.WriteLine(" ");
        Console.WriteLine($"{esNumero} X {i} = {resultado} ");
    }
    Console.WriteLine();//para simular el espacio
}
else
{
    Console.Write("Ingrese un valor valido");
}