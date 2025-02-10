using GatekeeperFake.SDK.Interfaces;
using Grpc.Core;
using Nuance.Biosec.V1.Sessions;

namespace GatekeeperFake.SDK.Services;

public class SessionsManagerGrpcService : ISessionsManagerGrpcService
{
    private readonly SessionsManager.SessionsManagerClient _client;

    public SessionsManagerGrpcService(SessionsManager.SessionsManagerClient client)
    {
        _client = client;
    }

    public StartEngagementResponse StartEngagement(StartEngagementRequest request)
    {
        try
        {
            var result = _client.StartEngagement(request);

            return result;
        }
        catch (RpcException ex)
        {
            throw;
        }
    }

    public StartSessionResponse StartSession(StartSessionRequest request)
    {
        try
        {
            var result = _client.StartSession(request);

            return result;
        }
        catch (RpcException ex)
        {
            throw;
        }
    }

    public GetSessionDetailsResponse GetSessionDetails(GetSessionDetailsRequest request)
    {
        try
        {
            var result = _client.GetSessionDetails(request);

            return result;
        }
        catch (RpcException ex)
        {
            throw;
        }
    }
}
