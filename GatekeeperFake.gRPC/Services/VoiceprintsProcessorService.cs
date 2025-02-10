using Nuance.Biosec.V1.Voiceprint;
using static Nuance.Biosec.V1.Voiceprint.VoiceprintsProcessor;
using grpc = global::Grpc.Core;

namespace GatekeeperFake.gRPC.Services;

public class VoiceprintsProcessorService : VoiceprintsProcessorBase
{
    private readonly ILogger<VoiceprintsProcessorService> _logger;
    private readonly IConfiguration _configuration;

    public VoiceprintsProcessorService(
        ILogger<VoiceprintsProcessorService> logger,
        IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    public override global::System.Threading.Tasks.Task<global::Nuance.Biosec.V1.Voiceprint.GetEnrollStatusResponse> GetEnrollStatus(global::Nuance.Biosec.V1.Voiceprint.GetEnrollStatusRequest request, grpc::ServerCallContext context)
    {
        //throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));

        var task = Task.FromResult(new GetEnrollStatusResponse
        {
            IsTrained = true,
            Result = EnrollStatus.TrainSuggested,
            Status = new Nuance.Rpc.Status { StatusCode = Nuance.Rpc.StatusCode.Ok },
        });

        var minDelay = _configuration.GetValue<int>("Methods:VoiceprintsProcessor:GetGkVoiceprintProfileId:Delay:Min");
        var maxDelay = _configuration.GetValue<int>("Methods:VoiceprintsProcessor:GetGkVoiceprintProfileId:Delay:Max");
        var randomDelay = new Random().Next(minDelay, maxDelay);

        Thread.Sleep(randomDelay);

        return task;
    }
}
