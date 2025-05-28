using System.Collections.Generic;
namespace apiprimero.Models;

public class Superhero
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string NombreReal { get; set; } = string.Empty;
    public List<Superpoder>? Superpoderes { get; set; }
}
