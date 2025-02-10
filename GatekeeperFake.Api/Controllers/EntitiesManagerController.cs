using System.Net;
using GatekeeperFake.SDK.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Nuance.Biosec.V1.Entities;

namespace GatekeeperFake.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EntitiesManagerController : ControllerBase
{
    [HttpGet("GetGkPersonId")]
    public IActionResult GetGkPersonId([FromServices] IEntitiesManagerGrpcService entitiesManagerGrpcService)
    {
        var result = entitiesManagerGrpcService.GetGkPersonId(new GetGkPersonIdRequest());

        return Ok(new { statusCode = HttpStatusCode.OK, message = result });
    }
}
