// See https://aka.ms/new-console-template for more information


Console.WriteLine("Por favor ingrese un valor:");
int Edad = Console.ReadLine();

string miVariable = Edad;

    if (Edad <= 3)
    {
        Console.WriteLine($"Tienes {Edad} años. Eres recién nacido.");
    }
    else if ((Edad > 3) && (Edad <= 9))
    {
        Console.WriteLine($"Tienes {Edad} años. Eres un infante.");
    }
    else if ((Edad > 9) && (Edad <= 12))
    {
        Console.WriteLine($"Tienes {Edad} años. Eres un puberto.");
    }
    else if ((Edad > 12) && (Edad <= 19))
    {
        Console.WriteLine($"Tienes {Edad} años. Eres un adolescente.");
    }
    else if ((Edad > 19) && (Edad <= 29))
    {
        Console.WriteLine($"Tienes {Edad} años. Eres un joven.");
    }
    else if ((Edad > 29) && (Edad <= 39))
    {
        Console.WriteLine($"Tienes {Edad} años. Eres un adulto.");
    }
    else if ((Edad > 39) && (Edad <= 49))
    {
        Console.WriteLine($"Tienes {Edad} años. Eres un adulto mayor.");
    }
    else if ((Edad > 49) && (Edad <= 59))
    {
        Console.WriteLine($"Tienes {Edad} años. Eres un adulto mayor.");
    }
    else
    {
        Console.WriteLine($"Tienes {Edad} años. Eres un anciano.");
    }
