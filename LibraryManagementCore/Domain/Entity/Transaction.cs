using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCore.Domain.Entity
{
    public class Transaction
    {

        [Key]
        public int TransactionId { get; set; }
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public Book? Books { get; set; }

        public int MemberId { get; set; }
        [ForeignKey("MemberId")]
        public Member? Members { get; set; }
        public DateOnly? BorrowDate { get; set; }
        public DateOnly? ReturnDate { get; set; }
        public int? FineAmount { get; set; }
        
    }
}
