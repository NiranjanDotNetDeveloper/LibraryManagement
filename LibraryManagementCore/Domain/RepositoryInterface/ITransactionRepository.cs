using LibraryCore.Domain.Entity;
using LibraryManagementCore.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryInfra.RepositoryImpl
{
    public interface ITransactionRepository
    {
        List<Transaction> GetAllTransaction();
        Transaction AddNewTransaction(Transaction transactionRequest);
        Transaction UpdateExistingTransaction(int id,Transaction transactionRequest);
        bool RemoveTransaction(int id);
        Transaction FindTransactionById(int id);
    }
}
