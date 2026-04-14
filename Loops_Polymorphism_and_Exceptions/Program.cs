var circ = new Circulo();
circ.Radio = 20;
var result_area = circ.Area();
var result_perimetro = circ.Perimetro();

Console.WriteLine($"El área del círculo es: {result_area}");
Console.WriteLine($"El perímetro del círculo es: {result_perimetro}");
Console.WriteLine($"El nuevo radio es: {circ.Add10()}");

int prev = 0, next = 1, sum;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(prev);
    sum = prev + next;
    prev = next;
    next = sum;
}
try {
Console.WriteLine("Numero a dividir: ");
double n = double.Parse(Console.ReadLine());
Console.WriteLine("Divisor: ");
double divisor = double.Parse(Console.ReadLine());

if (divisor == 0)
{
    throw new DivideByZeroException();
}

Console.WriteLine($"Resultado: {n / divisor}");
} catch (DivideByZeroException){
    Console.WriteLine("Error: No se puede dividir por cero.");
} catch (Exception ex){
    Console.WriteLine($"Error inesperado, digitaste una letra: {ex.Message}");
}




/*abstract class Figura
{
    public abstract double Area();
    public abstract double Perimetro();
}*/

interface iExtracCalculations
{
    public double Add10();
}

interface iFigura
{
    public double Area();
    public double Perimetro();
}


class Circulo : iFigura, iExtracCalculations
{
    public double Radio { get; set; }

    public double Area() => Math.PI * Radio * Radio;
    public double Perimetro() => 2 * Math.PI * Radio;

    public double Add10() => Radio + 10;
}