using ConferencePlanner.Database;
using ConferencePlanner.Database.Queries;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Configuring DB Context
builder.Services.AddDbContext<ApplicationDBContext>(
    options => options.UseSqlite("Data Source=coferences.db"));

//Configuring GraphQL
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

// /ui/playground
app.UseGraphQLPlayground();

app.UseRouting();

app.UseAuthorization();

//Configuring GraphQL
app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});

app.Run();
