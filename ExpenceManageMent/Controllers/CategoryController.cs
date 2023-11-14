using ExpenceManageMent.Interface;
using ExpenceManageMent.Models;
using ExpenceManageMent.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExpenceManageMent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly IGenericRepository<Category> _repository;

        public CategoryController(IGenericRepository<Category> repository)
        {
            _repository = repository;
        }
       
        [HttpGet]
        public async Task<ActionResult<List<Category>>> CategoryList()
        {
            try
            {
                var list = await _repository.GetAllListAsync();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return BadRequest ( ex.Message);
            }
          
        }
        [HttpPost]

        public async Task<ActionResult> CategoryCreate(Category model)
        {
           string result=await _repository.AddEntityAsync(model);

            return CreatedAtAction("CategoryList", new { id = model.CategoryId }, result);
        }



    }
}
