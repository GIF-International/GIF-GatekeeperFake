using GatekeeperFake.gRPC.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc(options =>
{
    options.EnableDetailedErrors = true;
});

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseGrpcWeb(); // Habilita gRPC-Web

app.MapGrpcService<GreeterService>().EnableGrpcWeb();
app.MapGrpcService<SessionsManagerService>().EnableGrpcWeb();
app.MapGrpcService<EntitiesManagerService>().EnableGrpcWeb();
app.MapGrpcService<VoiceprintsManagerService>().EnableGrpcWeb();
app.MapGrpcService<VoiceprintsProcessorService>().EnableGrpcWeb();
app.MapGrpcService<AudioManagerService>().EnableGrpcWeb();
app.MapGrpcService<AudioProcessorService>().EnableGrpcWeb();

//app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
