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

        var minDelay = _configuration.GetValue<int>("Methods:VoiceprintsProcessor:GetEnrollStatus:Delay:Min");
        var maxDelay = _configuration.GetValue<int>("Methods:VoiceprintsProcessor:GetEnrollStatus:Delay:Max");
        var randomDelay = new Random().Next(minDelay, maxDelay);

        Thread.Sleep(randomDelay);

        return task;
    }

    public override global::System.Threading.Tasks.Task<global::Nuance.Biosec.V1.Voiceprint.ProcessAudioResponse> ProcessAudio(global::Nuance.Biosec.V1.Voiceprint.ProcessAudioRequest request, grpc::ServerCallContext context)
    {
        //throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));

        var task = Task.FromResult(new ProcessAudioResponse
        {
            Result = new Nuance.Biosec.V1.Voiceprint.AudioProcessingResult { Validity = Nuance.Biosec.V1.AudioValidity.ReasonAudioOk },
            Status = new Nuance.Rpc.Status { StatusCode = Nuance.Rpc.StatusCode.Ok },
        });

        var minDelay = _configuration.GetValue<int>("Methods:VoiceprintsProcessor:ProcessAudio:Delay:Min");
        var maxDelay = _configuration.GetValue<int>("Methods:VoiceprintsProcessor:ProcessAudio:Delay:Max");
        var randomDelay = new Random().Next(minDelay, maxDelay);

        Thread.Sleep(randomDelay);

        return task;
    }

    public override global::System.Threading.Tasks.Task<global::Nuance.Biosec.V1.Voiceprint.EnrollResponse> Enroll(global::Nuance.Biosec.V1.Voiceprint.EnrollRequest request, grpc::ServerCallContext context)
    {
        //throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));

        var task = Task.FromResult(new EnrollResponse
        {
            Result = new Nuance.Biosec.V1.Voiceprint.EnrollResult { },
            Status = new Nuance.Rpc.Status { StatusCode = Nuance.Rpc.StatusCode.Ok },
        });

        var minDelay = _configuration.GetValue<int>("Methods:VoiceprintsProcessor:Enroll:Delay:Min");
        var maxDelay = _configuration.GetValue<int>("Methods:VoiceprintsProcessor:Enroll:Delay:Max");
        var randomDelay = new Random().Next(minDelay, maxDelay);

        Thread.Sleep(randomDelay);

        return task;
    }

    public override global::System.Threading.Tasks.Task<global::Nuance.Biosec.V1.Voiceprint.TrainResponse> Train(global::Nuance.Biosec.V1.Voiceprint.TrainRequest request, grpc::ServerCallContext context)
    {
        //throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));

        var task = Task.FromResult(new TrainResponse
        {
            Result = new Nuance.Biosec.V1.Voiceprint.TrainResult { },
            Status = new Nuance.Rpc.Status { StatusCode = Nuance.Rpc.StatusCode.Ok },
        });

        var minDelay = _configuration.GetValue<int>("Methods:VoiceprintsProcessor:Train:Delay:Min");
        var maxDelay = _configuration.GetValue<int>("Methods:VoiceprintsProcessor:Train:Delay:Max");
        var randomDelay = new Random().Next(minDelay, maxDelay);

        Thread.Sleep(randomDelay);

        return task;
    }

    public override global::System.Threading.Tasks.Task<global::Nuance.Biosec.V1.Voiceprint.AnalyzeAudioResponse> AnalyzeAudio(global::Nuance.Biosec.V1.Voiceprint.AnalyzeAudioRequest request, grpc::ServerCallContext context)
    {
        //throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));

        var task = Task.FromResult(new AnalyzeAudioResponse
        {
            Result = new Nuance.Biosec.V1.Voiceprint.AnalyzeAudioResult { },
            Status = new Nuance.Rpc.Status { StatusCode = Nuance.Rpc.StatusCode.Ok },
        });

        var minDelay = _configuration.GetValue<int>("Methods:VoiceprintsProcessor:AnalyzeAudio:Delay:Min");
        var maxDelay = _configuration.GetValue<int>("Methods:VoiceprintsProcessor:AnalyzeAudio:Delay:Max");
        var randomDelay = new Random().Next(minDelay, maxDelay);

        Thread.Sleep(randomDelay);

        return task;
    }
}
