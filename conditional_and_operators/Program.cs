
/*conditionals*/
/**Console.WriteLine("Ingrese un número");
int num = int.Parse(Console.ReadLine());

if(num >0) Console.WriteLine("Positivo");
else if(num < 0) Console.WriteLine("Negativo");
else Console.WriteLine("Es cero");**/
/*end contiionals*/

/*Operators*/

Console.WriteLine("Ingrese el primero número: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número: ");
double b = double.Parse(Console.ReadLine());

Console.WriteLine($"Suma: {a+b}, Resta: {a-b}, Multiplicación: {a*b}, División: {(b!=0 ? a/b : "Indeterminado")}");

/*end Operators*/
