
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IConfiguration config = new ConfigurationBuilder()
                            .SetBasePath(Environment.CurrentDirectory)
                            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                            .Build();

//var ui = config.GetSection("game:ui").Value; 
//var x = config.GetSection("game:mapsettings:x").Value; 
//var y = config.GetSection("game:mapsettings:y").Value; 

//var mapSettings = config.GetSection("game:mapsettings").GetChildren();
//

var host = Host.CreateDefaultBuilder(args)
               .ConfigureServices(services =>
               {
                   services.AddSingleton<IConfiguration>(config);
                   services.AddSingleton<IUI, ConsoleUI>();
                   services.AddSingleton<IMap, Map>();
                   services.AddSingleton<Game>();
                   services.AddSingleton<ILimitedList<string>>(new MessageLog<string>(6));
                   services.AddSingleton<IMapSettings>(config.GetSection("game:mapsettings").Get<MapSettings>()!);
                   services.Configure<MapSettings>(config.GetSection("game:mapsettings").Bind);
               })
               .UseConsoleLifetime()
               .Build();

host.Services.GetRequiredService<Game>().Run();            

//var game = new Game(new ConsoleUI(), config);
//game.Run();

Console.WriteLine("Game over");
Console.ReadKey(); 