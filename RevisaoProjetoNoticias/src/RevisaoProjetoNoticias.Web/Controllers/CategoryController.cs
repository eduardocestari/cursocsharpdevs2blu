using RevisaoProjetoNoticias.Domain.IServices;

namespace RevisaoProjetoNoticias.Web.Controllers
{
    public class CategoryController : Controller
    {
            private readonly ILogger<CategoryController> _logger;
            private readonly ICategoryService _service

            public CategoryController(ILogger<CategoryController> logger)
            {
                _logger = logger;
            }

        }
}
