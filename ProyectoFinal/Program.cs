using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ProyectoFinal.Context;
using ProyectoFinal.Context.Repositorio;
using ProyectoFinal.Context.Repositorios;
using ProyectoFinal.Controllers;

var builder = WebApplication.CreateBuilder(args);
var MyCors = "MyCors";



// Add services to the container.

builder.Services.AddControllers();

/*================================================*/
/*Esto lo agregue yo*/
builder.Services.AddCors(option => option.AddPolicy(MyCors, builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));
/*================================================*/

builder.Services.AddDbContext<ApplicationDbContext>(
        options => options.UseSqlServer(builder.Configuration.GetConnectionString("Conexion")));

///////////////////////////////////////////////////////////

builder.Services.AddScoped<FormaPagoRepositorio>();
builder.Services.AddScoped<FormaPagoServicio>();

builder.Services.AddScoped<CondicionRepositorio>();
builder.Services.AddScoped<CondicionServicio>();

builder.Services.AddScoped<TipoInmuebleRepositorio>();
builder.Services.AddScoped<TipoInmuebleServicio>();

builder.Services.AddScoped<InmuebleRepositorio>();
builder.Services.AddScoped<InmuebleServicio>();

builder.Services.AddScoped<VentaRepositorio>();
builder.Services.AddScoped<VentaServicio>();

builder.Services.AddScoped<ClienteRepositorio>();
builder.Services.AddScoped<ClienteServicio>();

////////////////////////////////////////////////////////////


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

/*=====================================*/
/*ESTO TAMBIEN LO AGREGUE YO*/
app.UseCors(MyCors);
/*====================================================*/
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
