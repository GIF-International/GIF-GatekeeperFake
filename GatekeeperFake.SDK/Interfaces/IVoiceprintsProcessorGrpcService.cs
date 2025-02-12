using Nuance.Biosec.V1.Voiceprint;

namespace GatekeeperFake.SDK.Interfaces;

public interface IVoiceprintsProcessorGrpcService
{
    GetEnrollStatusResponse GetEnrollStatus(GetEnrollStatusRequest request);
    ProcessAudioResponse ProcessAudio(ProcessAudioRequest request);
    EnrollResponse Enroll(EnrollRequest request);
    TrainResponse Train(TrainRequest request);
    AnalyzeAudioResponse AnalyzeAudio(AnalyzeAudioRequest request);
}
