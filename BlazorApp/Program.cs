using BlazorApp.Components;
using BlazorApp.Components.Data;
using Microsoft.EntityFrameworkCore;
using BlazorApp.Services.Repositories; // Aggiungi questo using
using BlazorApp.wwwroot.Services.interfaces; // Aggiungi questo using (o correggi il percorso se è sbagliato)

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Registra il DbContext
builder.Services.AddDbContext<WebAppContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("strinConnection")));

// Aggiungi la registrazione del Servizio Studenti
builder.Services.AddScoped<IStudentiService, StudentiService>(); // <--- QUESTA È LA RIGA FONDAMENTALE

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see aka.ms.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
