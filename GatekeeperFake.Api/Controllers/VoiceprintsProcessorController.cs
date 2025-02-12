using System.Net;
using GatekeeperFake.SDK.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Nuance.Biosec.V1.Voiceprint;

namespace GatekeeperFake.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class VoiceprintsProcessorController : ControllerBase
{
    [HttpGet("GetEnrollStatus")]
    public IActionResult GetEnrollStatus([FromServices] IVoiceprintsProcessorGrpcService voiceprintsProcessorGrpcService)
    {
        var result = voiceprintsProcessorGrpcService.GetEnrollStatus(new GetEnrollStatusRequest());

        return Ok(new { statusCode = HttpStatusCode.OK, message = result });
    }

    [HttpGet("ProcessAudio")]
    public IActionResult ProcessAudio([FromServices] IVoiceprintsProcessorGrpcService voiceprintsProcessorGrpcService)
    {
        var result = voiceprintsProcessorGrpcService.ProcessAudio(new ProcessAudioRequest());

        return Ok(new { statusCode = HttpStatusCode.OK, message = result });
    }

    [HttpGet("Enroll")]
    public IActionResult Enroll([FromServices] IVoiceprintsProcessorGrpcService voiceprintsProcessorGrpcService)
    {
        var result = voiceprintsProcessorGrpcService.Enroll(new EnrollRequest());

        return Ok(new { statusCode = HttpStatusCode.OK, message = result });
    }

    [HttpGet("Train")]
    public IActionResult Train([FromServices] IVoiceprintsProcessorGrpcService voiceprintsProcessorGrpcService)
    {
        var result = voiceprintsProcessorGrpcService.Train(new TrainRequest());

        return Ok(new { statusCode = HttpStatusCode.OK, message = result });
    }

    [HttpGet("AnalyzeAudio")]
    public IActionResult AnalyzeAudio([FromServices] IVoiceprintsProcessorGrpcService voiceprintsProcessorGrpcService)
    {
        var result = voiceprintsProcessorGrpcService.AnalyzeAudio(new AnalyzeAudioRequest());

        return Ok(new { statusCode = HttpStatusCode.OK, message = result });
    }
}
