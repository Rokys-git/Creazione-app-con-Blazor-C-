using BlazorApp.Models;

namespace BlazorApp.wwwroot.Services.interfaces
{
    public interface IStudentiService
    {
        Task<List<Studente>> GetAllStudentiAsync();
        Task<Studente?> GetStudenteByIdAsync(int id);
        Task AddStudenteAsync(Studente studente);
        Task UpdateStudenteAsync(Studente studente);
        Task DeleteStudenteAsync(int id);
    }
}