// See https://aka.ms/new-console-template for more information
const double PI = 3.14159265358979323846;


// if (Si (condicion) entonces ... caso contrario (else) ... fin si
// 1. Nota aprobacion si es mayo a 51 sino reprobado
int nota;

nota = 89;

if (nota >= 51)
{
    Console.WriteLine("La nota de " + nota + " es Aprobado");
}
else
{
    Console.WriteLine("Reprobado");
}

// 2. Dias de la semana
int dia = 15;

switch (dia)
{
    case 1:
        Console.WriteLine("Lunes");
        break;
    case 2:
        Console.WriteLine("Martes");
        break;
    case 3:
        Console.WriteLine("Miercoles");
        break;
    case 4:
        Console.WriteLine("Jueves");
        break;
    case 5:
        Console.WriteLine("Viernes");
        break;
    case 6:
        Console.WriteLine("Sabado");
        break;
    case 7:
        Console.WriteLine("Domingo");
        break;
    default:
        Console.WriteLine("Dia no valido");
        break;
}


// 3. Realizar un programa que reciba una edad y muestre si es mayor de edad o menor de edad


// 4. Realizar un programa que reciba un numero y muestre si es par o impar


// 5. Realizar un programa que reciba un numero y muestre si es positivo o negativo


// 6. Realizar un programa que reciba un mes y muestre si es enero, febrero, marzo, abril, mayo, junio, julio, agosto, septiembre, octubre, noviembre o diciembre



int a;
int b;
int suma;

a = 3;
b = 4;
suma = a + b;

Console.WriteLine("La suma de " + a + " + " + b + " es: " + suma);

Console.WriteLine("Esta es la constate PI que tiene el valor " + PI);

Console.WriteLine("Wilstermann campeon de la Libertadores 1994");
