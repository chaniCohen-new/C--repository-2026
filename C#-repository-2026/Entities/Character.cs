//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C__repository_2026.Entities
//{
//    public class Character
//    {
//        public int Id { get; set; }
//        public string CharacterName { get; set; }
//        public string Description { get; set; }
//        public DateTime CreatedDate { get; set; }

//        // Relationship
//        public virtual ICollection<DetectedCharacter> DetectedCharacters { get; set; }
//    }
//}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace C__repository_2026.Entities
{
    public class Character
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "שם דמות הוא שדה חובה")]
        [MaxLength(100, ErrorMessage = "שם דמות לא יכול להכיל יותר מ-100 תווים")]
        public string CharacterName { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        // Relationship
        public virtual ICollection<DetectedCharacter> DetectedCharacters { get; set; }
    }
}