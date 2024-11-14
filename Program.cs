using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Cita> citas = new List<Cita>();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\nMenú de opciones:");
            Console.WriteLine("1. Crear Cita");
            Console.WriteLine("2. Listar Citas");
            Console.WriteLine("3. Modificar Universidad de forma masiva");
            Console.WriteLine("4. Fin");
            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    CitaUtil.CrearCita(citas);
                    break;
                case 2:
                    CitaUtil.ListarCitas(citas);
                    break;
                case 3:
                    Console.Write("Ingrese el texto a buscar: ");
                    string textoOriginal = Console.ReadLine();
                    Console.Write("Ingrese el texto nuevo: ");
                    string textoNuevo = Console.ReadLine();
                    CitaUtil.ModificarUniversidad(citas, textoOriginal, textoNuevo);
                    break;
                case 4:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }
}
