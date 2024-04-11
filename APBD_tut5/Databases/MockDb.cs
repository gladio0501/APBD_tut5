namespace APBD_tut5.Models;

public class MockDb
{
    public List<Animal> Animals { get; set; }

    public MockDb()
    {
        Animals = new List<Animal>
        {
            new Animal 
            { 
                Id = 1, 
                Name = "Bella", 
                Type = "Dog",  
                Weight = 30, 
                FurColor = 1,
                visits = new List<Visit>
                {
                    new Visit { Id = 1, Date = DateTime.Now.AddDays(-10), AnimalId = 1, Price = 50 },
                    new Visit { Id = 2, Date = DateTime.Now.AddDays(-5), AnimalId = 1, Price = 75 }
                }
            },
            new Animal 
            { 
                Id = 2, 
                Name = "Lucy", 
                Type = "Cat",  
                Weight = 10, 
                FurColor = 2,
                visits = new List<Visit>
                {
                    new Visit { Id = 3, Date = DateTime.Now.AddDays(-3), AnimalId = 2, Price = 60 }
                }
            },
            new Animal 
            { 
                Id = 3, 
                Name = "Max", 
                Type = "Dog",  
                Weight = 40, 
                FurColor = 3,
                visits = new List<Visit>
                {
                    new Visit { Id = 4, Date = DateTime.Now.AddDays(-1), AnimalId = 3, Price = 80 }
                }
            }
        };
    }
}