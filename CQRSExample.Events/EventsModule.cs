using CQRSExample.Domain.Interfaces;
using CQRSExample.Domain.Models;
using CQRSExample.Events;
using CQRSExample.Events.Validators;
using FluentValidation;
using LightInject;

[assembly: CompositionRootType(typeof(EventsModule))]

namespace CQRSExample.Events
{
    public class EventsModule : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            RegisterValidators(serviceRegistry);
            RegisterEventHandlers(serviceRegistry);
            RegisterAsyncEventHandlers(serviceRegistry);
        }

        private static void RegisterValidators(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.Register<IValidator<Category>, CategoryValidator>();
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