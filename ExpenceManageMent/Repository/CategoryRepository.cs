using ExpenceManageMent.Data;
using ExpenceManageMent.Interface;
using ExpenceManageMent.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace ExpenceManageMent.Repository
{
    public class CategoryRepository : IGenericRepository<Category>
    {
        private readonly DataBaseConnection _connection;

        public CategoryRepository(DataBaseConnection connection)
        {
            _connection = connection;
        }

        public async Task<string> AddEntityAsync(Category entity)
        {
            List<Category> entities = new List<Category>();

            entities.Add(new Category
            {
                CategoryName = entity.CategoryName,
                CreateDate = DateTime.Now,
            });
            
            if (entities != null)
            {
                _connection.Category.AddRange(entities);
              await  _connection.SaveChangesAsync();
                 return "Category Save Successfully";
            }
            else
            {
                return "Save Faild";
            }

            

        }

        public Task<bool> DeleteEntity(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Category>> GetAllListAsync()
        {

            var catList= await _connection.Category.ToListAsync();
            return catList;
        }

        public Task<List<Category>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateEntity(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
