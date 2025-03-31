namespace FitBitesLibrary.Infraestructure.Data;

using Microsoft.EntityFrameworkCore;
public class FBContext(DbContextOptions<FBContext> options) : DbContext(options) {
    public DbSet<User> Users { get; set; }
    public DbSet<Recipe> Recipes { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Recipe>()
            .HasOne(r => r.User)
            .WithMany(u => u.Recipes)
            .HasForeignKey(r => r.UserId);
        ;

        base.OnModelCreating(modelBuilder);
    }

}
