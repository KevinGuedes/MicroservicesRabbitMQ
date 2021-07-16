using MicroservicesRabbitMQ.Banking.Domain.Interfaces;
using MicroservicesRabbitMQ.Banking.Domain.Models;
using MicroservicesRabbitMQ.Banking.Infra.Data.Context;
using System.Collections.Generic;

namespace MicroservicesRabbitMQ.Banking.Infra.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingDbContext _bankingDbContext;

        public AccountRepository(BankingDbContext bankingDbContext)
        {
            _bankingDbContext = bankingDbContext;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _bankingDbContext.Accounts;
        }

        public Account GetAccountById(int id)
        {
            return _bankingDbContext.Accounts.Find(id);
        }
    }
}
