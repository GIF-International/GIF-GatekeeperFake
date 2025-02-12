using GatekeeperFake.SDK.Interfaces;
using Grpc.Core;
using Nuance.Biosec.V1.Voiceprint;

namespace GatekeeperFake.SDK.Services;

public class VoiceprintsProcessorGrpcService : IVoiceprintsProcessorGrpcService
{
    private readonly VoiceprintsProcessor.VoiceprintsProcessorClient _client;

    public VoiceprintsProcessorGrpcService(VoiceprintsProcessor.VoiceprintsProcessorClient client)
    {
        _client = client;
    }

    public GetEnrollStatusResponse GetEnrollStatus(GetEnrollStatusRequest request)
    {
        try
        {
            var result = _client.GetEnrollStatus(request);

            return result;
        }
        catch (RpcException ex)
        {
            throw;
        }
    }

    public ProcessAudioResponse ProcessAudio(ProcessAudioRequest request)
    {
        try
        {
            var result = _client.ProcessAudio(request);

            return result;
        }
        catch (RpcException ex)
        {
            throw;
        }
    }

    public EnrollResponse Enroll(EnrollRequest request)
    {
        try
        {
            var result = _client.Enroll(request);

            return result;
        }
        catch (RpcException ex)
        {
            throw;
        }
    }

    public TrainResponse Train(TrainRequest request)
    {
        try
        {
            var result = _client.Train(request);

            return result;
        }
        catch (RpcException ex)
        {
            throw;
        }
    }
}
