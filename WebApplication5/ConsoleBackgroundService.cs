namespace WebApplication5
{
    public class ConsoleBackgroundService : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var cancellationTokenSource = new CancellationTokenSource();
            Task task = Task.Run(() => ReadKeyLoop(cancellationTokenSource));
            while (!stoppingToken.IsCancellationRequested && !cancellationTokenSource.Token.IsCancellationRequested)
            {
                await Task.Delay(250, stoppingToken);
                Console.WriteLine(".");
            }
        }

        static void ReadKeyLoop(CancellationTokenSource token)
        {
            Console.WriteLine("Вход в цикл чтения клавиатуры.");
            while (!token.IsCancellationRequested)
            {
                if (Console.KeyAvailable)
                    token.Cancel();
                Task.Delay(500, token.Token);
            }
            Console.WriteLine("Выход из цикла чтения клавиатуры.");
}
    }
}
