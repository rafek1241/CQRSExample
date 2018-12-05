using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using CQRSExample.Domain.Commands;
using CQRSExample.Domain.Interfaces;
using CQRSExample.Domain.Models;
using CQRSExample.Queries.Interface;

namespace CQRSExample.Controllers.ApiControllers
{
    [RoutePrefix("api/product")]
    public class ProductController : ApiController
    {
        private readonly IProductQuery _productQuery;
        private readonly ICommandBus _commandBus;

        public ProductController(IProductQuery query, ICommandBus commandBus)
        {
            _productQuery = query;
            _commandBus = commandBus;
        }

        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns>Collection of products</returns>
        public async Task<IEnumerable<Product>> Get()
        {
            return await _productQuery.GetProducts();
        }

        public async Task<IHttpActionResult> Get(long id)
        {
            var product = await _productQuery.GetProduct(id);

            return Ok(product);
        }

        /// <summary>
        /// Get product with specified id.
        /// </summary>
        /// <param name="id">Guid ID of product to find</param>
        /// <returns>Http response with product</returns>
        [HttpGet]
        [Route("{guid}")]
        public async Task<IHttpActionResult> Get(Guid guid)
        {
            var product = await _productQuery.GetProduct(guid);

            return Ok(product);
        }

        // POST api/values
        [HttpPost]
        public async Task<IHttpActionResult> PostAsync([FromBody]CreateProduct command)
        {
            try
            {
                await _commandBus.SendAsync(command);

                return ResponseMessage(Request.CreateResponse(HttpStatusCode.Created, command.Product.Guid));
            }
            catch (Exception error)
            {
                return InternalServerError(error);
            }
        }

        // PUT api/values/5
        public async Task<IHttpActionResult> Put([FromBody]UpdateProduct command)
        {
            try
            {
                await _commandBus.SendAsync(command);

                return ResponseMessage(Request.CreateResponse(HttpStatusCode.Created, command.Product));
            }
            catch (Exception error)
            {
                return InternalServerError(error);
            }
        }

        // DELETE api/values/5
        public async Task<IHttpActionResult> Delete(long id)
        {
            await _commandBus.SendAsync(new RemoveProduct(id));
            return Ok();
        }
    }
}
