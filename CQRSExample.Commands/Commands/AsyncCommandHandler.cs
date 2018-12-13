using System;
using CQRSExample.Domain.Interfaces;

namespace CQRSExample.Commands.Commands
{
    public abstract class AsyncCommandHandler<T> : CommandHandler<T> where T : ICommand
    {
        protected AsyncCommandHandler(IEventBus eventBus) : base(eventBus)
        {
        }

        public sealed override void Handle(T command)
        {
            throw new NotSupportedException();
        }
    }
}
