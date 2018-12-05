using CQRSExample.Domain.Events.ProductEvents;
using CQRSExample.Domain.Interfaces;
using CQRSExample.Events;
using CQRSExample.Events.Events;
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
            serviceRegistry.Register<IEventHandler<InsertProduct>, InsertProductHandler>();
            serviceRegistry.Register<IEventHandler<SavedProduct>, SavedProductHandler>();
        }

        public static void RegisterAsyncEventHandlers(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.Register<IAsyncEventHandler<InsertProduct>, InsertProductHandler>();
            serviceRegistry.Register<IAsyncEventHandler<SavedProduct>, SavedProductHandler>();
        }
    }
}
