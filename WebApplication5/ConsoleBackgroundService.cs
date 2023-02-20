namespace WebApplication5
{
    public class ConsoleBackgroundService : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(250, stoppingToken);
            }
        }
    }
}
