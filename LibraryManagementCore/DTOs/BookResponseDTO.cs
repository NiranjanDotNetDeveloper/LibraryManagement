using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementCore.DTOs
{
    public class BookResponseDTO
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? ISBN { get; set; }
        public int? CopiesAvailable { get; set; }
        public int? Price { get; set; }
    }
}
