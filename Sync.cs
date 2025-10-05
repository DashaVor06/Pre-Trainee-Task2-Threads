namespace Task2_Threads
{
    public class Sync
    {
        private string ProcessData(string dataName)
        {
            Thread.Sleep(3000);
            return $"Обработка '{dataName}' завершена за 3 секунды";
        }

        public void TestSync()
        {
            Console.WriteLine("Синхронная обработка");
            Console.WriteLine(ProcessData("Файл1"));
            Console.WriteLine(ProcessData("Файл2"));
            Console.WriteLine(ProcessData("Файл3"));
        }
    }
}
