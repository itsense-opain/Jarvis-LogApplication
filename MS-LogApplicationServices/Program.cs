using LogApplication.DataAccess.DataAccessLogApplication;
using Microsoft.EntityFrameworkCore;
using NLog;
using NLog.Web;
// Inicializa Logger para guardar en archivo Log
var logger = NLog.LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
logger.Error("Inicio la ejecución");

try
{
    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.

    builder.Services.AddControllers();

    // Logger File
    builder.Logging.ClearProviders();
    builder.Host.UseNLog();

    //Data Layer
    builder.Services.AddTransient<ILogApplicacionData, LogApplicacionData>();

    var connectionString = builder.Configuration.GetConnectionString("LogAplicacionDB");
    builder.Services.AddDbContext<LogApplicationDbContext>(options => options.UseSqlServer(connectionString));


    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
catch (Exception e)
{
    logger.Error(e, "Error [500] Internal Server Error: Se detuvo el sistema por el siguiente error inesperado: " + e.Message);
	throw;
}
finally
{
    NLog.LogManager.Shutdown();
}


