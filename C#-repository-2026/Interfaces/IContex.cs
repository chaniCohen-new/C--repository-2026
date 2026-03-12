using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using C__repository_2026.Entities;

namespace C__repository_2026.Interfaces
{
    public interface IContext
    {
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<DetectedCharacter> DetectedCharacters { get; set; }

        public void Save();
    }
}