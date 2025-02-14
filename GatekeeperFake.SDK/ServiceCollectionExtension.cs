using GatekeeperFake.gRPC;
using GatekeeperFake.SDK.Interfaces;
using GatekeeperFake.SDK.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nuance.Biosec.V1.Audio;
using Nuance.Biosec.V1.Entities;
using Nuance.Biosec.V1.Sessions;
using Nuance.Biosec.V1.Voiceprint;

namespace GatekeeperFake.SDK;

public static class ServiceCollectionExtension
{
    public static void AddGatekeeperFakeSDK(this IServiceCollection services, IConfiguration configuration)
    {
        var grpcUrl = configuration.GetValue<string>("Grpc:Url");

        if (string.IsNullOrEmpty(grpcUrl))
            throw new ArgumentNullException(nameof(grpcUrl), "gRPC Url cannot be null or empty.");

        services.AddGrpcClient<Greeter.GreeterClient>(client =>
        {
            client.Address = new Uri(grpcUrl);
        });

        services.AddGrpcClient<SessionsManager.SessionsManagerClient>(client =>
        {
            client.Address = new Uri(grpcUrl);
        });

        services.AddGrpcClient<EntitiesManager.EntitiesManagerClient>(client =>
        {
            client.Address = new Uri(grpcUrl);
        });

        services.AddGrpcClient<VoiceprintsManager.VoiceprintsManagerClient>(client =>
        {
            client.Address = new Uri(grpcUrl);
        });

        services.AddGrpcClient<VoiceprintsProcessor.VoiceprintsProcessorClient>(client =>
        {
            client.Address = new Uri(grpcUrl);
        });

        services.AddGrpcClient<AudioManager.AudioManagerClient>(client =>
        {
            client.Address = new Uri(grpcUrl);
        });

        services.AddGrpcClient<AudioProcessor.AudioProcessorClient>(client =>
        {
            client.Address = new Uri(grpcUrl);
        });

        services.AddScoped<IGreeterGrpcService, GreeterGrpcService>();
        services.AddScoped<ISessionsManagerGrpcService, SessionsManagerGrpcService>();
        services.AddScoped<IEntitiesManagerGrpcService, EntitiesManagerGrpcService>();
        services.AddScoped<IVoiceprintsManagerGrpcService, VoiceprintsManagerGrpcService>();
        services.AddScoped<IVoiceprintsProcessorGrpcService, VoiceprintsProcessorGrpcService>();
        services.AddScoped<IAudioManagerGrpcService, AudioManagerGrpcService>();
        services.AddScoped<IAudioProcessorGrpcService, AudioProcessorGrpcService>();
    }
}
