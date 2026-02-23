using BlazorApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Components.Data
{
    public class WebAppContext : DbContext
    {
        // Correzione 1: Aggiungi il tipo generico <WebAppContext> alle opzioni
        public WebAppContext(DbContextOptions<WebAppContext> options) : base(options)
        {
        }

        // Correzione 2: Devi dare un NOME alla proprietà (es. Studenti) e renderla PUBLIC
        public DbSet<Studente> Studenti { get; set; } = null!;
    }
}