using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace LibraryManagementCore.DTOs
{
    public class TransactionRequestDTO
    {
            public int TransactionId { get; set; }
            public int BookId { get; set; }
            public int MemberId { get; set; }
            public DateOnly? BorrowDate { get; set; }
            public DateOnly? ReturnDate { get; set; }
            public int? FineAmount { get; set; }
    }
    public static class ConvertTransactionRequestDTO
    {
        public static LibraryCore.Domain.Entity.Transaction ConvertTransactionRequestDTOToTransaction(this TransactionRequestDTO request)
        {
            LibraryCore.Domain.Entity.Transaction transaction = new LibraryCore.Domain.Entity.Transaction();
            transaction.TransactionId = request.TransactionId;
            transaction.ReturnDate = request.ReturnDate;
            transaction.BorrowDate = request.BorrowDate;
            transaction.FineAmount = request.FineAmount;
            return transaction;
        }
    }
}
