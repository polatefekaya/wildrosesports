using SportsApp.Core.ServiceContracts;
using SportsApp.Core.HelperContracts;
using SportsApp.Core.Helpers;
using SportsApp.Core.Services;
using Microsoft.EntityFrameworkCore;
using SportsApp.Infrastructure.Data.Player;
using SportsApp.Core.ServiceContracts.Infra.Player;
using SportsApp.Core.Services.Infra.Player;
using SportsApp.Core.ServiceContracts.Infra;
using SportsApp.Core.Services.Infra;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();
builder.Services.AddScoped<IFootballService, FootballService>();
builder.Services.AddScoped<IFootballServiceHelper, FootballServiceHelper>();

builder.Services.AddScoped<IOpenAIService, OpenAIService>();
builder.Services.AddScoped<IOpenAIServiceHelper, OpenAIServiceHelper>();

builder.Services.AddScoped<INewsService, NewsService>();
builder.Services.AddScoped<INewsServiceHelper, NewsServiceHelper>();

builder.Services.AddScoped<IConvertingHelper, ConvertingHelper>();

builder.Services.AddScoped<IPlayerEntityService, PlayerEntityService>();
builder.Services.AddScoped<ICardEntityService, CardEntityService>();
builder.Services.AddScoped<ITeamEntityService, TeamEntityService>();
builder.Services.AddScoped<ILeagueEntityService, LeagueEntityService>();
builder.Services.AddScoped<IGameEntityService, GameEntityService>();
builder.Services.AddScoped<IGoalEntityService, GoalEntityService>();
builder.Services.AddScoped<ISubstituteEntityService, SubstituteEntityService>();
builder.Services.AddScoped<IShotEntityService, ShotEntityService>();
builder.Services.AddScoped<IPassEntityService, PassEntityService>();
builder.Services.AddScoped<ITackleEntityService, TackleEntityService>();
builder.Services.AddScoped<IDuelEntityService, DuelEntityService>();
builder.Services.AddScoped<IFoulEntityService, FoulEntityService>();
builder.Services.AddScoped<IDribbleEntityService, DribbleEntityService>();
builder.Services.AddScoped<IPenaltyEntityService, PenaltyEntityService>();
builder.Services.AddScoped<IStatisticEntityService, StatisticEntityService>();

builder.Services.AddScoped<IEntityExceptionService, EntityExceptionService>();
builder.Services.AddScoped<IEntityService, EntityService>();
builder.Services.AddScoped<IPlayerDbService, PlayerDbService>();
builder.Services.AddScoped<IDbServiceHelper, DbServiceHelper>();

var connection = String.Empty;
if (builder.Environment.IsDevelopment()) {
    //builder.Configuration.AddEnvironmentVariables().AddJsonFile("appsettings.Development.json");
    connection = builder.Configuration.GetConnectionString("AZURE_SQL_CONNECTION");
    //connection = builder.Configuration.GetConnectionString("DefaultConnection");
} else {
    connection = Environment.GetEnvironmentVariable("AZURE_SQL_CONNECTION");
}

builder.Services.AddDbContext<PlayerDbContext>(options => {
    options.UseSqlServer(connection);
    options.EnableSensitiveDataLogging();
});


var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();


app.Run();
