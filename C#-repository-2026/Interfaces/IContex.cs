using C__repository_2026.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C__repository_2026.Interfaces
{
    public interface IContext
    {
        DbSet<Character> Characters { get; set; }
        DbSet<DetectedCharacter> DetectedCharacters { get; set; }
        DbSet<Gallery> Galleries { get; set; }
        DbSet<Image> Images { get; set; }

        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}