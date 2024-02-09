using EjercicioExcepciones;

Operaciones operacion = new Operaciones();
int op = 0;

while (op != 5)
{
    menu();
    try
    {
        op = int.Parse(Console.ReadLine());

        if (op >= 1 && op <= 5)
        {
            if (op == 5)
            {
                Console.WriteLine("Saliendo del menu, Bye Bye!");
            }
            else
            {
                Operacion(op, operacion);
            }
        }
        else
        {
            Console.WriteLine("Error: Ingrese un numero valido del 1 al 5.");
        }
    }
    catch (FormatException e)
    {
        Console.WriteLine($"Error: {e.Message}");
    }
}


static void menu()
{
    Console.WriteLine("************Menu de Opciones************");
    Console.WriteLine(new string('-', 40));
    Console.WriteLine("| 1. Sumar                             |");
    Console.WriteLine(new string('-', 40));
    Console.WriteLine("| 2. Restar                            |");
    Console.WriteLine(new string('-', 40));
    Console.WriteLine("| 3. Multiplicar                       |");
    Console.WriteLine(new string('-', 40));
    Console.WriteLine("| 4. Dividir                           |");
    Console.WriteLine(new string('-', 40));
    Console.WriteLine("| 5. Salir                             |");
    Console.WriteLine(new string('-', 40));
    Console.Write("Seleccione una opción del menu: ");
}
static void Operacion(int op, Operaciones operacion) 
{
    Console.WriteLine("Ingrese el primer número: ");
    double N1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo número: ");
    double N2 = Convert.ToDouble(Console.ReadLine());
    switch (op)
    {
        case 1:
            operacion.Sumar(N1, N2);
            break;
        case 2:
            operacion.Restar(N1, N2);
            break;
        case 3:
            operacion.Multiplicar(N1, N2);
            break; 
        case 4:
            operacion.Dividir(N1, N2);
            break;
    }    
}


