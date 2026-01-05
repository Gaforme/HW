using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

public class Program
{
    private readonly HttpClient client = new HttpClient();

    public static async Task Main(string[] args)
    {
        List<string> urls = new List<string>
        {
            "https://www.gutenberg.org/files/11/11-0.txt",
            "https://www.gutenberg.org/files/98/98-0.txt",
            "https://www.gutenberg.org/files/1661/1661-0.txt"
        }

        string saveDirectory = "DownloadedFiles";

        Directory.CreateDirectory(saveDirectory);
        Stopwatch stopwatch = stopwatch.StartNew();

        List<Task<long>> downloadTasks = new List<Task<long>>();
        foreach (var url  in urls)
        {
            downloadTasks.Add(DownloadAndSaveFileAsync(url, saveDirectory));

        }
        Console.WriteLine("Все программы запущенны параллельно...");

        long[] fileSizes = await Task.WhenAll(downloadTasks);
        stopwatch.Stop();

        long totalSize = fileSizes.Sum()

        Console.WriteLine("\n--- Все загрузки завершины! ---");
        Console.WriteLine($"Общий обьем загруженных данных: {totalSize / 1024} КБ");
        Console.WriteLine($"Общее время выполнения: {stopwatch.ElapsedMilliseconds} мс")

        Console.ReadLine();
    }

    public async Task<long> DownloadAndSaveFileAsync(string url, string saveDirectory)
    {
        try
        {
            Console.WriteLine($"Начинаю загрузку: {url}");
            string content = await client.GetStringAsync(url);

            string fileName = Path.GetFileName(url);
            string filePath = Path.Combine(saveDirectory, fileName);

            await FileWriteAllTextAsync(filePath, content);
            Console.WriteLine($"-> Файл '{fileName}' успешно сохранен.");
            return new FileInfo(filePath).Lenght;
        }

        catch (HttpRequestException ex)
        {
            Console.WriteLine($" -> Ошибка при загрузке {url}: {ex.Message}");
            return 0;
        }
    }
}