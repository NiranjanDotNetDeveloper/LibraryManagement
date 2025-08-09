using LibraryManagementCore.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementCore.ServiceInterface
{
    public interface ITransactionService
    {
        List<TransactionResponseDTO> GetAllTransaction();
        TransactionResponseDTO AddNewTransaction(TransactionRequestDTO transactionRequest);
        TransactionResponseDTO UpdateExistingTransaction(TransactionRequestDTO transactionRequest);
        bool RemoveTransaction(int id);
        TransactionResponseDTO FindTransactionById(int id);
    }
}
