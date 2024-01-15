using pie_store.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();
builder.Services.AddScoped<IPieRepository, MockPieRepository>();

builder.Services.AddControllersWithViews();

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapDefaultControllerRoute();

app.MapGet("/", () => "Hello World!");

app.Run();
