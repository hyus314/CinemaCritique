using CinemaCritique.Data;
using Microsoft.EntityFrameworkCore;

public class CritiqueDbContextFactory
{
    private readonly DbContextOptions<CritiqueDbContext> _options;

    public CritiqueDbContextFactory(DbContextOptions<CritiqueDbContext> options)
    {
        _options = options;
    }

    public CritiqueDbContext Create()
    {
        return new CritiqueDbContext(_options);
    }
}
