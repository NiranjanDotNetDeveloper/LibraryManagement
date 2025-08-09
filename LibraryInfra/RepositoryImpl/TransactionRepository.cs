using LibraryCore.Domain.Entity;
using LibraryInfra.SqlConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryInfra.RepositoryImpl
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly DbContextImpl _dbContext;
        public TransactionRepository(DbContextImpl dbContext)
        {
            _dbContext = dbContext;
        }
        public Transaction AddNewTransaction(Transaction transactionRequest)
        {
            Transaction transaction = new Transaction();
            transaction.BorrowDate = transactionRequest.BorrowDate;
            transaction.ReturnDate = transactionRequest.ReturnDate;
            transaction.FineAmount = transactionRequest.FineAmount;
            _dbContext.Transactions.Add(transaction);
            _dbContext.SaveChanges();
            return transaction;
        }

        public Transaction FindTransactionById(int id)
        {
            Transaction transaction = _dbContext.Transactions.FirstOrDefault(x => x.TransactionId == id);
            return transaction;
        }

        public List<Transaction> GetAllTransaction()
        {
            return _dbContext.Transactions.ToList();
        }

        public bool RemoveTransaction(int id)
        {
            Transaction transaction = _dbContext.Transactions.FirstOrDefault(x => x.TransactionId == id);
            if (transaction == null)
                return false;
            else
            {
                _dbContext.Transactions.Remove(transaction);
                _dbContext.SaveChanges();
                return true;
            }
        }

        public Transaction UpdateExistingTransaction(int id,Transaction transactionRequest)
        {
            Transaction transaction = _dbContext.Transactions.FirstOrDefault(x=>x.TransactionId==id);
            transaction.BorrowDate = transactionRequest.BorrowDate;
            transaction.ReturnDate = transactionRequest.ReturnDate;
            transaction.FineAmount = transactionRequest.FineAmount;
            _dbContext.Transactions.Update(transaction);
            _dbContext.SaveChanges();
            return transaction;
        }
    }
}
