using Revisao.Domain.Interfaces;
using Revisao.Application.Interfaces;
using Revisao.Application.Services;
using Revisao.Data.Repositories;
using Revisao.Application.AutoMapper;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region configuração injecoes
builder.Services.AddScoped<IJogoRepository, JogoRepository>();
////             Interface e sua implementação
///              o que é feito aqui? ele instancia JogoRepository e envia a instancia para a camada usar
///              JogoRepository jogoReposito = NewJogoRepository();
builder.Services.AddScoped<IJogoService, JogoService>();

builder.Services.AddAutoMapper(typeof(DomainToApplication), typeof(ApplicationToDomain));

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
