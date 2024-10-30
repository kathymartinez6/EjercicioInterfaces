
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
            throw new NotImplementedException();
        }

        public double AreaTriangulo(double baseTriangulo, double altura)
        {
            throw new NotImplementedException();
        }

        public void Imprimir()
        {

        }

        public double LongitudCircunferencia(double radio)
        {
            throw new NotImplementedException();
        }

        public double VolumenCubo(double lado)
        {
            throw new NotImplementedException();
        }
    }
}
