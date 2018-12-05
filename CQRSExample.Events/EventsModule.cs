using CQRSExample.Domain.Interfaces;
using CQRSExample.Events;
using LightInject;

[assembly: CompositionRootType(typeof(EventsModule))]
namespace CQRSExample.Events
{
    public class EventsModule : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            RegisterEventHandlers(serviceRegistry);
            RegisterAsyncEventHandlers(serviceRegistry);
        }

        public static void RegisterEventHandlers(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.RegisterAssembly(typeof(EventsModule).Assembly,
                (s, _) => s.IsGenericType && s.GetGenericTypeDefinition() == typeof(IEventHandler<>));
        }

        public static void RegisterAsyncEventHandlers(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.RegisterAssembly(typeof(EventsModule).Assembly,
                (s, _) => s.IsGenericType && s.GetGenericTypeDefinition() == typeof(IAsyncEventHandler<>));
        }
    }
}
