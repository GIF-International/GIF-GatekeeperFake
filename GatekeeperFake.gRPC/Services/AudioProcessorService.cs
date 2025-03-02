﻿using Nuance.Biosec.V1.Audio;
using static Nuance.Biosec.V1.Audio.AudioProcessor;
using grpc = global::Grpc.Core;

namespace GatekeeperFake.gRPC.Services;

public class AudioProcessorService : AudioProcessorBase
{
    private readonly ILogger<AudioProcessorService> _logger;
    private readonly IConfiguration _configuration;

    public AudioProcessorService(
        ILogger<AudioProcessorService> logger,
        IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    public override global::System.Threading.Tasks.Task<global::Nuance.Biosec.V1.Audio.ValidateTextResponse> ValidateText(global::Nuance.Biosec.V1.Audio.ValidateTextRequest request, grpc::ServerCallContext context)
    {
        //throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));

        var task = Task.FromResult(new ValidateTextResponse
        {
            Result = new Nuance.Biosec.V1.Audio.ValidateTextResult { Decision = Nuance.Biosec.V1.Decision.Authentic },
            Status = new Nuance.Rpc.Status { StatusCode = Nuance.Rpc.StatusCode.Ok },
        });

        var minDelay = _configuration.GetValue<int>("Methods:AudioProcessor:ValidateText:Delay:Min");
        var maxDelay = _configuration.GetValue<int>("Methods:AudioProcessor:ValidateText:Delay:Max");
        var randomDelay = new Random().Next(minDelay, maxDelay);

        Thread.Sleep(randomDelay);

        var methodName = $"{nameof(AudioProcessorService)}.{nameof(ValidateText)}";
        _logger.LogInformation($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")} - {methodName} - Delay: {randomDelay}ms ({minDelay}-{maxDelay})");

        return task;
    }

    public override global::System.Threading.Tasks.Task<global::Nuance.Biosec.V1.Audio.DetectAudioSpoofingResponse> DetectAudioSpoofing(global::Nuance.Biosec.V1.Audio.DetectAudioSpoofingRequest request, grpc::ServerCallContext context)
    {
        //throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));

        var task = Task.FromResult(new DetectAudioSpoofingResponse
        {
            AudioDetails = null,
            ChannelPlaybackDetectionResult = null,
            FootprintPlaybackDetectionResult = null,
            SyntheticSpeechDetectionResult = null,
            Validity = Nuance.Biosec.V1.AudioValidity.ReasonAudioOk,
            Status = new Nuance.Rpc.Status { StatusCode = Nuance.Rpc.StatusCode.Ok },
        });

        var minDelay = _configuration.GetValue<int>("Methods:AudioProcessor:DetectAudioSpoofing:Delay:Min");
        var maxDelay = _configuration.GetValue<int>("Methods:AudioProcessor:DetectAudioSpoofing:Delay:Max");
        var randomDelay = new Random().Next(minDelay, maxDelay);

        Thread.Sleep(randomDelay);

        var methodName = $"{nameof(AudioProcessorService)}.{nameof(DetectAudioSpoofing)}";
        _logger.LogInformation($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")} - {methodName} - Delay: {randomDelay}ms ({minDelay}-{maxDelay})");

        return task;
    }
}
