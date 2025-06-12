
Console.Write("Ingrese un número: " );

       int esNumero;
       bool esNumeroValido = int.TryParse(Console.ReadLine(), out esNumero);

    if (esNumeroValido && esNumero > 0)
       {
           int suma = 0;
           int i = 1;

           while (i <= esNumero)
           {
               Console.WriteLine(i + " ");
               suma += i;
               i++;
           }

           Console.WriteLine($"La suma de los números del 1 al {esNumero} es: {suma}");
        }
   else
   {
       Console.WriteLine("Ingrese un número mayor a 0");
   }


