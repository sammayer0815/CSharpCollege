class Opdracht_1
{
    static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            int fileNumber = i;
            Thread newThread = new Thread(() => readFile(fileNumber));
            newThread.Start();
        }
    }

    static void readFile(int fileNumber)
    {
        var lines = File.ReadLines($"Data/C5A_data_{fileNumber}.csv");
        int sum = 0;
        foreach (string line in lines)
        {
            string[] numbers = line.Split(',');
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += Int32.Parse(numbers[i]);
            }
        }

        Console.WriteLine($"File: {fileNumber} has a total value of {sum}");
    }
}