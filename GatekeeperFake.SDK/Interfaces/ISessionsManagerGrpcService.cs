using Nuance.Biosec.V1.Sessions;

namespace GatekeeperFake.SDK.Interfaces;

public interface ISessionsManagerGrpcService
{
    StartEngagementResponse StartEngagement(StartEngagementRequest request);
    StartSessionResponse StartSession(StartSessionRequest request);
    GetSessionDetailsResponse GetSessionDetails(GetSessionDetailsRequest request);
    UpdateSessionResponse UpdateSession(UpdateSessionRequest request);
    GetSessionDecisionResponse GetSessionDecision(GetSessionDecisionRequest request);
    StopSessionResponse StopSession(StopSessionRequest request);
    StopEngagementResponse StopEngagement(StopEngagementRequest request);
}
