using apiprimero.Models;

namespace apiprimero.Services;

public class SuperheroDataStore
{
    public List<Superhero> Superheroes {get; set;}

    public static SuperheroDataStore Current {get;} = new SuperheroDataStore();

    public SuperheroDataStore()
    {
        Superheroes = new List<Superhero>()
        {
            new Superhero(){
                Id = 1,
                Nombre = "Batman",
                NombreReal = "bruce",
                Superpoderes = new List<Superpoder>(){
                    new Superpoder(){
                        Id = 1,
                        Nombre = "Inteligencia",
                        Potencia = Superpoder.Epotencia.Bajo
                    }
                }
            }
        };
    }
}
