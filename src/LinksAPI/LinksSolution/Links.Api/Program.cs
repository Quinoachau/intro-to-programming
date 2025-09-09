using Marten;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("links")
    ?? throw new Exception("You Need a Connection String!");
builder.Services.AddMarten(config =>
{
    config.Connection(connectionString);

});

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.Run(); //This is where the API will be up and running listening for requests,
           //but this is basically a while(true) {...} loop that runs forever

// need to make this "Program" class visible to my tests
public partial class Program;
