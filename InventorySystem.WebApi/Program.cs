using InventorySystem.UseCases.Inventories;
using InventorySystem.UseCases.Inventories.PluginInterfaces;
using InventorySystem.Plugins.Inventories;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IInventoryRepository,InventoryRepository>();

builder.Services.AddTransient<IViewInventoryUseCase,ViewInventoryUseCase>();
builder.Services.AddTransient<IAddInventoryUseCase,AddInventoryUseCase>();
builder.Services.AddTransient<IUpdateInventoryUseCase,UpdateInventoryUseCase>();





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
