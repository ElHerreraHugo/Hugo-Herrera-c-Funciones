
class CarcularArea


{

    static double CalcularRectangulo(double baseRectangulo, double alturaRectangulo)
    {
        return baseRectangulo * alturaRectangulo;
    }


    static double CalcularTriangulo(double baseTriangulo, double alturaTriangulo)
    {
        return   baseTriangulo * alturaTriangulo;
    }


    static double calcularreacirculo(double radiocirculo)
    {
          return Math.PI * Math.Pow(radiocirculo, 2);
    }

    static void Main()
    {
        // Menú de opciones
        Console.WriteLine("Elija una Opcion para calcular el area:");
        Console.WriteLine("1. Triangulo");
        Console.WriteLine("2. Rectangulo");
        Console.WriteLine("3. Circulo");
        Console.Write("Elija una opcion: ");



        int opcion = int.Parse(Console.ReadLine());

    
        switch (opcion)


        {

            case 1:
                Console.Write("Ingrese la base del triangulo: ");
                double baseTriangulo = double.Parse(Console.ReadLine());
                Console.Write("Ingrese la altura del triángulo: ");
                double alturaTriangulo = double.Parse(Console.ReadLine());
                Console.WriteLine($"El área del triangulo es: {CalcularTriangulo(baseTriangulo, alturaTriangulo)}");


                break;

            case 2:
                Console.Write("Ingrese la base del Rectangulo: ");
                double baseRectangulo = double.Parse(Console.ReadLine());
                Console.Write("Ingrese la altura del Rectangulo: ");
                double alturaRectangulo = double.Parse(Console.ReadLine());

                Console.WriteLine($"El área del Rectangulo es: {CalcularRectangulo(baseRectangulo, alturaRectangulo)}");


                break;




            case 3:
                              Console.WriteLine("ingresa el radio del círculo: ");
                           double radiocirculo = double.Parse(Console.ReadLine());
                          Console.WriteLine($"el área del círculo es: {calcularreacirculo(radiocirculo)}");

                break;                          
           }

        }
    }


