using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace BlazorApp.Components.Data;



public class WebAppDbContextFactory : IDesignTimeDbContextFactory<WebAppContext>
{
    public WebAppContext CreateDbContext(string[] args)
    {
        var opstionsBuilder = new DbContextOptionsBuilder<WebAppContext>();
        opstionsBuilder.UseSqlServer("Data Source=MSI\\SQLEXPRESS;Initial Catalog=_db_studenti;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
        return new WebAppContext(opstionsBuilder.Options);
    }
}
