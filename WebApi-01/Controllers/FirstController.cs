using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_01.Database;
using WebApi_01.DTOs;

namespace WebApi_01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirstController(EsemkaStoreContext _context) : ControllerBase
    {
        EsemkaStoreContext Db { get => _context; }

        [HttpGet("Name/{id}")]
        public string GetName(int id, string nama)
        {
            Product? product = Db.Products.Find(id);
            return $"Namamu adalah {nama}, ID mu adalah {id}, Product: {product.Name}";
        }

        [HttpPost]
        public ResponseDTO PostName(NameDTO data)
        {
            return new ResponseDTO
            {
                Data = $"{data.Name} berumur {data.Age}, Random ID: {Guid.NewGuid()}"
            };  
        }


        [HttpGet]
        public List<Product> GetProduct()
        {
            return Db.Products.ToList();
        }
    }
}
