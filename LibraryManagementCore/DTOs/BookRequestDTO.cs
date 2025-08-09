using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementCore.DTOs
{
    public class BookRequestDTO
    {
            public int BookId { get; set; }
            public string? Title { get; set; }
            public string? Author { get; set; }
            public string? ISBN { get; set; }
            public int? CopiesAvailable { get; set; }
            public int? Price { get; set; }
    }
}
