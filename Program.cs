using System;

namespace calificaciones_con_while
{
    class Program
    {
        static void Main(string[] args)
        {
            float suma, x, promedio, valor;
            x = 0;
            suma = 0;

            string salir;
            do
            {
                Console.WriteLine("Introduzca la calificación:");
                valor = float.Parse(Console.ReadLine());
                suma = suma + valor;
                x++;

                Console.WriteLine("¿Desea introducir otra calificación? s/n");
                salir = Console.ReadLine();

            } while (salir != "n");
            {
                promedio = suma / x;
                Console.WriteLine("El promedio de calificaciones es:" + promedio);
                Console.ReadLine();
            }
        }
    }
}
