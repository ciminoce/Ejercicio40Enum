using Ejercicio40Enum;
using System.Reflection.Metadata;

try
{
    Console.WriteLine("Operaciones Básicas");
    Console.Title = "Operaciones Básicas";
    Console.Write("Ingrese el primer número:");
    var numero1 = int.Parse(Console.ReadLine());
    Console.Write("Ingrese el segundo número:");
    var numero2 = int.Parse(Console.ReadLine());
    int resultado = 0;
    Console.WriteLine("1-Suma");
    Console.WriteLine("2-Resta");
    Console.WriteLine("3-Producto");
    Console.WriteLine("4-División");
    Console.Write("Seleccione:");
    var opcionNumerica = int.Parse(Console.ReadLine());
    Operacion operacionSeleccionada = Operacion.Suma;
    if (opcionNumerica >= 1 && opcionNumerica <= 4)
    {
        operacionSeleccionada = (Operacion)opcionNumerica;
        switch (operacionSeleccionada)
        {
            case Operacion.Suma:
                resultado = Sumar(numero1, numero2);
                break;
            case Operacion.Resta:
                resultado = Restar(numero1, numero2);
                break;
            case Operacion.Producto:
                resultado = Producto(numero1, numero2);
                break;
            case Operacion.Division:
                resultado = Division(numero1, numero2);
                break;

        }
        Console.WriteLine($"El resultado es {resultado}");

    }
    else
    {
        Console.WriteLine("Selección errónea");
    }

}
catch (OverflowException)
{
    Console.WriteLine("Número fuera de los límites permitidos");
}
catch (FormatException)
{

    Console.WriteLine("Número mal ingresado");
}
catch(DivideByZeroException)
{
    Console.WriteLine("No se puede dividir por cero");
}
catch (Exception)
{
    Console.WriteLine("Excepción no manejada... Joder");
}

Console.ReadLine();
int Division(int numero1, int numero2)
{
    if (numero2==0)
    {
        throw new DivideByZeroException();
    }
    return numero1 / numero2;
}

int Producto(int numero1, int numero2) => numero1 * numero2;


int Restar(int numero1, int numero2) => numero1 - numero2;


int Sumar(int numero1, int numero2) => numero1 + numero2;
