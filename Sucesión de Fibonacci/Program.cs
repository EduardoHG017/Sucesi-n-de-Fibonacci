using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 0;
        bool validInput = false;

        // Solicita al usuario un número entero y lo valida usando try-catch
        while (!validInput)
        {
            try
            {
                Console.Write("Ingrese un número entero mayor que 0: ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0)
                {
                    throw new Exception("El número debe ser mayor que 0.");
                }
                validInput = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // Calcula la sucesión de Fibonacci hasta el término N
        int a = 0;
        int b = 1;
        int c;
        int i = 1;

        Console.Write("Posiciones de la sucesión de Fibonacci hasta el término {0}: {1} ", n, a);

        while (i < n)
        {
            c = a + b;
            Console.Write("{0} ", c);
            a = b;
            b = c;
            i++;
        }

        Console.WriteLine();
    }
}
