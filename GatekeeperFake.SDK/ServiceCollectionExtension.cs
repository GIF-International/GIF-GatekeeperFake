using GatekeeperFake.gRPC;
using GatekeeperFake.SDK.Interfaces;
using GatekeeperFake.SDK.Services;
using Microsoft.Extensions.DependencyInjection;
using Nuance.Biosec.V1.Sessions;

namespace GatekeeperFake.SDK;

public static class ServiceCollectionExtension
{
    public static void AddGatekeeperFakeSDK(this IServiceCollection services)
    {
        services.AddGrpcClient<Greeter.GreeterClient>(client =>
        {
            client.Address = new Uri("https://localhost:7238");
        });

        services.AddGrpcClient<SessionsManager.SessionsManagerClient>(client =>
        {
            client.Address = new Uri("https://localhost:7238");
        });

        services.AddScoped<IGreeterGrpcService, GreeterGrpcService>();
        services.AddScoped<ISessionsManagerGrpcService, SessionsManagerGrpcService>();
    }
}
