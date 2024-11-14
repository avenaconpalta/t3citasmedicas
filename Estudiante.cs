public class Estudiante
{
    public int Codigo { get; set; }
    public string Nombre { get; set; }
    public string Universidad { get; set; }

    public Estudiante(int codigo, string nombre, string universidad)
    {
        Codigo = codigo;
        Nombre = nombre;
        Universidad = universidad;
    }

    public override string ToString()
    {
        return $"C�digo: {Codigo}, Nombre: {Nombre}, Universidad: {Universidad}";
    }
}
