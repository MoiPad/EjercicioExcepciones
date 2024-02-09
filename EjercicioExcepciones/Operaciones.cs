

namespace EjercicioExcepciones
{
    public class Operaciones
    {
        public void Sumar(double N1, double N2) 
        {
            double result = N1 + N2;
            Console.WriteLine($"El resultado de sumar {N1} + {N2} es : {result}");
        }
        public void Restar(double N1, double N2)
        {
            double result = N1 - N2;
            Console.WriteLine($"El resultado de restar {N1} - {N2} es : {result}");
        }
        public void Multiplicar(double N1, double N2)
        {
            double result = N1 * N2;
            Console.WriteLine($"El resultado de multiplicar {N1} * {N2} es : {result}");
        }
        public void Dividir(double N1, double N2)
        {
            try {
                if (N2 == 0)
                {
                    Console.WriteLine("No se puede dividir por cero");
                }
                else 
                {
                    double result = N1 / N2;
                    Console.WriteLine($"El resultado de dividir {N1} / {N2} es : {result}");
                }
            
            }catch (Exception e) 
            {
                Console.WriteLine($"Error:{e.Message}");
            }
          
        }
    }
}
