var host = Injections.MyConfigurationService();
var myService = host.Services.GetRequiredService<IReadDataService>();
var whileCondition = true;
while (whileCondition)
{
    await myService.ReadWebPageData();
    Console.WriteLine("True again False ShotDown");
    var response =  Console.ReadLine();
    whileCondition = Convert.ToBoolean(response);
}
