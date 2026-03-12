using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__repository_2026.Entities
{
    internal class Image
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public DateTime UploadDate { get; set; }
        public string FileSize { get; set; }

        // Foreign Key
        public virtual ICollection<DetectedCharacter> DetectedCharacters { get; set; }

       
    }
}
