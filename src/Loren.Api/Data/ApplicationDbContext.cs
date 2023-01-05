using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Loren.Api.ViewModels;

namespace Loren.Api.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
        public DbSet<Loren.Api.ViewModels.EnderecoViewModel> EnderecoViewModel { get; set; }
        
    }
}
