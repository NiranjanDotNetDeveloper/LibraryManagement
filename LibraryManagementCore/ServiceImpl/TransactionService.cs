using LibraryManagementCore.DTOs;
using LibraryManagementCore.ServiceInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementCore.ServiceImpl
{
    public class TransactionService : ITransactionService
    {
        public TransactionResponseDTO AddNewTransaction(TransactionRequestDTO transactionRequest)
        {
            throw new NotImplementedException();
        }

        public TransactionResponseDTO FindTransactionById(int id)
        {
            throw new NotImplementedException();
        }

        public List<TransactionResponseDTO> GetAllTransaction()
        {
            throw new NotImplementedException();
        }

        public bool RemoveTransaction(int id)
        {
            throw new NotImplementedException();
        }

        public TransactionResponseDTO UpdateExistingTransaction(TransactionRequestDTO transactionRequest)
        {
            throw new NotImplementedException();
        }
    }
}
