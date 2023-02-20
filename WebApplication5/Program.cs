using WebApplication5;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHostedService<ConsoleBackgroundService>();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

var cancellationTokenSource = new CancellationTokenSource();
var token = cancellationTokenSource.Token;

await app.RunAsync();






