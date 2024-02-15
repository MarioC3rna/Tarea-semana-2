Console.WriteLine("Conversion de tipos ");

//De entero a decimal
Console.WriteLine("--Ingrese el numero Entero--");
int entero = Convert.ToInt32(Console.ReadLine());
decimal numDecimal = Convert.ToDecimal(entero);
Console.WriteLine("Numero decimal es " + numDecimal.ToString("0.0"));

//De decimal a flotante
Console.WriteLine("--Ingrese el numero decimal--");
decimal nDecimal = Convert.ToDecimal(Console.ReadLine());
float numfloat = Convert.ToSingle(nDecimal);
Console.WriteLine($"Numero Flotante es " + numfloat.ToString("0.00"));

//De flotante a entero
Console.WriteLine("--Ingrese el numero flotante--");
float nufloat = Convert.ToSingle(Console.ReadLine());
int numEntero = Convert.ToInt32(nufloat);
Console.WriteLine("Numero entero es " + numEntero);

// De entero a caracter
Console.WriteLine("--Ingrese el numero entero--");
int nEntero = Convert.ToInt32(Console.ReadLine());
char nCaracter = Convert.ToChar(nEntero);
Console.WriteLine("El caracter es " + nCaracter);

//De caracter a entero
Console.WriteLine("--Ingrese el caracter--");
char Caractern = Convert.ToChar(Console.ReadLine());
int nuEntero = Convert.ToInt32(Caractern);
Console.WriteLine("Numero entero es " + nuEntero);



