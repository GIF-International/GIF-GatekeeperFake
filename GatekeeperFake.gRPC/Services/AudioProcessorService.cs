using Nuance.Biosec.V1.Audio;
using static Nuance.Biosec.V1.Audio.AudioProcessor;
using grpc = global::Grpc.Core;

namespace GatekeeperFake.gRPC.Services;

public class AudioProcessorService : AudioProcessorBase
{
    private readonly ILogger<AudioProcessorService> _logger;
    private readonly IConfiguration _configuration;

    public AudioProcessorService(
        ILogger<AudioProcessorService> logger,
        IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    public override global::System.Threading.Tasks.Task<global::Nuance.Biosec.V1.Audio.ValidateTextResponse> ValidateText(global::Nuance.Biosec.V1.Audio.ValidateTextRequest request, grpc::ServerCallContext context)
    {
        //throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));

        var task = Task.FromResult(new ValidateTextResponse
        {
            Result = new Nuance.Biosec.V1.Audio.ValidateTextResult { Decision = Nuance.Biosec.V1.Decision.Authentic },
            Status = new Nuance.Rpc.Status { StatusCode = Nuance.Rpc.StatusCode.Ok },
        });

        var minDelay = _configuration.GetValue<int>("Methods:AudioProcessor:ValidateText:Delay:Min");
        var maxDelay = _configuration.GetValue<int>("Methods:AudioProcessor:ValidateText:Delay:Max");
        var randomDelay = new Random().Next(minDelay, maxDelay);

        Thread.Sleep(randomDelay);

        return task;
    }
}
