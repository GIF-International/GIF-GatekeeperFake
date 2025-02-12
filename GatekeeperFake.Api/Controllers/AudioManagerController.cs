using System.Net;
using GatekeeperFake.SDK.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Nuance.Biosec.V1.Audio;

namespace GatekeeperFake.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AudioManagerController : ControllerBase
{
    [HttpGet("GetUploadUrl")]
    public IActionResult GetUploadUrl([FromServices] IAudioManagerGrpcService audioManagerGrpcService)
    {
        var result = audioManagerGrpcService.GetUploadUrl(new GetUploadUrlRequest());

        return Ok(new { statusCode = HttpStatusCode.OK, message = result });
    }
}
