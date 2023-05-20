using DockerBuild.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
var c = new EmployeeController();
app.MapGet("/api/Employee", () => { 
    var data = c.GetAll(); 
    return Results.Ok(data);
}) ;
app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

app.Run();
