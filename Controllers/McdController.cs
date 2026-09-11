using Microsoft.AspNetCore.Mvc;

namespace MCD.Controllers;
[ApiController]
[Route("api/[controller]")]
public class McdController : ControllerBase
{
    [HttpGet("mcd/{numero1:int}/{numero2:int}")]
    public IActionResult MCD(int numero1, int numero2)
    {
        if (numero1 <= 0 || numero2 <= 0)
        {
            return BadRequest("Los números deben ser mayores a 0.");
        }

        int mcd = CalcularMCD(numero1, numero2);
        return Ok(mcd);
    }

    private int CalcularMCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}