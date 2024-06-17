

double CelsiusAFahrenheit(double celsius)
{
    double Fahrenheit = (celsius * 1.8) + 32;
    return Fahrenheit;
}

double FahrenheitACelsius(double fahrenheit)
{
    double Celsius = (fahrenheit - 32) / 1.8;
    return Celsius;
}



double CelsiusAKelvin(double celsius)
{
    double Kelvin = celsius + 273.15;
    return Kelvin;
}


Console.WriteLine("Elije una Opcion para convertir temperaturas");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("   1. Celsius a Fahrenheit");

Console.WriteLine("   2. Fahrenheit a Celsius");

Console.WriteLine("   3. Celsius a Kelvin");

Console.Write("\nElija una opcion ");
int opcion = int.Parse(Console.ReadLine());



double Grado;


switch (opcion)
{
    case 1:
        Console.Write("Ingrese su  temperatura en Celsius : ");
        Grado = double.Parse(Console.ReadLine());
        Console.WriteLine($"Su temperatura en Fahrenheit es: {CelsiusAFahrenheit(Grado)}");
        break;


    case 2:


        Console.Write("Ingrese  su temperatura Celsius:");
        Grado = double.Parse(Console.ReadLine());
        Console.WriteLine($"Su temperatura en Fahrenheit es: {FahrenheitACelsius(Grado)}");
        break;


case 3:

    Console.Write("Ingrese la temperatura Celsius:");
    Grado = double.Parse(Console.ReadLine());
    Console.WriteLine($"Su temperatura en Kelvin es: {CelsiusAKelvin(Grado)}");
    break;

}



