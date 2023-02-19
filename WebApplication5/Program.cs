//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();

//app.MapGet("/", () => "Hello World!");


//int x = 2;
//app.Run(async (context) =>
//{
//    x = x * 2;  //  2 * 2 = 4
//    await context.Response.WriteAsync($"Result: {x}");
//});
//app.Run();
using WebApplication5;

var service = new ConsoleBackgroundService();

var cancellationTokenSource = new CancellationTokenSource();
var token = cancellationTokenSource.Token;

await service.StartAsync(token);


while (Console.ReadKey().Key != ConsoleKey.X)
{

}
cancellationTokenSource.Cancel();
