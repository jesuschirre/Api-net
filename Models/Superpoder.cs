namespace apiprimero.Models;

public class Superpoder
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public Epotencia Potencia { get; set; }
    public enum Epotencia
    {
        Bajo,
        Moderado,
        intenso,
        Potente,
        Repotente
    }
    
}