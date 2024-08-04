
namespace Example.Ping.Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Host.ConfigureHostOptions(cf => cf.ShutdownTimeout = TimeSpan.FromSeconds(40));


        // Add services to the container.
        builder.Services.AddControllers();
        builder.Services.AddSingleton<IHostLifetime>(sp =>
            new DelayedShutdownHostLifetime(sp.GetRequiredService<IHostApplicationLifetime>(), TimeSpan.FromSeconds(5)));

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {

        }

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
