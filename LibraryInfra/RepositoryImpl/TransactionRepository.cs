using LibraryCore.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryInfra.RepositoryImpl
{
    public class TransactionRepository : ITransactionRepository
    {
        public Transaction AddNewTransaction(Transaction transactionRequest)
        {
            throw new NotImplementedException();
        }

        public Transaction FindTransactionById()
        {
            throw new NotImplementedException();
        }

        public List<Transaction> GetAllTransaction()
        {
            throw new NotImplementedException();
        }

        public bool RemoveTransaction(int id)
        {
            throw new NotImplementedException();
        }

        public Transaction UpdateExistingTransaction(Transaction transactionRequest)
        {
            throw new NotImplementedException();
        }
    }
}
