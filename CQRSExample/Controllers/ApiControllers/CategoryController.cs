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
    [RoutePrefix("api/category")]
    public class CategoryController : ApiController
    {
        private readonly ICategoryQuery _categoryQuery;
        private readonly ICommandBus _commandBus;

        public CategoryController(ICategoryQuery categoryQuery, ICommandBus commandBus)
        {
            _categoryQuery = categoryQuery;
            _commandBus = commandBus;
        }

        // GET api/<controller>
        public async Task<IHttpActionResult> Get()
        {
            var categories = await _categoryQuery.GetCategories();

            return Ok(categories);
        }

        public async Task<IHttpActionResult> Get(long id)
        {
            var category = await _categoryQuery.GetCategory(id);

            return Ok(category);
        }

        [HttpGet]
        [Route("{guid}")]
        public async Task<IHttpActionResult> Get(Guid guid)
        {
            var category = await _categoryQuery.GetCategory(guid);

            return Ok(category);
        }

        // POST api/<controller>
        public async Task<IHttpActionResult> Post([FromBody]CreateCategory value)
        {
            try
            {
                await _commandBus.SendAsync(value);

                return ResponseMessage(Request.CreateResponse(HttpStatusCode.Created, value.Category.Guid));
            }
            catch (Exception error)
            {
                return InternalServerError(error);
            }
        }

        // PUT api/<controller>/5
        public async Task<IHttpActionResult> Put(long id, [FromBody]UpdateCategory value)
        {
            try
            {
                value.Id = id;

                await _commandBus.SendAsync(value);

                return Ok(value.Category);
            }
            catch (Exception error)
            {
                return InternalServerError(error);
            }
        }

        // DELETE api/<controller>/5
        public async Task Delete(long id)
        {
            var command = new RemoveCategory(id);
            await _commandBus.SendAsync(command);
        }
    }
}