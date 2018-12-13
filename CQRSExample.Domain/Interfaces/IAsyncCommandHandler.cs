using System.Threading.Tasks;

namespace CQRSExample.Domain.Interfaces
{
    public interface IAsyncCommandHandler<TCommand> where TCommand : ICommand
    {
        Task HandleAsync(TCommand command);
    }
}