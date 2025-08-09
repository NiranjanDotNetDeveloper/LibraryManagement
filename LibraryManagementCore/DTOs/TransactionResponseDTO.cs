using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementCore.DTOs
{
    public class TransactionResponseDTO
    {
        public int BookId { get; set; }
        public int MemberId { get; set; }
        public DateOnly? BorrowDate { get; set; }
        public DateOnly? ReturnDate { get; set; }
        public int? FineAmount { get; set; }
    }
}
