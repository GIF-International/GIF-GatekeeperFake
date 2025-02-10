using Nuance.Biosec.V1.Entities;

namespace GatekeeperFake.SDK.Interfaces;

public interface IEntitiesManagerGrpcService
{
    GetGkPersonIdResponse GetGkPersonId(GetGkPersonIdRequest request);
}
