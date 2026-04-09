var tasks = new[] { GetMessageAsync1(), GetMessageAsync2(), GetMessageAsync3() };

string[] results = await Task.WhenAll(tasks);

foreach (var res in results)
{
    Console.WriteLine(res);
}

async Task<string> GetMessageAsync1()
{
    await Task.Delay(TimeSpan.FromSeconds(2));
    return "hello from async";
}

async Task<string> GetMessageAsync2()
{
    await Task.Delay(TimeSpan.FromSeconds(5));
    return "hello from second async";
}

async Task<string> GetMessageAsync3()
{
    await Task.Delay(TimeSpan.FromSeconds(10));
    return "hello from third async";
}

























//var counter = 0;
//var locker = new object();
//void Increment()
//{
//    for (int i = 0; i < 100_000; i++)
//    {
//        if (counter < 150_000)
//        {
//            Interlocked.Increment(ref counter);
//        }
//    }
//}
//var t1 = Task.Run(Increment);
//var t2 = Task.Run(Increment);
//Task.WaitAll(t1, t2);
//Console.WriteLine(counter);
































//var counter = 0;
//var dummy = new object();

//var t1 = Task.Run(Increment);
//var t2 = Task.Run(Increment);

//Task.WaitAny(t1,  t2);

//Console.WriteLine($"The value of counter is {counter}");

//void Increment()
//{
//    for (var i = 0; i < 1_000_000_000; i++)
//    {
//        if (i > 0 && i % 100_000_000 == 0)
//        {
//            Console.WriteLine($"{i} was reached");
//        }

//        lock (dummy)
//        {
//            counter++;
//        }
//    }
//    Console.WriteLine("The job is completed");
//}
























//var t = new Thread(LongRunningTask);
//t.Name = "Thread1";
//t.IsBackground = true;

//var t2 = new Thread(LongRunningTask);
//t2.Name = "Thread2";
//t2.IsBackground = true;

//t.Start();
//t2.Start();
//Console.WriteLine("The worker thread has started");

//t.Join();
//t2.Join();
//Console.WriteLine("The program ends");
//void LongRunningTask()
//{
//    var list = new List<int>();

//    for (var i = 0; i < 1_000_000_000; i++)
//    {
//        if (i > 0 && i % 100_000_000 == 0)
//        {
//            Console.WriteLine($"{Thread.CurrentThread.Name}: {i} was reached");

//            list.Add(i);
//        }
//    }

//    Console.WriteLine($"{Thread.CurrentThread.Name}: the job is completed");
//}
