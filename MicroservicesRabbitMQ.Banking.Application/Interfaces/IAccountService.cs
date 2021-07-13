using MicroservicesRabbitMQ.Banking.Application.ViewModels;
using MicroservicesRabbitMQ.Banking.Domain.Models;
using System.Collections.Generic;

namespace MicroservicesRabbitMQ.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();

        Account GetAccountById(int id);

        void Transfer(Transfer transfer);
    }
}
