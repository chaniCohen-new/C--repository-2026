using C__repository_2026.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IContext
    {
        DbSet<Character> Characters { get; set; }
        DbSet<Image> Images { get; set; }
        DbSet<DetectedCharacter> DetectedCharacters { get; set; }

        Task<int> SaveChangesAsync(); // שמירה א-סינכרונית
    }
}