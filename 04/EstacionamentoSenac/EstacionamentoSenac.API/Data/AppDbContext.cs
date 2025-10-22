using EstacionamentoSenac.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EstacionamentoSenac.API.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<Veiculo> Veiculo { get; set; }
    }
}
