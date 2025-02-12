using Nuance.Biosec.V1.Voiceprint;

namespace GatekeeperFake.SDK.Interfaces;

public interface IVoiceprintsManagerGrpcService
{
    GetGkVoiceprintProfileIdResponse GetGkVoiceprintProfileId(GetGkVoiceprintProfileIdRequest request);
    ListEnrollmentSegmentsResponse ListEnrollmentSegments(ListEnrollmentSegmentsRequest request);
}
