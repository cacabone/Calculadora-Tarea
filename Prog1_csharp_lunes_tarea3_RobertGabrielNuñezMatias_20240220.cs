try
{
    Console.WriteLine("Bienvenido a la calculadora");

    decimal typedNumber1 = new decimal();
    decimal typedNumber2 = new decimal();
    decimal result = 0;
    bool running = true;
    int newNumber = new int();
    newNumber = 1;

    while (running)
    {

        Console.WriteLine("Elige una opcion: \n1. Sumar \n2. Restar \n3. Multiplicacion \n4. Division \n5. Salir");
        int typedOption = Convert.ToInt32(Console.ReadLine());

        switch (typedOption)
        {

            case 1: // Suma
                {
                    Addition(out typedNumber1, out typedNumber2, out result, newNumber);
                }
                break;

            case 2: // Resta
                {
                    Subtraction(out typedNumber1, out typedNumber2, out result, newNumber);
                }
                break;

            case 3: // Multiplicacion
                {
                    Multiplication(out typedNumber1, out typedNumber2, out result, newNumber);
                }
                break;

            case 4: // Division
                {
                    Division(out typedNumber1, out typedNumber2, out result, newNumber);
                }
                break;

            case 5:
                {
                    running = false;
                }
                break;

            default:
                {
                    Console.WriteLine("Esa no es una opcion....");
                }
                break;
        }
    }

    static void Addition(out decimal typedNumber1, out decimal typedNumber2, out decimal result, int newNumber)
    {
        Console.WriteLine("Ingresa un numero: ");
        typedNumber1 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Ingresa otro numero: ");
        typedNumber2 = Convert.ToDecimal(Console.ReadLine());

        result = typedNumber1 + typedNumber2;

        while (newNumber != 2)
        {
            Console.WriteLine("Quiere ingresar otro numero? : 1. Si     2. No");
            newNumber = Convert.ToInt32(Console.ReadLine());

            if (newNumber == 1)
            {
                Console.WriteLine("Ingresa otro numero: ");
                typedNumber2 = Convert.ToDecimal(Console.ReadLine());

                result += typedNumber2;
            }
        }
        Console.WriteLine($"La suma de estos numeros es: {result}");
    }

    static void Subtraction(out decimal typedNumber1, out decimal typedNumber2, out decimal result, int newNumber)
    {
        Console.WriteLine("Ingresa un numero: ");
        typedNumber1 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Ingresa otro numero: ");
        typedNumber2 = Convert.ToDecimal(Console.ReadLine());

        result = typedNumber1 - typedNumber2;

        while (newNumber != 2)
        {
            Console.WriteLine("Quiere ingresar otro numero? : 1. Si     2. No");
            newNumber = Convert.ToInt32(Console.ReadLine());

            if (newNumber == 1)
            {
                Console.WriteLine("Ingresa otro numero: ");
                typedNumber2 = Convert.ToDecimal(Console.ReadLine());

                result -= typedNumber2;
            }
        }
        Console.WriteLine($"La resta de estos numeros es: {result}");
    }

    static void Multiplication(out decimal typedNumber1, out decimal typedNumber2, out decimal result, int newNumber)
    {
        Console.WriteLine("Ingresa un numero: ");
        typedNumber1 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Ingresa otro numero: ");
        typedNumber2 = Convert.ToDecimal(Console.ReadLine());

        result = typedNumber1 * typedNumber2;

        while (newNumber != 2)
        {
            Console.WriteLine("Quiere ingresar otro numero? : 1. Si     2. No");
            newNumber = Convert.ToInt32(Console.ReadLine());

            if (newNumber == 1)
            {
                Console.WriteLine("Ingresa otro numero: ");
                typedNumber2 = Convert.ToDecimal(Console.ReadLine());

                result *= typedNumber2;
            }
        }
        Console.WriteLine($"La multiplicacion de estos numeros es: {result}");
    }

    static void Division(out decimal typedNumber1, out decimal typedNumber2, out decimal result, int newNumber)
    {
        Console.WriteLine("Ingresa un numero: ");
        typedNumber1 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Ingresa otro numero: ");
        typedNumber2 = Convert.ToDecimal(Console.ReadLine());

        result = typedNumber1 / typedNumber2;

        while (newNumber != 2)
        {
            Console.WriteLine("Quiere ingresar otro numero? : 1. Si     2. No");
            newNumber = Convert.ToInt32(Console.ReadLine());

            if (newNumber == 1)
            {
                Console.WriteLine("Ingresa otro numero: ");
                typedNumber2 = Convert.ToDecimal(Console.ReadLine());

                result /= typedNumber2;
            }
        }
        Console.WriteLine($"La division de estos numeros es: {result}");
    }
}

catch (DivideByZeroException error)
{
    Console.WriteLine($"You cannot divide by zero: {error.Message}");
}

catch (ArithmeticException error)
{
    Console.WriteLine($"You cannot divide by zero: {error.Message}");
}
catch (Exception error)
{
    Console.WriteLine($"Invalid value: {error.Message}");
}
finally
{
    Console.WriteLine("Closing App...");
}