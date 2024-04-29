using CRTDataAccess.DTO.Admin;
using Microsoft.EntityFrameworkCore;

namespace CRTDataAccess.DBContext
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options){ }
        public DbSet<CategoryDTO> Categories { get; set; }        
    }
}
