using GatekeeperFake.SDK.Interfaces;
using Grpc.Core;
using Nuance.Biosec.V1.Audio;

namespace GatekeeperFake.SDK.Services;

public class AudioManagerGrpcService : IAudioManagerGrpcService
{
    private readonly AudioManager.AudioManagerClient _client;

    public AudioManagerGrpcService(AudioManager.AudioManagerClient client)
    {
        _client = client;
    }

    public GetUploadUrlResponse GetUploadUrl(GetUploadUrlRequest request)
    {
        try
        {
            var result = _client.GetUploadUrl(request);

            return result;
        }
        catch (RpcException ex)
        {
            throw;
        }
    }
}
