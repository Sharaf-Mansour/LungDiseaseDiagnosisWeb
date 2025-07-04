global using LungDiseaseDiagnosis.Components;
global using Dapper;
global using LungDiseaseDiagnosis.Models;
global using LungDiseaseDiagnosis.Brokers.Storages;
global using Arora.Blazor.StateContainer;
global using LungDiseaseDiagnosis.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddTransient<IStorageBroker, StorageBroker>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddStateContainer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
