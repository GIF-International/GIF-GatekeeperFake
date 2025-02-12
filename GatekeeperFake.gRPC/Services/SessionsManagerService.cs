using Nuance.Biosec.V1.Sessions;
using static Nuance.Biosec.V1.Sessions.SessionsManager;
using grpc = global::Grpc.Core;

namespace GatekeeperFake.gRPC.Services;

public class SessionsManagerService : SessionsManagerBase
{
    private readonly ILogger<SessionsManagerService> _logger;
    private readonly IConfiguration _configuration;

    public SessionsManagerService(
        ILogger<SessionsManagerService> logger,
        IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    public override global::System.Threading.Tasks.Task<global::Nuance.Biosec.V1.Sessions.StartEngagementResponse> StartEngagement(global::Nuance.Biosec.V1.Sessions.StartEngagementRequest request, grpc::ServerCallContext context)
    {
        //throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));

        var task = Task.FromResult(new StartEngagementResponse
        {
            GkEngagementId = new Nuance.Biosec.V1.UniqueId { Value = Guid.NewGuid().ToString() },
            Status = new Nuance.Rpc.Status { StatusCode = Nuance.Rpc.StatusCode.Ok },
        });

        var minDelay = _configuration.GetValue<int>("Methods:SessionsManager:StartEngagement:Delay:Min");
        var maxDelay = _configuration.GetValue<int>("Methods:SessionsManager:StartEngagement:Delay:Max");
        var randomDelay = new Random().Next(minDelay, maxDelay);

        Thread.Sleep(randomDelay);

        return task;
    }

    public override global::System.Threading.Tasks.Task<global::Nuance.Biosec.V1.Sessions.StartSessionResponse> StartSession(global::Nuance.Biosec.V1.Sessions.StartSessionRequest request, grpc::ServerCallContext context)
    {
        //throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));

        var task = Task.FromResult(new StartSessionResponse()
        {
            GkEngagementId = new Nuance.Biosec.V1.UniqueId { Value = Guid.NewGuid().ToString() },
            GkSessionId = new Nuance.Biosec.V1.UniqueId { Value = Guid.NewGuid().ToString() },
            Status = new Nuance.Rpc.Status { StatusCode = Nuance.Rpc.StatusCode.Ok },
        });

        var minDelay = _configuration.GetValue<int>("Methods:SessionsManager:StartSession:Delay:Min");
        var maxDelay = _configuration.GetValue<int>("Methods:SessionsManager:StartSession:Delay:Max");
        var randomDelay = new Random().Next(minDelay, maxDelay);

        Thread.Sleep(randomDelay);

        return task;
    }

    public override global::System.Threading.Tasks.Task<global::Nuance.Biosec.V1.Sessions.GetSessionDetailsResponse> GetSessionDetails(global::Nuance.Biosec.V1.Sessions.GetSessionDetailsRequest request, grpc::ServerCallContext context)
    {
        //throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));

        var task = Task.FromResult(new GetSessionDetailsResponse()
        {
            Details = new SessionDetailsForRead() { GkEngagementId = new Nuance.Biosec.V1.UniqueId { Value = Guid.NewGuid().ToString() }, },
            Status = new Nuance.Rpc.Status { StatusCode = Nuance.Rpc.StatusCode.Ok },
        });

        var minDelay = _configuration.GetValue<int>("Methods:SessionsManager:GetSessionDetails:Delay:Min");
        var maxDelay = _configuration.GetValue<int>("Methods:SessionsManager:GetSessionDetails:Delay:Max");
        var randomDelay = new Random().Next(minDelay, maxDelay);

        Thread.Sleep(randomDelay);

        return task;
    }

    public override global::System.Threading.Tasks.Task<global::Nuance.Biosec.V1.Sessions.UpdateSessionResponse> UpdateSession(global::Nuance.Biosec.V1.Sessions.UpdateSessionRequest request, grpc::ServerCallContext context)
    {
        //throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));

        var task = Task.FromResult(new UpdateSessionResponse()
        {
            Status = new Nuance.Rpc.Status { StatusCode = Nuance.Rpc.StatusCode.Ok },
        });

        var minDelay = _configuration.GetValue<int>("Methods:SessionsManager:UpdateSession:Delay:Min");
        var maxDelay = _configuration.GetValue<int>("Methods:SessionsManager:UpdateSession:Delay:Max");
        var randomDelay = new Random().Next(minDelay, maxDelay);

        Thread.Sleep(randomDelay);

        return task;
    }
}
