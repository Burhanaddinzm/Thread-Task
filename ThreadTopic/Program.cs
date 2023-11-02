//Thread
#region 1ci

//Thread thread = new Thread(ShowInt);
//thread.Start();
//Thread.Sleep(2000);

//for (int i = 0; i < 1000; i++)
//{
//    Console.WriteLine(i);
//}

//void ShowInt()
//{
//    for (int i = 1000; i > 0; i--)
//    {
//        Console.WriteLine(i);
//    }
//}

#endregion

#region 2ci HttpClient
////Async methodlari istifade eden zaman await istifade olunur
//HttpClient client = new HttpClient();   
//var result = await client.GetStringAsync("https://www.youtube.com/");
//Console.WriteLine(result);

#endregion

#region 3cu Task
using System.Formats.Asn1;

//await ShowNumbersAsync();
//async Task ShowNumbersAsync()
//{
//    Console.WriteLine(21312312);
//}
//-------------------------------------

Task<int> number = GetNumberAsync();
Console.WriteLine(await number);
async Task<int> GetNumberAsync()
{
    Task.Delay(1000);
    return 10;
}

//Alternative
//int number = await GetNumberAsync();
//Console.WriteLine(number);
//async Task<int> GetNumberAsync()
//{
//    Task.Delay(1000);
//    return 10;
//}

#endregion