using System;
using System.Collections.Generic;

public static class CitaUtil
{
    public static void CrearCita(List<Cita> citas)
    {
        Console.WriteLine("Ingrese los datos del estudiante:");
        Console.Write("Código: ");
        int codigo = int.Parse(Console.ReadLine());

        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Universidad: ");
        string universidad = Console.ReadLine();

        Estudiante estudiante = new Estudiante(codigo, nombre, universidad);

        Console.WriteLine("Ingrese los datos de la cita:");
        Console.Write("Número de cita: ");
        int numero = int.Parse(Console.ReadLine());

        Console.Write("Enfermedad: ");
        string enfermedad = Console.ReadLine();

        Console.Write("Precio: ");
        double precio = double.Parse(Console.ReadLine());

        Cita cita = new Cita(numero, estudiante, enfermedad, precio);
        citas.Add(cita);

        Console.WriteLine("Cita creada con éxito.");
    }

    public static void ListarCitas(List<Cita> citas)
    {
        double sumaPrecios = 0;

        foreach (var cita in citas)
        {
            Console.WriteLine(cita);
            sumaPrecios += cita.Precio;
        }

        Console.WriteLine($"Total de precios: {sumaPrecios:C}");
    }

    public static void ModificarUniversidad(List<Cita> citas, string textoOriginal, string textoNuevo)
    {
        foreach (var cita in citas)
        {
            if (cita.Estudiante.Universidad.Contains(textoOriginal))
            {
                cita.Estudiante.Universidad = cita.Estudiante.Universidad.Replace(textoOriginal, textoNuevo);
            }
        }

        Console.WriteLine("Modificación realizada con éxito.");
    }
}
