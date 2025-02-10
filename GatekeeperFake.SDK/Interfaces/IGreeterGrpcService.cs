namespace GatekeeperFake.SDK.Interfaces;

public interface IGreeterGrpcService
{
    Task<string> SayHelloAsync(string name);
}
