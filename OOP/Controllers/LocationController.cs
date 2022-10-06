using Microsoft.AspNetCore.Mvc;
using OOP.Context;
using OOP.DTOs;
using OOP.DTOs.Extensions;
using OOP.Models;

namespace OOP.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocationController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public LocationController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IEnumerable<LocationDto> Get()
        {
            return _dbContext.Locations.Select(x => x.Map());
        }


        [HttpGet("{id}")]
        public LocationDto? Get([FromRoute] int id)
        {

            return _dbContext.Locations.Find(id)?.Map();
        }

        [HttpPost]
        public IActionResult Post([FromBody] LocationCreateEditDto dto)
        {

            _dbContext.Locations.Add(dto.Map());
            _dbContext.SaveChanges();

            return Ok();
        }

        private void UseShowCase()
        {

            Latitude latitude1 = new Latitude(40); // Constructor
            Latitude latitude2 = (Latitude)40;     // Explicit operator
            float latitude3 = latitude1;           // Implicit operator 
        }
    }
}