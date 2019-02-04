using System.Collections.Generic;
using System.Linq;
using DAL;
using DAL.Generators;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserGeneratorController : ControllerBase
    {
        private UserDBContext _dbContext;

        public UserGeneratorController(UserDBContext context)
        {
            _dbContext = context;
        }

        [HttpGet]
        public IActionResult SeedData()
        {
            var res = new List<string>();

            if (!_dbContext.Users.Any())
            {
                var count = UserGenerator.GenerateUsers(_dbContext);
                res.Add($"{count} User have been seeded.");
            }

            if (res.Count == 0)
            {
                res.Add("Nothing has been seeded.");
            }

            return Ok(res);
        }
    }
}
