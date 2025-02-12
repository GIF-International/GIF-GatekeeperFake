using Nuance.Biosec.V1.Audio;

namespace GatekeeperFake.SDK.Interfaces;

public interface IAudioManagerGrpcService
{
    GetUploadUrlResponse GetUploadUrl(GetUploadUrlRequest request);
}
