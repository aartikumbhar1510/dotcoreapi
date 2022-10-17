using BricksBizzAPI.Component;
using BricksBizzAPI.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(x => 
{
    x.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin()); 
});

builder.Services.AddScoped<IProductionComponent,ProductionComponent>();
builder.Services.AddScoped<ISalesDashboardRepository, SalesDashboardRepository>();
builder.Services.AddScoped<IPurchaseRepository,PurchaseRepository>();
builder.Services.AddScoped<IWorkerRepository,WorkerRepository>();
builder.Services.AddScoped<IProductionRepository,ProductionRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}

// with a named pociliy
app.UseCors(builder =>
{
    builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
