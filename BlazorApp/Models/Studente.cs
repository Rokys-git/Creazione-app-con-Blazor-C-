using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Models
{
    public class Studente 
    {
            public int id { get; set; }
            public string Nome { get; set; } = string.Empty;
            [Required()]
            public string cognome { get; set; } = string.Empty;
            [Required]
            public int eta { get; set; }
            public DateTime DataDiNascita { get; set; }
            public string Doc { get; set;}
            
        }
}
