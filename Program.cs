// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Diagnostics;

ListTime();
ArrayListTime();
LinkedListTime();


static void ListTime()
{
    Stopwatch time = new();

    time.Start();

    List<int> listTest = new();

    for (int i = 0; i < 1000000; i++)
    {
        listTest.Add(i);
    }

    time.Stop();

    TimeSpan timeSpan = time.Elapsed;

    PrintResult("добавления элементов List", timeSpan);

    time.Start();

    int element = listTest[496753];

    time.Stop();

    TimeSpan elementSpan = time.Elapsed;

    PrintResult("поиск элемента в List", elementSpan);

    time.Start();

    foreach (var item in listTest)
    {
        if (item % 777 == 0)
        {
            // Console.Write($" {item}");
        }
    }

    time.Stop();

    TimeSpan sampleSpan = time.Elapsed;

    Console.WriteLine();
    PrintResult("выборку и печать элемента в List", sampleSpan);
}

static void ArrayListTime()
{
    Stopwatch time = new();

    time.Start();

    ArrayList listTest = new();

    for (int i = 0; i < 1000000; i++)
    {
        listTest.Add(i);
    }

    time.Stop();

    TimeSpan timeSpan = time.Elapsed;

    PrintResult("добавления элементов ArrayList", timeSpan);

    time.Start();

    int element = (int)listTest[496753];

    time.Stop();

    TimeSpan elementSpan = time.Elapsed;

    PrintResult("поиск элемента в ArrayList", elementSpan);

    time.Start();

    foreach (var item in listTest)
    {
        if ((int)item % 777 == 0)
        {
            Console.Write($" {item}");
        }
    }

    time.Stop();

    TimeSpan sampleSpan = time.Elapsed;

    Console.WriteLine();
    PrintResult("выборку и печать элемента в ArrayList", sampleSpan);
}

static void LinkedListTime()
{
    Stopwatch time = new();

    time.Start();

    LinkedList<int> listTest = new();

    for (int i = 0; i < 1000000; i++)
    {
        listTest.Append(i);
    }

    time.Stop();

    TimeSpan timeSpan = time.Elapsed;

    PrintResult("добавления элементов LinkedList", timeSpan);

    time.Start();

    int j = 0;

    foreach (int item in listTest)
    {
        if (j == 496753)
        {
            int element = item;
            break;
        }

        j++;
    }

    time.Stop();

    TimeSpan elementSpan = time.Elapsed;

    PrintResult("поиск элемента в LinkedList", elementSpan);

    time.Start();

    foreach (var item in listTest)
    {
        if (item % 777 == 0)
        {
            Console.Write($" {item}");
        }
    }

    time.Stop();

    TimeSpan sampleSpan = time.Elapsed;

    Console.WriteLine();
    PrintResult("выборку и печать элемента в LinkedList", sampleSpan);
}

static void PrintResult(string nameCollection, TimeSpan time)
{
    Console.WriteLine($"Затраченное время на {nameCollection}: минут - {time.Minutes:00}. секунд -  {time.Seconds:00}. миллисекунд - {time.Milliseconds:00}.");
}