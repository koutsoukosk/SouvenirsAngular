using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;
using SouvenirsWithAngular.Data;
using SouvenirsWithAngular.Models;
using SouvenirsWithAngular.Models.Domain;

namespace SouvenirsWithAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //(ISouvenirService service)
    public class SouvenirsController : ControllerBase
    {
        private readonly AppDbContext appDbContext;
        public SouvenirsController(AppDbContext dbContext)
        {
             this.appDbContext=dbContext;  
        }
        [HttpGet]
        public IActionResult GetAllSouvenirs() { 
            var souvenirs= appDbContext.Souvenirs.ToList();

            return Ok(souvenirs);
        }
        //[HttpGet]
        //public async Task<ActionResult<List<SouvenirResponse>>> GetSouvenirs() => await Task.FromResult(Ok(await service.GetAllSouvenirsAsync()));
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Souvenir>> GetSouvenir(int id)
        //{
        //    var souvenir = await service.GetSouvenirByIdAsync(id);
        //    return souvenir is null ? NotFound("Souvenir with this id has not been found.") : Ok(souvenir);
        //}
        [HttpPost]
        public IActionResult AddSouvenir(AddSouvenirRequestDTO souvenir)
        {
            //var createdSouvenir = await service.AddSouvenirAsync(souvenir);
            //return CreatedAtAction(nameof(AddSouvenir), new { id = createdSouvenir.Id }, createdSouvenir);
            var souvenirModel = new Souvenir {
                //Id=souvenir.Id,
                SouvenirName=souvenir.SouvenirName,
                CountryOfOrigin=souvenir.CountryOfOrigin,   
                Quantity=souvenir.Quantity,
                FriendID=souvenir.FriendID,
                Comment=souvenir.Comment
            };
            appDbContext.Souvenirs.Add(souvenirModel);
            appDbContext.SaveChanges();
            return Ok(souvenirModel);
        }
    }
}
