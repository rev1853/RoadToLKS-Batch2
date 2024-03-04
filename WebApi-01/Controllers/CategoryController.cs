using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_01.Database;
using WebApi_01.DTOs;

namespace WebApi_01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController(EsemkaStoreContext _context) : ControllerBase
    {
        //EsemkaStoreContext Db { get => _context; }
        EsemkaStoreContext Db = _context;

        [HttpGet]
        public List<Category> All()
        {
            return Db.Categories.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Category> Find(int id)
        {
            Category? category = Db.Categories.Find(id);
            if (category == default) return NotFound(new ErrorDTO
            {
                Message = "Data kategori tidak ketemu"
            });
            return Ok(category);
        }

        [HttpPost]
        public ActionResult<Category> Store(StoreCategoryDTO data)
        {
            Category category = new Category
            {
                Name = data.Name,
                Description = data.Description
            };
            Db.Categories.Add(category);
            Db.SaveChanges();
            return Created("", category);
        }

        [HttpPut("{id}")]
        public ActionResult<Category> Update(int id, StoreCategoryDTO data)
        {
            Category? category = Db.Categories.Find(id);
            if (category == default) return NotFound(new ErrorDTO
            {
                Message = "Data kategori tidak ketemu"
            });

            category.Name = data.Name;
            category.Description = data.Description;

            Db.SaveChanges();

            return Ok(category);
        }

        [HttpDelete("{id}")]
        public ActionResult<Category> Destroy(int id)
        {
            Category? category = Db.Categories.Find(id);
            if (category == default) return NotFound(new ErrorDTO
            {
                Message = "Data kategori tidak ketemu"
            });
            Db.Categories.Remove(category);
            Db.SaveChanges();

            return Ok(category);
        }
    }
}
