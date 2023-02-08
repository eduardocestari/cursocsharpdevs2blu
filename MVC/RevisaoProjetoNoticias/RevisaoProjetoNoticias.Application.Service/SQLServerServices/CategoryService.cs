using RevisaoProjetoNoticias.Domain.DTO;
using RevisaoProjetoNoticias.Domain.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoProjetoNoticias.Application.Service.SQLServerServices
{
    public class CategoryService : ICategoryService
    {
        public CategoryService()
        {

        }

        public Task<int> Delete(CategoryDTO entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<CategoryDTO> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDTO> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save(CategoryDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
