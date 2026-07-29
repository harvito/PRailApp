using Intro;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PRailApp.Controllers;

public class CustomerController : ControllerBase
{
    private readonly PRailContext _db;

    public CustomerController(PRailContext db)
    {
        _db = db;
    }

    public async Task<ActionResult<IEnumerable<Customer>>> Get()
    {
        List<Customer> customers = await _db.Customer
            .ToListAsync();

        return Ok(customers);
    }
}
