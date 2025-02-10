using GatekeeperFake.gRPC;
using GatekeeperFake.SDK.Interfaces;
using GatekeeperFake.SDK.Services;
using Microsoft.Extensions.DependencyInjection;
using Nuance.Biosec.V1.Entities;
using Nuance.Biosec.V1.Sessions;
using Nuance.Biosec.V1.Voiceprint;

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

        services.AddGrpcClient<EntitiesManager.EntitiesManagerClient>(client =>
        {
            client.Address = new Uri("https://localhost:7238");
        });

        services.AddGrpcClient<VoiceprintsManager.VoiceprintsManagerClient>(client =>
        {
            client.Address = new Uri("https://localhost:7238");
        });

        services.AddGrpcClient<VoiceprintsProcessor.VoiceprintsProcessorClient>(client =>
        {
            client.Address = new Uri("https://localhost:7238");
        });

        services.AddScoped<IGreeterGrpcService, GreeterGrpcService>();
        services.AddScoped<ISessionsManagerGrpcService, SessionsManagerGrpcService>();
        services.AddScoped<IEntitiesManagerGrpcService, EntitiesManagerGrpcService>();
        services.AddScoped<IVoiceprintsManagerGrpcService, VoiceprintsManagerGrpcService>();
        services.AddScoped<IVoiceprintsProcessorGrpcService, VoiceprintsProcessorGrpcService>();
    }
}
