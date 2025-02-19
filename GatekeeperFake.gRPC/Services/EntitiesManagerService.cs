using Nuance.Biosec.V1.Entities;
using static Nuance.Biosec.V1.Entities.EntitiesManager;
using grpc = global::Grpc.Core;

namespace GatekeeperFake.gRPC.Services;

public class EntitiesManagerService : EntitiesManagerBase
{
    private readonly ILogger<SessionsManagerService> _logger;
    private readonly IConfiguration _configuration;

    public EntitiesManagerService(
        ILogger<SessionsManagerService> logger,
        IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    public override global::System.Threading.Tasks.Task<global::Nuance.Biosec.V1.Entities.GetGkPersonIdResponse> GetGkPersonId(global::Nuance.Biosec.V1.Entities.GetGkPersonIdRequest request, grpc::ServerCallContext context)
    {
        //throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));

        var task = Task.FromResult(new GetGkPersonIdResponse
        {
            GkPersonId = new Nuance.Biosec.V1.UniqueId { Value = Guid.NewGuid().ToString() },
            Status = new Nuance.Rpc.Status { StatusCode = Nuance.Rpc.StatusCode.Ok },
        });

        var minDelay = _configuration.GetValue<int>("Methods:EntitiesManager:GetGkPersonId:Delay:Min");
        var maxDelay = _configuration.GetValue<int>("Methods:EntitiesManager:GetGkPersonId:Delay:Max");
        var randomDelay = new Random().Next(minDelay, maxDelay);

        Thread.Sleep(randomDelay);

        var methodName = $"{nameof(EntitiesManagerService)}.{nameof(GetGkPersonId)}";
        _logger.LogInformation($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")} - {methodName} - Delay: {randomDelay}ms ({minDelay}-{maxDelay})");

        return task;
    }

    public override global::System.Threading.Tasks.Task<global::Nuance.Biosec.V1.Entities.DeletePersonResponse> DeletePerson(global::Nuance.Biosec.V1.Entities.DeletePersonRequest request, grpc::ServerCallContext context)
    {
        //throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));

        var task = Task.FromResult(new DeletePersonResponse
        {
            Status = new Nuance.Rpc.Status { StatusCode = Nuance.Rpc.StatusCode.Ok },
        });

        var minDelay = _configuration.GetValue<int>("Methods:EntitiesManager:DeletePerson:Delay:Min");
        var maxDelay = _configuration.GetValue<int>("Methods:EntitiesManager:DeletePerson:Delay:Max");
        var randomDelay = new Random().Next(minDelay, maxDelay);

        Thread.Sleep(randomDelay);

        var methodName = $"{nameof(EntitiesManagerService)}.{nameof(DeletePerson)}";
        _logger.LogInformation($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")} - {methodName} - Delay: {randomDelay}ms ({minDelay}-{maxDelay})");

        return task;
    }
}
