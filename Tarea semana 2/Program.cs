Console.WriteLine("Operaciones con tipos de datos");
Console.WriteLine("");

//Suma
int n1, n2;
int resultado1;
Console.WriteLine("---Ingrese los numeros enteros que quiere Sumar---");
Console.WriteLine("Ingrese primer numero");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese segundo numero");
n2 = int.Parse(Console.ReadLine());
resultado1 = n1 + n2;
Console.WriteLine("El resultado es " + resultado1);

//Resta
decimal n3, n4, resultado2;
Console.WriteLine("");
Console.WriteLine("---Ingrese los numeros enteros que quiere Restar---");
Console.WriteLine("Ingrese primer numero");
n3 = decimal.Parse(Console.ReadLine());
Console.WriteLine("Ingrese segundo numero");
n4 = decimal.Parse(Console.ReadLine());
resultado2 = n3 - n4;
Console.WriteLine("El resultado es " + resultado2);



//Multipliacion
float n5, n6, resultado3;
Console.WriteLine("");
Console.WriteLine("---Ingrese los numeros flotantes que quiere Multiplicar---");
Console.WriteLine("Ingrese primer numero");
n5 = float.Parse(Console.ReadLine());
Console.WriteLine("Ingrese segundo numero");
n6 = float.Parse(Console.ReadLine());
resultado3 = n5 * n6;
Console.WriteLine("El resultado es " + resultado3);

//Division
int n7, n8, resultado4;
Console.WriteLine("");
Console.WriteLine("---Ingrese los numeros enteros que quiere Dividir---");
Console.WriteLine("Ingrese primer numero");
n7 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese segundo numero");
n8 = int.Parse(Console.ReadLine());
resultado4 = n7 / n8;
Console.WriteLine("El resultado es " + resultado4);

//Modulo de dos numeros enteros
int n9, n0, resultado5;
Console.WriteLine("");
Console.WriteLine("---Ingrese los numeros enteros que quiere ver su modulo---");
Console.WriteLine("Ingrese primer numero");
n9 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese segundo numero");
n0 = int.Parse(Console.ReadLine());
resultado5 = n9 % n0;
Console.WriteLine("El resultado de" + n9 + "entre" + n0 + "es el modulo " + resultado5);


