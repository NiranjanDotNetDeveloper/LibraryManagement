using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

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
    public static class ConvertTransactionResponseDTO
    {
     

        public static TransactionResponseDTO ConvertTransactionResponseDTOToTransaction(this LibraryCore.Domain.Entity.Transaction response)
        {
            TransactionResponseDTO transaction = new TransactionResponseDTO();
            transaction.ReturnDate = response.ReturnDate;
            transaction.BorrowDate = response.BorrowDate;
            transaction.FineAmount = response.FineAmount;
            return transaction;
        }
    }
}
