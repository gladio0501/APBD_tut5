using APBD_tut5.Endpoints;
using APBD_tut5.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddSingleton<MockDb>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Minimal API
app.MapAnimalEndpoints();

// Controllers
app.MapControllers();

app.Run();

// Create a REST API application that will allow us to manage animal data in adatabase for a veterinary clinic shelter.
// An animal is described by:We would like to have the ability to:Furthermore, we would like to record information about the animal's visits:
// A visit includes the following information:id,name,category (e.g., dog, cat, etc.)weight,fur color.
// 1. retrieve a list of animals
// 2. retrieve a specific animal by id
// 3. add an animal
// 4. edit an animal
// 5. delete an animal
// 1. we would like to be able to retrieve a list of visits associated with a given animal
// 2. we would like to be able to add new visits
// visits should include the following information:
// date of visit animal description of the visit price of the visit
// 1. Prepare an application with a REST API with appropriate HTTPendpoints - GET, POST, PUT, DELETE.
// 2. Make sure that the structure of the endpoints is consistent with theprinciples of REST endpoint design.
// 3. Use a static collection with objects as the database.
// 4. You can use either the MinimalAPI approach or a version of the APIusing controller classes.
// 5. Test the prepared application with Postman.
