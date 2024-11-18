using EjercicioInterfaces;

class Program
{
    static void Main(string[] args)
    {
        Operaciones operaciones = new Operaciones();

        Console.Write("Ingrese el radio del círculo: ");
        double radio = double.Parse(Console.ReadLine());
        Console.WriteLine($"Área del círculo: {operaciones.AreaCirculo(radio)}");

        Console.Write("Ingrese el largo del rectángulo: ");
        double largo = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el ancho del rectángulo: ");
        double ancho = double.Parse(Console.ReadLine());
        Console.WriteLine($"Área del rectángulo: {operaciones.AreaRectangulo(largo, ancho)}");

        Console.Write("Ingrese el lado del cubo: ");
        double lado = double.Parse(Console.ReadLine());
        Console.WriteLine($"Volumen del cubo: {operaciones.VolumenCubo(lado)}");

        Console.Write("Ingrese el radio de la circunferencia: ");
        double radioCircunferencia = double.Parse(Console.ReadLine());
        Console.WriteLine($"Longitud de la circunferencia: {operaciones.LongitudCircunferencia(radioCircunferencia)}");

        Console.Write("Ingrese la base del triángulo: ");
        double baseTriangulo = double.Parse(Console.ReadLine());
        Console.Write("Ingrese la altura del triángulo: ");
        double altura = double.Parse(Console.ReadLine());
        Console.WriteLine($"Área del triángulo: {operaciones.AreaTriangulo(baseTriangulo, altura)}");

        operaciones.Imprimir();
    }
}
Operaciones operaciones = new Operaciones();

Console.Write("Ingrese el radio del círculo: ");
double radio = double.Parse(Console.ReadLine());
Console.WriteLine($"Área del círculo: {operaciones.AreaCirculo(radio)}");

Console.Write("Ingrese el largo del rectángulo: ");
double largo = double.Parse(Console.ReadLine());
Console.Write("Ingrese el ancho del rectángulo: ");
double ancho = double.Parse(Console.ReadLine());
Console.WriteLine($"Área del rectángulo: {operaciones.AreaRectangulo(largo, ancho)}");

Console.Write("Ingrese el lado del cubo: ");
double lado = double.Parse(Console.ReadLine());
Console.WriteLine($"Volumen del cubo: {operaciones.VolumenCubo(lado)}");

Console.Write("Ingrese el radio de la circunferencia: ");
double radioCircunferencia = double.Parse(Console.ReadLine());
Console.WriteLine($"Longitud de la circunferencia: {operaciones.LongitudCircunferencia(radioCircunferencia)}");

Console.Write("Ingrese la base del triángulo: ");
double baseTriangulo = double.Parse(Console.ReadLine());
Console.Write("Ingrese la altura del triángulo: ");
double altura = double.Parse(Console.ReadLine());
Console.WriteLine($"Área del triángulo: {operaciones.AreaTriangulo(baseTriangulo, altura)}");

operaciones.Imprimir();

