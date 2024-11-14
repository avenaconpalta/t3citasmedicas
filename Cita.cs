public class Cita
{
    public int Numero { get; set; }
    public Estudiante Estudiante { get; set; }
    public string Enfermedad { get; set; }
    public double Precio { get; set; }

    public Cita(int numero, Estudiante estudiante, string enfermedad, double precio)
    {
        Numero = numero;
        Estudiante = estudiante;
        Enfermedad = enfermedad;
        Precio = precio;
    }

    public override string ToString()
    {
        return $"N�mero: {Numero}, Enfermedad: {Enfermedad}, Estudiante: {Estudiante.Nombre}, Universidad: {Estudiante.Universidad}, Precio: {Precio:C}";
    }
}
