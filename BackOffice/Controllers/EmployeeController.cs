using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BackOffice.Model;
using BackOffice.DBContext;
using Microsoft.EntityFrameworkCore;

namespace BackOffice.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly BackOfficeDBContext DBContext;

        public EmployeeController(BackOfficeDBContext dBContext)
        {
            DBContext = dBContext;
        }

        public async Task<ActionResult<IEnumerable<Employee>>> Get()
        {
            // var employee = await DBContext.Employee.Include(x=>x.Department).ToListAsync();
            var employee = await DBContext.Employee.ToListAsync();
            return Ok(employee);
        }
    }
}