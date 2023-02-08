using Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Models.Entities;
using Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Repository;
using Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Services.Interfaces;

namespace Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Services.Implements
{
    public class CategoriasServices : ICategoriasServices
    {
        private readonly CategoriaRepository _repository;

        public CategoriasServices(CategoriaRepository repository)
        {
            _repository = repository;   
        }
        public async Task<IEnumerable<Categoria>> GetAllCategorias()
        {
            return await _repository.GetAll();
        }

        async Task<int> ICategoriasServices.Save(Categoria categoria)
        {
            return await _repository.SaveCategoria(categoria);
        }
    }
}
