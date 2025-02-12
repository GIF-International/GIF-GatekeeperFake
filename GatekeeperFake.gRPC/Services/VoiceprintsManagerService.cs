using Nuance.Biosec.V1.Voiceprint;
using static Nuance.Biosec.V1.Voiceprint.VoiceprintsManager;
using grpc = global::Grpc.Core;

namespace GatekeeperFake.gRPC.Services;

public class VoiceprintsManagerService : VoiceprintsManagerBase
{
    private readonly ILogger<VoiceprintsManagerService> _logger;
    private readonly IConfiguration _configuration;

    public VoiceprintsManagerService(
        ILogger<VoiceprintsManagerService> logger,
        IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    public override global::System.Threading.Tasks.Task<global::Nuance.Biosec.V1.Voiceprint.GetGkVoiceprintProfileIdResponse> GetGkVoiceprintProfileId(global::Nuance.Biosec.V1.Voiceprint.GetGkVoiceprintProfileIdRequest request, grpc::ServerCallContext context)
    {
        //throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));

        var task = Task.FromResult(new GetGkVoiceprintProfileIdResponse
        {
            GkVoiceprintProfileId = new Nuance.Biosec.V1.UniqueId { Value = Guid.NewGuid().ToString() },
            Status = new Nuance.Rpc.Status { StatusCode = Nuance.Rpc.StatusCode.Ok },
        });

        var minDelay = _configuration.GetValue<int>("Methods:VoiceprintsManager:GetGkVoiceprintProfileId:Delay:Min");
        var maxDelay = _configuration.GetValue<int>("Methods:VoiceprintsManager:GetGkVoiceprintProfileId:Delay:Max");
        var randomDelay = new Random().Next(minDelay, maxDelay);

        Thread.Sleep(randomDelay);

        return task;
    }

    public override global::System.Threading.Tasks.Task<global::Nuance.Biosec.V1.Voiceprint.ListEnrollmentSegmentsResponse> ListEnrollmentSegments(global::Nuance.Biosec.V1.Voiceprint.ListEnrollmentSegmentsRequest request, grpc::ServerCallContext context)
    {
        //throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));

        var task = Task.FromResult(new ListEnrollmentSegmentsResponse
        {
            Status = new Nuance.Rpc.Status { StatusCode = Nuance.Rpc.StatusCode.Ok },
        });

        var minDelay = _configuration.GetValue<int>("Methods:VoiceprintsManager:ListEnrollmentSegments:Delay:Min");
        var maxDelay = _configuration.GetValue<int>("Methods:VoiceprintsManager:ListEnrollmentSegments:Delay:Max");
        var randomDelay = new Random().Next(minDelay, maxDelay);

        Thread.Sleep(randomDelay);

        return task;
    }
}
