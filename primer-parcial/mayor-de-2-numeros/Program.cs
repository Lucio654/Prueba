// ingrese 2 numeros y muestre el mayor de los 2

Console.WriteLine("ingrese el primer numero");
string? entradaPorTeclado = Console.ReadLine();
int num1 = int.Parse(entradaPorTeclado);
Console.WriteLine("ingrese el segundo numero");
string? entradaPorTeclado1 = Console.ReadLine();
int num2 = int.Parse(entradaPorTeclado1);

//if (int.TryParse(entradaPorTeclado, out int num1)&& (entradaPorTeclado1, out num2))

    if (num1 > num2)
    {
        Console.WriteLine($"El numero mayor es {num1}");
    }
    else if (num1 < num2)
    {
        Console.WriteLine($"El numero Mayor es {num2}");
    }
    else
    {
        Console.WriteLine("los dos numeros son iguales");
    }
