using System.Net;
using GatekeeperFake.SDK.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Nuance.Biosec.V1.Voiceprint;

namespace GatekeeperFake.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VoiceprintsManagerController : ControllerBase
{
    [HttpGet("GetGkVoiceprintProfileId")]
    public IActionResult GetGkVoiceprintProfileId([FromServices] IVoiceprintsManagerGrpcService voiceprintsManagerGrpcService)
    {
        var result = voiceprintsManagerGrpcService.GetGkVoiceprintProfileId(new GetGkVoiceprintProfileIdRequest());

        return Ok(new { statusCode = HttpStatusCode.OK, message = result });
    }
}
