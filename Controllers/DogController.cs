using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DogController : ControllerBase
    {
       

        private readonly ILogger<DogController> _logger;

        public DogController(ILogger<DogController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name="GetDogs")]
        public IEnumerable<Dog> Get()
        {
            Dog[] dogs =
            {
                new Dog()
                {
                    Name = "Alex", Type = "Ovcharka", Birthday = "30.01.2001"

                },
                new Dog()
                {
                    Name = "Pasha", Type = "Pudel", Birthday = "18.01.2005"
                },
            
                new Dog()
                {
                    Name = "Makar", Type = "Bolonka", Birthday = "20.02.2010"
                },
                new Dog()
                {
                    Name = "Dima", Type = "Dober", Birthday = "21.02.2011"
                }
                    
            };
            return dogs;
        }
        
    }
}
