using LibraryInfra.RepositoryImpl;
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
        private readonly ITransactionRepository transactionRepository;
        public TransactionService(ITransactionRepository transactionRepository)
        {
            this.transactionRepository=transactionRepository;
        }
        public TransactionResponseDTO AddNewTransaction(TransactionRequestDTO transactionRequest)
        {
            var response = transactionRepository.AddNewTransaction(transactionRequest.ConvertTransactionRequestDTOToTransaction());
            return response.ConvertTransactionResponseDTOToTransaction();
        }

        public TransactionResponseDTO FindTransactionById(int id)
        {
           var response =  transactionRepository.FindTransactionById(id);
            return response.ConvertTransactionResponseDTOToTransaction();
        }

        public List<TransactionResponseDTO> GetAllTransaction()
        {
            var response = transactionRepository.GetAllTransaction();
            return response.Select(x => x.ConvertTransactionResponseDTOToTransaction()).ToList();
        }

        public bool RemoveTransaction(int id)
        {
          return transactionRepository.RemoveTransaction(id);
        }

        public TransactionResponseDTO UpdateExistingTransaction(int id, TransactionRequestDTO transactionRequest)
        {
            var response = transactionRepository.UpdateExistingTransaction(id, transactionRequest.ConvertTransactionRequestDTOToTransaction());
            return response.ConvertTransactionResponseDTOToTransaction();
        }
    }
}
