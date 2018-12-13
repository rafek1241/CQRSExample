using System.Threading.Tasks;

namespace CQRSExample.Domain.Interfaces
{
    public interface ICommandBus
    {
        void Send<TCommand>(TCommand command) where TCommand : ICommand;
        Task SendAsync<TCommand>(TCommand command) where TCommand : ICommand;
    }
}