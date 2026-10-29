namespace Laboratorio4_6_CalculadoraModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Calculadora Modular");
                decimal num1 = LeerNumero("Ingrese el primer numero:");
                decimal num2 = LeerNumero("Ingrese el segundo numero:");

                MostrarMenu();

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
                        else
                        {
                            Console.WriteLine("\n Error: No se puede dividir entre cero. Intente con otro valor.\n");
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
        }
    
        static void MostrarMenu()
        {
        Console.WriteLine("Seleccione la operacion a realizar:");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Dividir");
        Console.WriteLine("5. Salir");
        }

                static decimal LeerNumero(string mensaje)
                {
                decimal numero;
                do
                {
                    Console.WriteLine(mensaje);
                    string entrada = Console.ReadLine();

                    if (decimal.TryParse(entrada, out numero))
                    {
                        return numero;
                    }

                    Console.WriteLine("Entrada no válida. Debe ingresar un número. Intente otra vez.");
                }
                while (true);
                }

            static decimal Sumar(decimal x, decimal y)
            {
                return x + y;
            }
            static decimal Restar(decimal x, decimal y)
            {
                return x - y;
            }
            static decimal Multiplicar(decimal x, decimal y)
            {
                return x * y;
            }
            static decimal Dividir(decimal x, decimal y)
            {
                return x / y;
            }
    }
}