using Bridal.Core.Repositories;
using Bridal.Core.Services;
using Bridal.Data;
using Bridal.Data.Repositories;
using Bridal.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IBridalRepository, BridalRepository>();
builder.Services.AddScoped<IBridalServices, BridalServices>();
builder.Services.AddScoped<IDressmakerRepository, DressmakerRepository>();
builder.Services.AddScoped<IDressmakerServices, DressmakerServices>();
builder.Services.AddScoped<IQueueBridalRepository, QueueBridalRepository>();
builder.Services.AddScoped<IQueueBridalServices, QueueBridalServices>();
builder.Services.AddDbContext<DataContextBase >();
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
