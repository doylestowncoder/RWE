using Microsoft.AspNetCore.Mvc;

namespace RWE.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SendMessageController : ControllerBase
{
    private readonly ILogger<SendMessageController> _logger;

    public SendMessageController(ILogger<SendMessageController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public ActionResult Post()
    {
        _logger.LogInformation(RWE.Common.Logger.AppLogEvents.Update, RWE.Common.Logger.AppLogTemplates.SendMessagePostBegin, 10, "someemail@gmail.com");

        // Do Something cool later
        
        _logger.LogInformation(RWE.Common.Logger.AppLogEvents.Update, RWE.Common.Logger.AppLogTemplates.SendMessagePostEnd, 10, "someemail@gmail.com");

        return Ok();
    }
}