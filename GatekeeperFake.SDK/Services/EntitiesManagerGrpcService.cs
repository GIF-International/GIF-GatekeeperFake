using GatekeeperFake.SDK.Interfaces;
using Grpc.Core;
using Nuance.Biosec.V1.Entities;

namespace GatekeeperFake.SDK.Services;

public class EntitiesManagerGrpcService : IEntitiesManagerGrpcService
{
    private readonly EntitiesManager.EntitiesManagerClient _client;

    public EntitiesManagerGrpcService(EntitiesManager.EntitiesManagerClient client)
    {
        _client = client;
    }

    public GetGkPersonIdResponse GetGkPersonId(GetGkPersonIdRequest request)
    {
        try
        {
            var result = _client.GetGkPersonId(request);

            return result;
        }
        catch (RpcException ex)
        {
            throw;
        }
    }

    public DeletePersonResponse DeletePerson(DeletePersonRequest request)
    {
        try
        {
            var result = _client.DeletePerson(request);

            return result;
        }
        catch (RpcException ex)
        {
            throw;
        }
    }
}
