
class Program
{
 
    static void Main(string par)
    {
        Console.WriteLine(" Ingrese un Parrafo o un Texto : ");


        string texto = Console.ReadLine();
   

        int cantidadPalabras = ContarPalabras(texto);
        int cantidadVocales = ContarVocales(texto);
        string textoInvertido = InvertirTexto(texto);


        Console.WriteLine($"Número de palabras: {cantidadPalabras}");
                Console.WriteLine($"Número de vocales: {cantidadVocales}");
                Console.WriteLine($"Texto invertido: {textoInvertido}");
            }

    static int ContarPalabras(string texto)

    {
        string[] palabras = texto.Split(' ');
        return palabras.Length;
    }
   
    static int ContarVocales(string texto)
    {
        int contar = 0;
        foreach (char cortar in texto.ToLower())
        {
            if ("a e i o u".Contains(cortar))
            {
                contar++;
            }
        }
        return contar;
    }
    static string InvertirTexto(string texto)
    {
        char[] cadena = texto.ToCharArray();
        Array.Reverse(cadena);
        return (texto);
    }
}





