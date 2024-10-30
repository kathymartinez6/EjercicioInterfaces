
namespace EjercicioInterfaces
{
    public class Operaciones : IOperaciones
    {
        public double AreaCirculo(double radio)
        {
            return Math.PI * radio * radio;
        }

        public double AreaRectangulo(double largo, double ancho)
        {
            return largo * ancho;
        }

        public double AreaTriangulo(double baseTriangulo, double altura)
        {
            return (baseTriangulo * altura) / 2;
        }

        public double LongitudCircunferencia(double radio)
        {
            return 2 * Math.PI * radio;
        }

        public double VolumenCubo(double lado)
        {
            return Math.Pow(lado, 3);
        }
        public void Imprimir()
        {
            Console.WriteLine("Resultados de las operaciones:");
        }
    }
}
