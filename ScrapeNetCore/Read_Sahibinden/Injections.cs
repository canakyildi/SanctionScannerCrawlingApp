namespace Read_Sahibinden.Console;
public class Injections
{
    public static IHost MyConfigurationService()
    {
         return new HostBuilder().ConfigureServices((hostContext, services) =>
          {
              services.AddHttpClient();
              services.AddScoped<IReadDataService, ReadDataService>();
          }).UseConsoleLifetime().Build();
    }
}
