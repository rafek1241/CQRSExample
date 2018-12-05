using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using CQRSExample.Domain.Models;
using CQRSExample.Queries.Interface;

namespace CQRSExample.Controllers.ApiControllers
{
    [RoutePrefix("api/category")]
    public class CategoryController : ApiController
    {
        private readonly ICategoryQuery _categoryQuery;

        public CategoryController(ICategoryQuery categoryQuery)
        {
            _categoryQuery = categoryQuery;
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
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}