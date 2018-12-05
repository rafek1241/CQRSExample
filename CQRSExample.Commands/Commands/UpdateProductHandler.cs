using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRSExample.Domain.Commands;
using CQRSExample.Domain.Interfaces;

namespace CQRSExample.Commands.Commands
{
    public class UpdateProductHandler : CommandHandler<UpdateProduct>
    {
        public UpdateProductHandler(IEventBus eventBus) : base(eventBus)
        {
        }

        public override void Handle(UpdateProduct command)
        {
            throw new NotImplementedException();
        }

        public override Task HandleAsync(UpdateProduct command)
        {
            throw new NotImplementedException();
        }
    }
}
