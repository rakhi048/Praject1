using Microsoft.EntityFrameworkCore;
public class ProductMgmtDbContext:DbContext
{
    public ProductMgmtDbContext(DbContextOptions<ProductMgmtDbContext> options):base(options)
    {
        
    }
    public DbSet<Customer>  customers{get;set;}
}
