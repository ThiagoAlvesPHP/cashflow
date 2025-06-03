using Microsoft.AspNetCore.Mvc;

namespace CashFlow.Api.Controllers;

[Route("api/[controller]")]
[ApiController]

public class ExpensesController : Controller
{
    
    [HttpPost]
    public IActionResult Register()
    {
        return Created();
    }
}