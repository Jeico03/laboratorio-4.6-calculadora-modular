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

            while(true)
            {
                Console.WriteLine("Seleccione la operacion a realizar:");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.WriteLine("5. Salir");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        decimal suma = Sumar(num1, num2);
                        Console.WriteLine($"El resultado de la suma es: {suma}");
                        break;
                    case 2:
                        decimal resta = Restar(num1, num2);
                        Console.WriteLine($"El resultado de la resta es: {resta}");
                        break;
                    case 3:
                        decimal multiplicacion = Multiplicar(num1, num2);
                        Console.WriteLine($"El resultado de la multiplicacion es: {multiplicacion}");
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            decimal division = Dividir(num1, num2);
                            Console.WriteLine($"El resultado de la division es: {division}");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa...");
                        return;
                    default:
                        Console.WriteLine("Opcion invalida. Intente nuevamente.");
                        break;
                }
            }

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
