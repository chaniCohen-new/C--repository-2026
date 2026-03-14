using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__repository_2026.Entities
{
    public class Character
    {
        public int Id { get; set; }
        public string CharacterName { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

        // Relationship
        public virtual ICollection<DetectedCharacter> DetectedCharacters { get; set; }
    }
}
