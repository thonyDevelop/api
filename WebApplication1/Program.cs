using api.Data;
using api.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// configurando acceso a la base de datos}
Console.WriteLine(" EJECUTAAAAAAAAAA" +builder.Configuration.GetConnectionString("PostgresSQLConnection"));
var postgreSQLConnectionConfiguration = new PostgresSQLConfiguration(builder.Configuration.GetConnectionString("PostgresSQLConnection")!);
builder.Services.AddSingleton(postgreSQLConnectionConfiguration);
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IDamageRepository, DamageRepository>();


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
