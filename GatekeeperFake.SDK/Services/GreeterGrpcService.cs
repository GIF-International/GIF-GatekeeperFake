using GatekeeperFake.gRPC;
using GatekeeperFake.SDK.Interfaces;
using Grpc.Core;

namespace GatekeeperFake.SDK.Services;

public class GreeterGrpcService : IGreeterGrpcService
{
    private readonly Greeter.GreeterClient _client;

    public GreeterGrpcService(Greeter.GreeterClient client)
    {
        _client = client;
    }

    public async Task<string> SayHelloAsync(string name)
    {
        try
        {
            var result = await _client.SayHelloAsync(new HelloRequest { Name = name });

            return result.Message;
        }
        catch (RpcException ex)
        {
            throw;
        }
    }
}
