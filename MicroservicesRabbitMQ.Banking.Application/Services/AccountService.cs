using MicroservicesRabbitMQ.Banking.Application.Interfaces;
using MicroservicesRabbitMQ.Banking.Application.ViewModels;
using MicroservicesRabbitMQ.Banking.Domain.Commands;
using MicroservicesRabbitMQ.Banking.Domain.Interfaces;
using MicroservicesRabbitMQ.Banking.Domain.Models;
using MicroservicesRabbitMQ.Domain.Core.Bus;
using System.Collections.Generic;

namespace MicroservicesRabbitMQ.Banking.Application.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _eventBus;

        public AccountService(IAccountRepository accountRepository, IEventBus eventBus)
        {
            _accountRepository = accountRepository;
            _eventBus = eventBus;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void Transfer(Transfer transfer)
        {
            _eventBus.SendCommand(new CreateTransferCommand(transfer.FromAccount, transfer.ToAccount, transfer.Value));
        }
    }
}
