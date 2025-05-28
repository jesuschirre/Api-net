using apiprimero.Models;
using apiprimero.Services;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
// File: SuperheroController.cs
namespace apiprimero.Controllers;


[ApiController]
[Route("api/[controller]")]
public class SuperheroController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Superhero>> GetSuperhero()
    {
        return SuperheroDataStore.Current.Superheroes;
    }

    [HttpGet("(superheroid)")]
    public ActionResult<Superhero> GetSuperheroid(int superheroid)
    {
        var superhero = SuperheroDataStore.Current.Superheroes.FirstOrDefault(x => x.Id == superheroid);

        if(superhero == null){
            return NotFound("EL superhero no existe");
        }
        return Ok(superhero);
    }

}