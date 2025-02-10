using Nuance.Biosec.V1.Sessions;
using static Nuance.Biosec.V1.Sessions.SessionsManager;
using grpc = global::Grpc.Core;

namespace GatekeeperFake.gRPC.Services
{
    public class SessionsManagerService : SessionsManagerBase
    {
        private readonly ILogger<SessionsManagerService> _logger;

        public SessionsManagerService(ILogger<SessionsManagerService> logger)
        {
            _logger = logger;
        }

        public override global::System.Threading.Tasks.Task<global::Nuance.Biosec.V1.Sessions.StartEngagementResponse> StartEngagement(global::Nuance.Biosec.V1.Sessions.StartEngagementRequest request, grpc::ServerCallContext context)
        {
            //throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));

            var task = Task.FromResult(new StartEngagementResponse
            {
                GkEngagementId = new Nuance.Biosec.V1.UniqueId { Value = Guid.NewGuid().ToString() },
                Status = new Nuance.Rpc.Status { StatusCode = Nuance.Rpc.StatusCode.Ok },
            });

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

            return task;
        }
    }
}
