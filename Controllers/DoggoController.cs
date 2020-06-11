using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pupper.Models;
using Microsoft.AspNetCore.Authorization;

namespace Pupper.Controller
{
  [Authorize]
  [Route("api/[controller]")]
  [ApiController]
  public class DoggoController : ControllerBase
  {
    private PupperContext _db;

    public DoggoController(PupperContext db)
    {
      _db = db;
    }

    [AllowAnonymous]
    // GET api/animals
    [HttpGet]
    public ActionResult<IEnumerable<Doggo>> Get(string breed, string gender, string name)
    {
      var query = _db.Doggos.AsQueryable();
      if (breed != null)
      {
        query = query.Where(entry => entry.Breed == breed);
      }
      if (gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      return query.ToList();
    }

    [AllowAnonymous]
    [HttpGet("{id}")]
    public ActionResult<Doggo> Get(int id)
    {
      return _db.Doggos.FirstOrDefault(entry => entry.DoggoId == id);
    }

    // POST api/animals
    [HttpPost]
    public void Post([FromBody] Doggo doggo)
    {
      _db.Doggos.Add(doggo);
      _db.SaveChanges();
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Doggo doggo)

    {
      doggo.DoggoId = id;
      _db.Entry(doggo).State = EntityState.Modified;
      _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)

    {
      var doggoToDelete = _db.Doggos.FirstOrDefault(entry => entry.DoggoId == id);
      _db.Doggos.Remove(doggoToDelete);
      _db.SaveChanges();
    }
  }
}