using GatekeeperFake.SDK.Interfaces;
using Grpc.Core;
using Nuance.Biosec.V1.Audio;

namespace GatekeeperFake.SDK.Services;

public class AudioProcessorGrpcService : IAudioProcessorGrpcService
{
    private readonly AudioProcessor.AudioProcessorClient _client;

    public AudioProcessorGrpcService(AudioProcessor.AudioProcessorClient client)
    {
        _client = client;
    }

    public ValidateTextResponse ValidateText(ValidateTextRequest request)
    {
        try
        {
            var result = _client.ValidateText(request);

            return result;
        }
        catch (RpcException ex)
        {
            throw;
        }
    }
}
