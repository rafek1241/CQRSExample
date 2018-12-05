﻿using CQRSExample.Domain.Interfaces;
using CQRSExample.Domain.Models;

namespace CQRSExample.Domain.Commands
{
    public class UpdateProduct : ICommand
    {
        public long ProductId { get; set; }
        public Product Product { get; set; }

        public UpdateProduct(long productId, Product product)
        {
            ProductId = productId;
            Product = product;
        }
    }
}
