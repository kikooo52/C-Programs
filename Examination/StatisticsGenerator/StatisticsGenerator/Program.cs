namespace StatisticsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomStatisticsGenerator randomStatisticsGenerator = new RandomStatisticsGenerator(10000, 100);
            randomStatisticsGenerator.GenerateRandomStatistics();
            randomStatisticsGenerator.PrintStatisticsToConsole();
            randomStatisticsGenerator.WriteStatisticsToCsvFile("costeassd31.csv");       
        }
    }
}
