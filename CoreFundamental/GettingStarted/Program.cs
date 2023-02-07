using GettingStarted;

//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();
//app.MapGet("/", () => "Hello World!");
//app.Run();

// to print the value from appsettings.json
//"Position": {
//    "Title": "Editor",
//    "Name": "Joe Smith"
//  },
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var section = app.Configuration.GetSection("Position");
app.MapGet("/", () => section["Name"]);
app.Run();

//public class Programm
//{
//    public static void Main(string[] args)
//    {
//        IHostBuilder hostBuilder = CreateHostBuilder(args);
//        IHost host = hostBuilder.Build();
//        host.Run();
//    }
//    public static IHostBuilder CreateHostBuilder(string[] args)
//    {
//        return Host.CreateDefaultBuilder(args)
//            .ConfigureWebHostDefaults(x =>
//            {
//                x.UseStartup<StartupDevelopment>();
//            });
//    }
//}