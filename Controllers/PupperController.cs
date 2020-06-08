using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Pupper.Models;

namespace Pupper.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PupperController : ControllerBase
  {
    private PupperContext _db;

    public PupperController(PupperContext db)
    {
      _db = db;
    }

    // GET api/animals
    [HttpGet]
    public ActionResult<IEnumerable<Doggo>> Get()
    {
      return _db.Doggos.ToList();
    }

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
  }
}