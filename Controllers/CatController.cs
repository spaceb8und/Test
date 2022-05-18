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
    public class CatController : ControllerBase
    {
        

        private readonly ILogger<CatController> _logger;

        public CatController(ILogger<CatController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name="GetCats")]
        public IEnumerable<Cat> Get()
        {
            Cat[] cats =
            {
                new Cat()
                {
                    Name = "Garfield", Type = "Ryzhik", Birthday = "10.01.2003"

                },
                new Cat()
                {
                    Name = "Murzik", Type = "Chernysh", Birthday = "18.02.2008"
                },
            
                new Cat()
                {
                    Name = "Barsik", Type = "Dvornyaga", Birthday = "14.02.2013"
                },
                new Cat()
                {
                    Name = "Alice", Type = "British", Birthday = "24.02.2013"
                }

            };
            return cats;
        }
        
    }
}
