using Microsoft.AspNetCore.Mvc;
using Modeller;

namespace Api.Controllers;

[ApiController]
[Route("api/isletme")]
public class IsletmeController : ControllerBase
{
    // Giriş ekranı işletmenin adını giriş yapılmadan önce gösterdiği için oturum istemez.
    // Yalnızca ad döner; adres gibi bilgiler burada verilmez.
    [HttpGet]
    public IActionResult Getir()
    {
        return Ok(new IsletmeBilgisi { Ad = Isletme.Ad });
    }
}
