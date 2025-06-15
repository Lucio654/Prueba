//  7. Suma de 5 números ingresados por el usuario
//Pedir al usuario 5 números (uno por uno) y sumarlos usando for.

Console.WriteLine("Ingrese 5 numeros: ");
int resultado=0;

for (int i = 1; i <= 5; i++)
{
    Console.Write($"Numero {i}: ");
    if (int.TryParse(Console.ReadLine(), out int numero))
    {
        resultado = resultado + numero;
        
    }
    else
    {
        Console.WriteLine("Ingrese un numero valido");
        i--;
    }

}
Console.WriteLine($"La suma de los 5 numero ingresados es: {resultado}");

