using System;

class program
{
    static void Main()
    {
        Console.Write("Ingrese un numero romano: ");
        string romano = Console.ReadLine().ToUpper();

        int resultado = RomanoADecimal(romano);
        if (resultado == -1)
            Console.WriteLine("Numero romano invalido.");
        else
            Console.WriteLine("El numero decimal es: " + resultado);
    }

    static int RomanoADecimal(string romano)
    {
        int total = 0;
        int anterior = 0;

        for (int i = romano.Length - 1; i >= 0; i--)
        {
            int valor = ValorRomano(romano[i]);
            if (valor == 0) return -1;

            if (valor < anterior)
                total -= valor;
            else
            {
                total += valor;
                anterior = valor;
            }
        }
        return total;
    }

    static int ValorRomano(char c)
    {
        switch (c)
        {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'M': return 1000;
            default: return 0;
        }
    }

}