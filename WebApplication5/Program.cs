using WebApplication5;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHostedService<ConsoleBackgroundService>();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

var cancellationTokenSource = new CancellationTokenSource();
var token = cancellationTokenSource.Token;

//app.Run(async (context) =>
//{
//    var service = app.Services.GetRequiredService<ConsoleBackgroundService>();
//    await service.StartAsync(token);
//    while (Console.ReadKey().Key != ConsoleKey.X)
//    {

//    }
//    cancellationTokenSource.Cancel();
//    await context.Response.WriteAsync($"Stop");
//});
await app.RunAsync();






