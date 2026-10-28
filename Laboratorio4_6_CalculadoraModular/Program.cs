namespace Laboratorio4_6_CalculadoraModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Modular");
            Console.WriteLine("Ingrese el primer numero");
            decimal num1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            decimal num2 = decimal.Parse(Console.ReadLine());

            decimal Sumar(decimal x, decimal y)
            {
                return x + y;
            }
            decimal Restar(decimal x, decimal y)
            {
                return x - y;
            }
            decimal Multiplicar(decimal x, decimal y)
            {
                return x * y;
            }
            decimal Dividir(decimal x, decimal y)
            {
                return x / y;
            }
        }
    }
}
