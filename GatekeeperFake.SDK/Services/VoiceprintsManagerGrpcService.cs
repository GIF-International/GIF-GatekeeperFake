using GatekeeperFake.SDK.Interfaces;
using Grpc.Core;
using Nuance.Biosec.V1.Voiceprint;

namespace GatekeeperFake.SDK.Services;

public class VoiceprintsManagerGrpcService : IVoiceprintsManagerGrpcService
{
    private readonly VoiceprintsManager.VoiceprintsManagerClient _client;

    public VoiceprintsManagerGrpcService(VoiceprintsManager.VoiceprintsManagerClient client)
    {
        _client = client;
    }

    public GetGkVoiceprintProfileIdResponse GetGkVoiceprintProfileId(GetGkVoiceprintProfileIdRequest request)
    {
        try
        {
            var result = _client.GetGkVoiceprintProfileId(request);

            return result;
        }
        catch (RpcException ex)
        {
            throw;
        }
    }

    public ListEnrollmentSegmentsResponse ListEnrollmentSegments(ListEnrollmentSegmentsRequest request)
    {
        try
        {
            var result = _client.ListEnrollmentSegments(request);

            return result;
        }
        catch (RpcException ex)
        {
            throw;
        }
    }
}
