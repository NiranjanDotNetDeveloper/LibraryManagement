using LibraryCore.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
            public Book Books { get; set; }
            public int MemberId { get; set; }
            public Member Members { get; set; }
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
            transaction.BookId = request.BookId;
            transaction.Books = request.Books;
            transaction.MemberId = request.MemberId;
            transaction.Members = request.Members;
            transaction.ReturnDate = request.ReturnDate;
            transaction.BorrowDate = request.BorrowDate;
            transaction.FineAmount = request.FineAmount;
            return transaction;
        }
    }
}
