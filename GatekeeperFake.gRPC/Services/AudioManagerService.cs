using Nuance.Biosec.V1.Audio;
using static Nuance.Biosec.V1.Audio.AudioManager;
using grpc = global::Grpc.Core;

namespace GatekeeperFake.gRPC.Services;

public class AudioManagerService : AudioManagerBase
{
    private readonly ILogger<AudioManagerService> _logger;
    private readonly IConfiguration _configuration;

    public AudioManagerService(
        ILogger<AudioManagerService> logger,
        IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    public override global::System.Threading.Tasks.Task<global::Nuance.Biosec.V1.Audio.GetUploadUrlResponse> GetUploadUrl(global::Nuance.Biosec.V1.Audio.GetUploadUrlRequest request, grpc::ServerCallContext context)
    {
        //throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));

        var task = Task.FromResult(new GetUploadUrlResponse
        {
            GkMediaSegmentId = new Nuance.Biosec.V1.UniqueId { Value = Guid.NewGuid().ToString() },
            MediaUploadUrl = "https://eastus1-mediamanager.api.nuance.com/external_az/upload/552d36c7-a69f-4686-9fe8-381de9ac8b06?sv=2023-01-03&st=2025-02-12T14%3A21%3A12Z&se=2025-02-12T14%3A36%3A12Z&sr=b&sp=aw&sig=cD%2FXG2qvJgfcX4LX88VfVrohD5LXON%2B9cbVU%2FUE8J9c%3D",
            Status = new Nuance.Rpc.Status { StatusCode = Nuance.Rpc.StatusCode.Ok },
        });

        var minDelay = _configuration.GetValue<int>("Methods:AudioManager:GetUploadUrl:Delay:Min");
        var maxDelay = _configuration.GetValue<int>("Methods:AudioManager:GetUploadUrl:Delay:Max");
        var randomDelay = new Random().Next(minDelay, maxDelay);

        Thread.Sleep(randomDelay);

        return task;
    }
}
