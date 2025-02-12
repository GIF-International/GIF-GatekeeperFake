using System.Net;
using GatekeeperFake.SDK.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Nuance.Biosec.V1.Audio;

namespace GatekeeperFake.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AudioProcessorController : ControllerBase
{
    [HttpGet("ValidateText")]
    public IActionResult ValidateText([FromServices] IAudioProcessorGrpcService audioProcessorGrpcService)
    {
        var result = audioProcessorGrpcService.ValidateText(new ValidateTextRequest());

        return Ok(new { statusCode = HttpStatusCode.OK, message = result });
    }
}
