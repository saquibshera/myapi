using webapidubaidemos.Data;
using webapidubaidemos.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient<DataContext>();
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
app.MapGet("/", () =>

    "hello world"
);
app.MapGet("getemployee", (DataContext dt) => dt.getempoyees());
app.MapPost("sendemployee", (Employee emp, DataContext dt) => dt.addemp(emp));
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
