namespace Task2_Threads
{
    public class Async
    {
        private async Task<string> ProcessDataAsync(string dataName)
        {
            await Task.Delay(3000);
            return $"Обработка '{dataName}' завершена за 3 секунды";
        }

        public async Task TestAsync()
        {
            Console.WriteLine("\nАсинхронная обработка");
            var tasks = new List<Task<string>>
            {
                ProcessDataAsync("Файл1"),
                ProcessDataAsync("Файл2"),
                ProcessDataAsync("Файл3")
            };

            while (tasks.Count > 0)
            {
                Task<string> completedTask = await Task.WhenAny(tasks);
                string result = await completedTask;
                Console.WriteLine(result);
                tasks.Remove(completedTask);
            }
        }
    }
}
