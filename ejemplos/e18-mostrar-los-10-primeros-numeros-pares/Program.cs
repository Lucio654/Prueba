// 9. Mostrar los primeros 10 números pares
//Mostrar en pantalla los primeros 10 números pares usando while.
int numero=1;
int aux = 0;
while (aux < 10)
{
    if (numero % 2 == 0)
    {
        Console.WriteLine(numero);
        aux++;
    }
    numero++;
}
