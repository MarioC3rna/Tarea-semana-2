Console.WriteLine("Uso de char y string");
Console.WriteLine("");

//Texto a Mayusculas
string nota1, notaM;
Console.WriteLine("---Ingrese su texto para que lo imprima en Mayuscula---");
Console.WriteLine("");
Console.WriteLine("Ingrese su texto aqui en Minuscula");
nota1 = Console.ReadLine();
notaM = nota1.ToUpper();
Console.WriteLine("Este es su texto " + notaM);

//Imprime en Minusculas 
string nota2, notam;
Console.WriteLine("");
Console.WriteLine("--Ingrese su texto para que lo imprima en Minusculas--");
Console.WriteLine("");
Console.WriteLine("Ingrese su texto aqui en Mayusculas");
nota2 = Console.ReadLine();
notam = nota2.ToLower();
Console.WriteLine("Este es su texto " + notam);

//Imprime al reves 
string nota3;
Console.WriteLine("");
Console.WriteLine("--Ingrese su texto que quire imprimir al reves--");
Console.WriteLine("");
Console.WriteLine("Ingrese su texto aqui su texto");
nota3 = Console.ReadLine();
char[] notaInv = nota3.ToCharArray();
Array.Reverse(notaInv);
string notaNueva = new string(notaInv);
Console.WriteLine("Este es su texto " + notaNueva);

//Buscardor
string nota4;
Console.WriteLine("");
Console.WriteLine("---Ingrese su cadena de texto---");
Console.WriteLine("");
nota4 = Console.ReadLine();
Console.WriteLine("Ingrese la palabra que quiere buscar");
string Pbuscar = Console.ReadLine();
string notaMinus = nota4.ToLower();
bool Pbuscada = nota4.Contains(notaMinus);



if (Pbuscada)
{

    Console.WriteLine("La palabra " + Pbuscar + " Fue encontrada ");
}
else
{

    Console.WriteLine("La palabra" + Pbuscar + "No fue encontrada en el texto ");
}

//Contar las Vocales 
string nota5;
Console.WriteLine("");
Console.WriteLine("--Ingrese su texto del cual quiere contar las vocales--");
Console.WriteLine("");
Console.WriteLine("Ingrese su texto aqui ");
nota5 = Console.ReadLine();
int Cvocales = nota5.Count(c => "aeiouAEIOU".Contains(c));
Console.WriteLine("Este es la cantidad de vocales que tiene su texto " + Cvocales);
