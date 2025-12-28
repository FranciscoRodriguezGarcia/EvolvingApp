using Microsoft.Extensions.Hosting;

namespace EvolvingApp.Console;

public class Worker : BackgroundService
{


   protected override async Task ExecuteAsync(CancellationToken stoppingToken)
   {
      System.Console.WriteLine("Worker started");

      //     while (!stoppingToken.IsCancellationRequested)
      //   {
      System.Console.Clear();
      System.Console.Write("\r\n Insert first value... \n\r");
      var _x = Validator.Validate(System.Console.ReadKey());
      System.Console.WriteLine("\r\n Insert second value... \n\r");
      var _y = Validator.Validate(System.Console.ReadKey());
      System.Console.WriteLine("\r\n Calculating... \n\r");
      System.Console.WriteLine("\r\n Result " + Sum(_x, _y).ToString());
      await Task.Delay(8000, stoppingToken);
      // }
   }




   public int Sum(int x, int y)
   {
      return x + y;
   }

}