﻿using System.Threading.Tasks;
using CQRSExample.Domain.Events;
using CQRSExample.Domain.Interfaces;

namespace CQRSExample.Events.Events
{
    public class SavedProductHandler : EventHandler<SavedProduct>
    {
        public SavedProductHandler(IEventBus eventBus) : base(eventBus)
        {
        }

        public override void Handle(SavedProduct @event)
        {
            //The end of sync insert event

            return;
        }

        public override Task HandleAsync(SavedProduct @event)
        {
            //The end of async insert event

            return Task.CompletedTask;
        }
    }
}
