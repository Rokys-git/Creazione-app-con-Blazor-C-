using BlazorApp.Components.Data;
using BlazorApp.Models;
using BlazorApp.wwwroot.Services.interfaces;
using BlazorApp.Components.Data;
using BlazorApp.Models;
using BlazorApp.wwwroot.Services.interfaces;
using Microsoft.EntityFrameworkCore;
using BlazorApp.Services.Repositories;
using BlazorApp.Components.Pages.ListaStudenti;


namespace BlazorApp.Services.Repositories
{
    public class StudentiService : IStudentiService
    {
        private readonly WebAppContext _context;


        public StudentiService(WebAppContext context)
        {
            _context = context;
        }

        public async Task AddStudenteAsync(Studente studente)
        {
            await _context.Studenti.AddAsync(studente);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteStudenteAsync(int id)
        {
            Studente? studente = await _context.Studenti.FindAsync(id);
            if (studente != null)
            {
                _context.Studenti.Remove(studente);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Studente>> GetAllStudentiAsync() => await _context.Studenti.ToListAsync();

        public async Task<Studente?> GetStudenteByIdAsync(int id) => await _context.Studenti.FirstOrDefaultAsync(s => s.id == id);

        // Esercizio per domani: implementare UpdateStudenteAsync
        public Task UpdateStudenteAsync(Studente studente)
        {
            throw new NotImplementedException();
        }
    }
}