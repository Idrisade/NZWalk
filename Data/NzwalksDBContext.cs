using Microsoft.EntityFrameworkCore;
using webtest.Models.Domains;

namespace webtest.Data
{
    public class NzwalksDBContext: DbContext 
    {
        public NzwalksDBContext(DbContextOptions<NzwalksDBContext> options) : base(options) 
        {
        
        }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }  
        public DbSet<Walkdifficulty> walkdifficulty { get; set; }   
         
    }
}
