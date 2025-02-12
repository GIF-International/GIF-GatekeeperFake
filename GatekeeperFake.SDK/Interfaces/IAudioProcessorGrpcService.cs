using Nuance.Biosec.V1.Audio;

namespace GatekeeperFake.SDK.Interfaces;

public interface IAudioProcessorGrpcService
{
    ValidateTextResponse ValidateText(ValidateTextRequest request);
}
