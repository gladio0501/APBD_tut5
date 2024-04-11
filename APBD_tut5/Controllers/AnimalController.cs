using Microsoft.AspNetCore.Mvc;
using APBD_tut5.Models;
namespace APBD_tut5.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalsController : ControllerBase
{

    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = new MockDb().Animals;
        return Ok(animals);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetAnimal(int id)
    {
        var animals = new MockDb().Animals;
        var animal = animals.Find(a => a.Id == id);
        return Ok(animal);
    }
    
    //retrieve visits for a given animal
    [HttpGet("{id}/visits")]
    public IActionResult GetAnimalVisits(int id)
    {
        var animals = new MockDb().Animals;
        var animal = animals.Find(a => a.Id == id);
        return Ok(animal.visits);
    }
    
    //add visit for a given animal
    [HttpPost("{id}/visits")]
    public IActionResult AddVisit(int id, Visit visit)
    {
        var animals = new MockDb().Animals;
        var animal = animals.Find(a => a.Id == id);
        animal.visits.Add(visit);
        return Ok(animal.visits);
    }
    
    [HttpPost]
    public IActionResult AddAnimal(Animal animal)
    {
        var animals = new MockDb().Animals;
        animals.Add(animal);
        return Ok(animals);
    }
    
    [HttpDelete]
    public IActionResult DeleteAnimal(Animal animal)
    {
        var animals = new MockDb().Animals;
        animals.Remove(animal);
        return Ok(animals);
    }
    
    [HttpPut]
    public IActionResult UpdateAnimal(Animal animal)
    {
        var animals = new MockDb().Animals;
        var index = animals.FindIndex(a => a.Id == animal.Id);
        animals[index] = animal;
        return Ok(animals);
    }
}