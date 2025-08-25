// Controllers/TarefasController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
[ApiController]
[Route("api/[controller]")]
public class TarefasController : ControllerBase
{
    private readonly TarefasContext _context;
    public TarefasController(TarefasContext context)
    {
        _context = context;
    }
    // ... (restante dos métodos do controller)
}
