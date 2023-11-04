using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // POBLADO DE ARRREGLOS
            string[] nombres = { "Juan", "Manuel", "Kevin", "Maria", "Zulma", "Kenia" };

            double[] notas_promedio = new double[6];

            notas_promedio[0] = 7.5;
            notas_promedio[1] = 9.5;
            notas_promedio[2] = 6.5;
            notas_promedio[3] = 10;
            notas_promedio[4] = 5.6;
            notas_promedio[5] = 8.9;

            // LECTURA DE ARREGLOS
            string PrimeraPosicion = nombres[0]; // Juan
            string SegundaPosicion = nombres[1]; // Manuel
            string TerceraPosicion = nombres[2]; // Kevin
            string CuartaPosicion = nombres[3]; // Maria
            string QuintaPosicion = nombres[4]; // Zulma
            string SextaPosicion = nombres[5]; // Kenia

            double NotaPrimeraPosicion = notas_promedio[0]; // 7.5
            double NotaSegundaPosicion = notas_promedio[1]; // 9.5
            double NotaTerceraPosicion = notas_promedio[2]; // 6.5
            double NotaCuartaPosicion = notas_promedio[3]; // 10
            double NotaQuintaPosicion = notas_promedio[4]; // 5.6
            double NotaSextaPosicion = notas_promedio[5]; // 8.9

            // ORDENAMIENTO DE ARREGLO
            Console.WriteLine("\n<<<<<< Mostrando los 6 alumnos de forma ascendente >>>>>>");
            Array.Sort(nombres);
            foreach (string Nombre in nombres)
            {
                Console.WriteLine(Nombre);
            }

            Console.WriteLine("\n<<<<<< Mostrando los 6 alumnos de forma descendente >>>>>>");
            Array.Reverse(nombres);
            foreach (string Nombre in nombres)
            {
                Console.WriteLine(Nombre);
            }

            Console.WriteLine("\n<<<<<< Mostrando las 6 notas de forma ascendente >>>>>>");
            Array.Sort(notas_promedio);
            foreach (double Notas1 in notas_promedio)
            {
                Console.WriteLine(Notas1);
            }

            Console.WriteLine("\n<<<<<< Mostrando las 6 notas de forma descendente >>>>>>");
            Array.Reverse(notas_promedio);
            foreach (double Notas1 in notas_promedio)
            {
                Console.WriteLine(Notas1);
            }

            // IMPRESION DE RESULTADO DE ARREGLOS

            Console.WriteLine("\n<<<<<< Mostrando los 6 alumnos con sus notas del primer computo >>>>>>");
            Console.WriteLine(PrimeraPosicion + " Tiene la siguiente nota: " + NotaPrimeraPosicion);
            Console.WriteLine(SegundaPosicion + " Tiene la siguiente nota: " + NotaSegundaPosicion);
            Console.WriteLine(TerceraPosicion + " Tiene la siguiente nota: " + NotaTerceraPosicion);
            Console.WriteLine(CuartaPosicion + " Tiene la siguiente nota: " + NotaCuartaPosicion);
            Console.WriteLine(QuintaPosicion + " Tiene la siguiente nota: " + NotaQuintaPosicion);
            Console.WriteLine(SextaPosicion + " Tiene la siguiente nota: " + NotaSextaPosicion);
        }
    }
}