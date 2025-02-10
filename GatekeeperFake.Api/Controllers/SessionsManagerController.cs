﻿using System.Net;
using GatekeeperFake.SDK.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Nuance.Biosec.V1.Sessions;

namespace GatekeeperFake.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionsManagerController : ControllerBase
    {

        [HttpGet("StartEngagement")]
        public IActionResult StartEngagement([FromServices] ISessionsManagerGrpcService sessionsManagerGrpcService)
        {
            var result = sessionsManagerGrpcService.StartEngagement(new StartEngagementRequest());

            return Ok(new { statusCode = HttpStatusCode.OK, message = result });
        }

        [HttpGet("StartSession")]
        public IActionResult StartSession([FromServices] ISessionsManagerGrpcService sessionsManagerGrpcService)
        {
            var result = sessionsManagerGrpcService.StartSession(new StartSessionRequest());

            return Ok(new { statusCode = HttpStatusCode.OK, message = result });
        }
    }
}
